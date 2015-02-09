﻿using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using JJ.Models.QuestionAndAnswer.NHibernate.Names;

namespace JJ.Models.QuestionAndAnswer.NHibernate.Mapping
{
    public class FlagStatusMapping : ClassMap<FlagStatus>
    {
        public FlagStatusMapping()
        {
            Id(x => x.ID);
            Map(x => x.Description);

            HasMany(x => x.QuestionFlags).KeyColumn(ColumnNames.FlagStatusID).Inverse();
        }
    }
}