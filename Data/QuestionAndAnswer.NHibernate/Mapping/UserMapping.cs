using FluentNHibernate.Mapping;
using JetBrains.Annotations;
using JJ.Data.QuestionAndAnswer.NHibernate.Names;

namespace JJ.Data.QuestionAndAnswer.NHibernate.Mapping
{
    [UsedImplicitly]
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Table(nameof(TableNames.Users));

            Id(x => x.ID);

            Map(x => x.DisplayName);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.SecuritySalt);

            HasMany(x => x.Runs).KeyColumn(ColumnNames.UserID).Inverse();
            HasMany(x => x.UserAnswers).KeyColumn(ColumnNames.UserID).Inverse();
            HasMany(x => x.AsLastModifiedByInQuestions).KeyColumn(ColumnNames.ModifiedByUserID).Inverse();
            HasMany(x => x.AsFlaggedByInQuestionFlags).KeyColumn(ColumnNames.FlaggedByUserID).Inverse();
            HasMany(x => x.AsLastModifiedByInQuestionFlags).KeyColumn(ColumnNames.LastModifiedByUserID).Inverse();
        }
    }
}
