﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JJ.Models.QuestionAndAnswer.Persistence.RepositoryInterfaces;
using JJ.Framework.Persistence;

namespace JJ.Models.QuestionAndAnswer.Persistence.Repositories
{
    public class QuestionTypeRepository : IQuestionTypeRepository
    {
        private IContext _context;

        public QuestionTypeRepository(IContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            _context = context;
        }

        public QuestionType Get(int id)
        {
            return _context.Get<QuestionType>(id);
        }
    }
}