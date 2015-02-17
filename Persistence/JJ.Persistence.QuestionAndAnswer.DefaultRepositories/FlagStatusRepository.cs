﻿using JJ.Framework.Persistence;
using JJ.Persistence.QuestionAndAnswer.DefaultRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Persistence.QuestionAndAnswer.DefaultRepositories
{
    public class FlagStatusRepository : RepositoryBase<FlagStatus, int>, IFlagStatusRepository
    {
        public FlagStatusRepository(IContext context)
            : base(context)
        { }
    }
}