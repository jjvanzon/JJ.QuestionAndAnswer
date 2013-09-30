﻿using JJ.Framework.Persistence;
using JJ.Models.QuestionAndAnswer.Persistence.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JJ.Models.QuestionAndAnswer.Persistence.RepositoryInterfaces;

namespace JJ.Models.QuestionAndAnswer.Persistence.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private IContext _context;

        private SqlExecutor _sqlExecutor;

        public QuestionRepository(IContext context, string sqlConnectionString)
        {
            if (context == null) throw new ArgumentNullException("context");

            _context = context;

            _sqlExecutor = new SqlExecutor(sqlConnectionString);
        }

        public IEnumerable<Question> GetAll()
        {
            return _context.Query<Question>().ToArray();
        }

        public Question TryGet(int id)
        {
            return _context.TryGet<Question>(id);
        }

        public Question Get(int id)
        {
            return _context.Get<Question>(id);
        }

        public Question Create()
        {
            Question entity = _context.Create<Question>();
            return entity;
        }

        public void Delete(Question question)
        {
            _context.Delete(question);
        }

        public void Commit()
        {
            _context.Commit();
        }

        public Question TryGetRandomQuestion()
        {
            int? randomID = _sqlExecutor.TryGetRandomQuestionID();
            if (randomID.HasValue)
            {
                return Get(randomID.Value);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Question> GetBySource(int sourceID)
        {
            return _context.Query<Question>().Where(x => x.Source.ID == sourceID);
        }

        // TODO: Handle circularities.

        public int[] GetQuestionIDsByCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException("category");

            List<int> ids = GetQuestionIDsByCategoryRecursive(category);
            return ids.Distinct().ToArray();
        }

        private List<int> GetQuestionIDsByCategoryRecursive(Category category)
        {
            List<int> ids = category.CategoryQuestions.Select(x => x.Question.ID).ToList();

            foreach (Category subCategory in category.SubCategories)
            {
                var ids2 = GetQuestionIDsByCategory(subCategory);
                ids.AddRange(ids2);
            }

            return ids;
        }
    }
}
