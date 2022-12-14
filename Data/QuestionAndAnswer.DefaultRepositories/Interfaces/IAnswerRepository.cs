using JJ.Framework.Data;

namespace JJ.Data.QuestionAndAnswer.DefaultRepositories.Interfaces
{
    public interface IAnswerRepository : IRepository<Answer, int>
    {
        Answer TryGetByQuestionID(int questionID);
        Answer GetByQuestionID(int questionID);
    }
}
