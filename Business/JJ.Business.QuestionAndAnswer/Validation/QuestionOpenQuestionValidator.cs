﻿using JJ.Business.QuestionAndAnswer.Extensions;
using JJ.Business.QuestionAndAnswer.Enums;
using JJ.Framework.Validation;
using JJ.Models.QuestionAndAnswer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JJ.Business.QuestionAndAnswer.Resources;

namespace JJ.Business.QuestionAndAnswer.Validation
{
    public class QuestionOpenQuestionValidator : FluentValidator<Question>
    {
        public QuestionOpenQuestionValidator(Question question)
            : base(question)
        { }

        protected override void Execute()
        {
            For(X.GetQuestionTypeEnum(), PropertyDisplayNames.QuestionTypeEnum)
                .IsValue(QuestionTypeEnum.OpenQuestion);

            For(X.Answers.Count, PropertyDisplayNames.AnswersCount)
                .IsValue(1);

            if (X.Answers.Count > 0)
            {
                For(X.Answers[0].IsCorrectAnswer, PropertyDisplayNames.IsCorrectAnswer)
                    .IsValue(true);
            }
        }
    }
}