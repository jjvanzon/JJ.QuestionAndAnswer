﻿using JJ.Models.QuestionAndAnswer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Apps.QuestionAndAnswer.ViewModels.Helpers
{
    internal static class SourceExtensions
    {
        public static SourceViewModel ToViewModel(this Source entity)
        {
            if (entity == null) { throw new ArgumentNullException("entity"); }

            return new SourceViewModel
            {
                ID = entity.ID,
                Description = entity.Description,
                Url = entity.Url
            };
        }
    }
}