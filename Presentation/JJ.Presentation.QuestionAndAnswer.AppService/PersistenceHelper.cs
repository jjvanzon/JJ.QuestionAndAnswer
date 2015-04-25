﻿using JJ.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JJ.Presentation.QuestionAndAnswer.AppService
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
    }
}