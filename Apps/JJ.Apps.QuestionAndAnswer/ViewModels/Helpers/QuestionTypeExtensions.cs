﻿using JJ.Models.QuestionAndAnswer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Apps.QuestionAndAnswer.ViewModels.Helpers
{
    internal static class QuestionTypeExtensions
    {
        public static QuestionTypeViewModel ToViewModel(this QuestionType entity)
        {
            if (entity == null) { throw new ArgumentNullException("entity"); }

            return new QuestionTypeViewModel 
            {
                ID = entity.ID,
                Name = entity.Name
            };
        }
    }
}
