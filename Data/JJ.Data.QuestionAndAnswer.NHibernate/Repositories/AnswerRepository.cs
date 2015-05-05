﻿using JJ.Framework.Data;
using JJ.Framework.Data.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Data.QuestionAndAnswer.NHibernate.Repositories
{
    public class AnswerRepository : JJ.Data.QuestionAndAnswer.DefaultRepositories.AnswerRepository
    {
        private new NHibernateContext _context;

        public AnswerRepository(IContext context)
            : base(context)
        {
            _context = (NHibernateContext)context;
        }

        // TODO: Only use this if the default implementation turns out not to work.
        //public override Answer GetSingleByQuestionID(int questionID)
        //{
        //    Answer answer = _context.Session.QueryOver<Answer>()
        //                                    .Where(x => x.Question.ID == questionID)
        //                                    .SingleOrDefault();
        //    if (answer == null)
        //    {
        //        throw new Exception(String.Format("{0} with {1} ID '{2}' not found.", typeof(Answer).Name, typeof(Question).Name, questionID));
        //    }

        //    return answer;
        //}
    }
}