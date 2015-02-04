﻿using JJ.Framework.Persistence;
using JJ.Framework.Persistence.NHibernate;
using JJ.Models.QuestionAndAnswer.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Models.QuestionAndAnswer.NHibernate.Repositories
{
    public class QuestionRepository : JJ.Models.QuestionAndAnswer.DefaultRepositories.QuestionRepository
    {
        private new NHibernateContext _context;
        private QuestionAndAnswerSqlExecutor _sqlExecutor;

        public QuestionRepository(IContext context)
            : base(context)
        {
            _context = (NHibernateContext)context;
            _sqlExecutor = new QuestionAndAnswerSqlExecutor(new NHibernateSqlExecutor(_context.Session));
        }

        public override IList<Question> GetPage(int firstIndex, int count)
        {
            IList<Question> list = new List<Question>(count);

            IList<int> ids = _sqlExecutor.Question_GetPageOfIDs(firstIndex, count).ToArray();
            foreach (int id in ids)
            {
                Question entity = Get(id);
                list.Add(entity);
            }

            return list;
        }

        public override Question TryGetRandomQuestion()
        {
            int? randomID = _sqlExecutor.Question_TryGetRandomID();
            if (randomID.HasValue)
            {
                return Get(randomID.Value);
            }
            else
            {
                return null;
            }
        }
    }
}
