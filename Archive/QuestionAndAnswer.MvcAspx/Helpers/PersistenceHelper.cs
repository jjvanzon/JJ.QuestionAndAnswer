using JJ.Presentation.QuestionAndAnswer.Helpers;
using JJ.Framework.Data;
using JJ.Data.QuestionAndAnswer.DefaultRepositories.Interfaces;

namespace JJ.Presentation.QuestionAndAnswer.MvcAspx.Helpers
{
	internal static class PersistenceHelper
	{
		public static IContext CreateContext()
		{
			return ContextFactory.CreateContextFromConfiguration();
		}

		public static TRepositoryInterface CreateRepository<TRepositoryInterface>(IContext context)
		{
			return RepositoryFactory.CreateRepositoryFromConfiguration<TRepositoryInterface>(context);
		}

		public static Repositories CreateRepositories(IContext context)
		{
			return new Repositories(
				PersistenceHelper.CreateRepository<IQuestionRepository>(context),
				PersistenceHelper.CreateRepository<IAnswerRepository>(context),
				PersistenceHelper.CreateRepository<ICategoryRepository>(context),
				PersistenceHelper.CreateRepository<IQuestionCategoryRepository>(context),
				PersistenceHelper.CreateRepository<IQuestionLinkRepository>(context),
				PersistenceHelper.CreateRepository<IQuestionFlagRepository>(context),
				PersistenceHelper.CreateRepository<IFlagStatusRepository>(context),
				PersistenceHelper.CreateRepository<ISourceRepository>(context),
				PersistenceHelper.CreateRepository<IQuestionTypeRepository>(context),
				PersistenceHelper.CreateRepository<IUserRepository>(context));
		}
	}
}