﻿using JJ.Business.QuestionAndAnswer.Resources;
using JJ.Framework.Validation;
using JJ.Models.QuestionAndAnswer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JJ.Business.QuestionAndAnswer.Validation
{
    public class QuestionCategoryValidator : FluentValidator<QuestionCategory>
    {
        public QuestionCategoryValidator(QuestionCategory obj)
            : base(obj)
        { }

        protected override void Execute()
        {
            For(() => Object.Question, PropertyDisplayNames.Question)
                .NotNull();

            For(() => Object.Category, PropertyDisplayNames.Category)
                .NotNull();
        }
    }
}
