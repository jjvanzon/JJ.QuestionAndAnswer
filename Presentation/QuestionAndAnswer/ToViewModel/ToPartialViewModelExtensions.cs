using JJ.Presentation.QuestionAndAnswer.ViewModels.Partials;
using JJ.Data.QuestionAndAnswer;
using JJ.Framework.Exceptions.Basic;

namespace JJ.Presentation.QuestionAndAnswer.ToViewModel
{
    internal static class ToPartialViewModelExtensions
    {
        public static CurrentUserQuestionFlagPartialViewModel ToCurrentUserQuestionFlagViewModel(this QuestionFlag entity)
        {
            if (entity == null) throw new NullException(() => entity);

            return new CurrentUserQuestionFlagPartialViewModel
            {
                CanFlag = true,
                IsFlagged = true,
                Comment = entity.Comment
            };
        }

        public static LoginPartialViewModel ToLoginPartialViewModel(this User user)
        {
            if (user == null) throw new NullException(() => user);

            return new LoginPartialViewModel
            {
                UserDisplayName = user.DisplayName,
                CanLogOut = true
            };
        }
    }
}
