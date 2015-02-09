﻿using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using JJ.Models.QuestionAndAnswer.NHibernate.Names;

namespace JJ.Models.QuestionAndAnswer.NHibernate.Mapping
{
    public class AnswerStatusMapping : ClassMap<AnswerStatus>
    {
        public AnswerStatusMapping()
        {
            Id(x => x.ID);
            Map(x => x.Description);

            HasMany(x => x.UserAnswers).KeyColumn(ColumnNames.AnswerStatusID).Inverse();
        }
    }
}