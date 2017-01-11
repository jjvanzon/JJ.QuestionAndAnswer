﻿using JJ.Business.QuestionAndAnswer.Extensions;
using JJ.Business.QuestionAndAnswer.Enums;
using JJ.Framework.Validation;
using JJ.Data.QuestionAndAnswer;
using System.Linq;
using JJ.Business.QuestionAndAnswer.Resources;

namespace JJ.Business.QuestionAndAnswer.Validation
{
    /// <summary> For full validation, also execute BasicQuestionValidator. </summary>
    public class MultipleChoiceQuestionValidator : VersatileValidator_WithoutConstructorArgumentNullCheck<Question>
    {
        /// <summary> For full validation, also execute BasicQuestionValidator. </summary>
        public MultipleChoiceQuestionValidator(Question question)
            : base(question)
        { }

        protected override void Execute()
        {
            if (Object.QuestionType != null)
            {
                For(() => Object.GetQuestionTypeEnum(), PropertyDisplayNames.QuestionType)
                    .Is(QuestionTypeEnum.MultipleChoice);
            }

            For(() => Object.Answers.Count, PropertyDisplayNames.AnswersCount)
                .GreaterThan(1);

            For(() => Object.Answers.Where(x => x.IsCorrectAnswer).Count(), PropertyDisplayNames.CorrectAnswerCount)
                .Is(1);
        }
    }
}