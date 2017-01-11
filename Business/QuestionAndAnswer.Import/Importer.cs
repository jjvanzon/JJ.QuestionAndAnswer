﻿using System;
using System.Collections.Generic;
using System.IO;
using JJ.Data.QuestionAndAnswer;
using JJ.Data.QuestionAndAnswer.DefaultRepositories.Interfaces;
using JJ.Business.QuestionAndAnswer.Extensions;
using JJ.Framework.Exceptions;

namespace JJ.Business.QuestionAndAnswer.Import
{
    /// <summary>
    /// Runs a selector and a converter and returns progress info.
    /// </summary>
    public class Importer<TModel, TSelector, TConverter> : IImporter
        where TSelector : ISelector<TModel>, new()
        where TConverter : ConverterBase<TModel>
    {
        private Source _source;

        private IQuestionRepository _questionRepository;
        private IAnswerRepository _answerRepository;
        private ICategoryRepository _categoryRepository;
        private IQuestionCategoryRepository _questionCategoryRepository;
        private IQuestionLinkRepository _questionLinkRepository;
        private IQuestionTypeRepository _questionTypeRepository;
        private ISourceRepository _sourceRepository;
        private IQuestionFlagRepository _questionFlagRepository;

        private Action<string> _progressCallback;
        private Func<bool> _isCancelledCallback;

        private string _categoryIdenfier;

        /// <param name="categoryIdentifier">Defines an extra category to use for the converter.</param>
        public Importer(
            IQuestionRepository questionRepository,
            IAnswerRepository answerRepository,
            ICategoryRepository categoryRepository,
            IQuestionCategoryRepository questionCategoryRepository,
            IQuestionLinkRepository questionLinkRepository,
            IQuestionTypeRepository questionTypeRepository,
            ISourceRepository sourceRepository,
            IQuestionFlagRepository questionFlagRepository,
            Source source,
            string categoryIdenfier)
        {
            if (questionRepository == null) throw new NullException(() => questionRepository);
            if (answerRepository == null) throw new NullException(() => answerRepository);
            if (categoryRepository == null) throw new NullException(() => categoryRepository);
            if (questionCategoryRepository == null) throw new NullException(() => questionCategoryRepository);
            if (questionLinkRepository == null) throw new NullException(() => questionLinkRepository);
            if (questionTypeRepository == null) throw new NullException(() => questionTypeRepository);
            if (sourceRepository == null) throw new NullException(() => sourceRepository);
            if (questionFlagRepository == null) throw new NullException(() => questionFlagRepository);
            if (source == null) throw new NullException(() => source);

            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _categoryRepository = categoryRepository;
            _questionCategoryRepository = questionCategoryRepository;
            _questionLinkRepository = questionLinkRepository;
            _questionTypeRepository = questionTypeRepository;
            _sourceRepository = sourceRepository;
            _questionFlagRepository = questionFlagRepository;

            _source = source;
            _categoryIdenfier = categoryIdenfier;
        }

        public void Execute(string filePath, Action<string> progressCallback = null, Func<bool> isCancelledCallback = null)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Execute(stream, progressCallback, isCancelledCallback);
            }
        }

        public void Execute(Stream stream, Action<string> progressCallback = null, Func<bool> isCancelledCallback = null)
        {
            //try
            //{

            if (stream == null) throw new NullException(() => stream);

            _progressCallback = progressCallback;
            _isCancelledCallback = isCancelledCallback;

            DoProgressCallback("Processing...");

            DeleteExistingQuestions();

            if (!DoImport(stream))
            {
                return;
            }

            DoProgressCallback("Done.");

            //}
            //catch (Exception ex)
            //{
            //    DoProgressCallback(ex.Message);
            //}
        }

        private bool DoImport(Stream stream)
        {
            int counter = 0;

            var selector = new TSelector();
            var converter = CreateConverter();

            foreach (TModel model in selector.GetSelection(stream))
            {
                if (DoIsCancelledCallback())
                {
                    DoProgressCallback("Cancelled.");
                    return false;
                }

                converter.ConvertToEntities(model);

                counter++;
                DoProgressCallback(String.Format("Processing: {0}", counter));
            }

            return true;
        }

        private TConverter CreateConverter()
        {
            return (TConverter)Activator.CreateInstance(typeof(TConverter),
                _questionRepository,
                _answerRepository,
                _categoryRepository,
                _questionCategoryRepository,
                _questionLinkRepository,
                _questionTypeRepository,
                _sourceRepository,
                _source,
                _categoryIdenfier);
        }

        private void DeleteExistingQuestions()
        {
            foreach (Question question in GetExistingQuestions())
            {
                question.DeleteRelatedEntities(_answerRepository, _questionCategoryRepository, _questionLinkRepository, _questionFlagRepository);
                _questionRepository.Delete(question);
            }
        }

        private IList<Question> GetExistingQuestions()
        {
            // _source.ID could be 0 for a new repository, but in that case there are no existing questions anyway and this method will return an empty collection.
            return _questionRepository.GetBySourceID(_source.ID);
        }

        private void DoProgressCallback(string message)
        {
            if (_progressCallback != null) _progressCallback(message);
        }

        private bool DoIsCancelledCallback()
        {
            if (_isCancelledCallback != null)
            {
                return _isCancelledCallback();
            }

            return false;
        }
    }
}