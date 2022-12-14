using System.Linq;
using JJ.Business.QuestionAndAnswer.Enums;
using JJ.Business.QuestionAndAnswer.Extensions;
using JJ.Business.QuestionAndAnswer.Resources;
using JJ.Data.QuestionAndAnswer;
using JJ.Framework.Exceptions.Basic;
using JJ.Framework.Validation;

namespace JJ.Business.QuestionAndAnswer.Validation
{
    /// <summary> For full validation, also execute BasicQuestionValidator. </summary>
    public class SeveralMayApplyQuestionValidator : VersatileValidator
    {
        /// <summary> For full validation, also execute BasicQuestionValidator. </summary>
        public SeveralMayApplyQuestionValidator(Question entity)
        {
            if (entity == null) throw new NullException(() => entity);

            if (entity.QuestionType != null)
            {
                For(entity.GetQuestionTypeEnum(), ResourceFormatter.QuestionType)
                    .Is(QuestionTypeEnum.SeveralMayApply);
            }

            For(entity.Answers.Count, ResourceFormatter.AnswersCount)
                .GreaterThan(1);

            For(entity.Answers.Where(x => x.IsCorrectAnswer).Count(), ResourceFormatter.CorrectAnswerCount)
                .GreaterThan(1);
        }
    }
}
