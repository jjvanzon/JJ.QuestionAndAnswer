﻿using JJ.Framework.Business;
using JJ.Framework.Reflection;
using JJ.Models.QuestionAndAnswer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Apps.QuestionAndAnswer.Helpers
{
    public class Repositories
    {
        public IQuestionRepository QuestionRepository { get; private set; }
        public IAnswerRepository AnswerRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IQuestionCategoryRepository QuestionCategoryRepository { get; private set; }
        public IQuestionLinkRepository QuestionLinkRepository { get; private set; }
        public IQuestionFlagRepository QuestionFlagRepository { get; private set; }
        public IFlagStatusRepository FlagStatusRepository { get; private set; }
        public ISourceRepository SourceRepository { get; private set; }
        public IQuestionTypeRepository QuestionTypeRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }

        public EntityStatusManager EntityStatusManager { get; private set; }

        public Repositories(
            IQuestionRepository questionRepository,
            IAnswerRepository answerRepository,
            ICategoryRepository categoryRepository,
            IQuestionCategoryRepository questionCategoryRepository,
            IQuestionLinkRepository questionLinkRepository,
            IQuestionFlagRepository questionFlagRepository,
            IFlagStatusRepository flagStatusRepository,
            ISourceRepository sourceRepository,
            IQuestionTypeRepository questionTypeRepository,
            IUserRepository userRepository)
        {
            if (questionRepository == null) throw new NullException(() => questionRepository);
            if (answerRepository == null) throw new NullException(() => answerRepository);
            if (categoryRepository == null) throw new NullException(() => categoryRepository);
            if (questionCategoryRepository == null) throw new NullException(() => questionCategoryRepository);
            if (questionLinkRepository == null) throw new NullException(() => questionLinkRepository);
            if (questionFlagRepository == null) throw new NullException(() => questionFlagRepository);
            if (sourceRepository == null) throw new NullException(() => sourceRepository);
            if (questionTypeRepository == null) throw new NullException(() => questionTypeRepository);
            if (userRepository == null) throw new NullException(() => userRepository);

            QuestionRepository = questionRepository;
            AnswerRepository = answerRepository;
            CategoryRepository = categoryRepository;
            QuestionCategoryRepository = questionCategoryRepository;
            QuestionLinkRepository = questionLinkRepository;
            QuestionFlagRepository = questionFlagRepository;
            FlagStatusRepository = flagStatusRepository;
            SourceRepository = sourceRepository;
            QuestionTypeRepository = questionTypeRepository;
            UserRepository = userRepository;

            EntityStatusManager = new EntityStatusManager();
        }
    }
}
