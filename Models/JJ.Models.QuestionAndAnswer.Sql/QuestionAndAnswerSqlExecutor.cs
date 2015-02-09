﻿using JJ.Framework.Persistence.SqlClient;
using JJ.Framework.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JJ.Models.QuestionAndAnswer.Sql
{
    public class QuestionAndAnswerSqlExecutor
    {
        private ISqlExecutor _sqlExecutor;

        public QuestionAndAnswerSqlExecutor(ISqlExecutor sqlExecutor)
        {
            if (sqlExecutor == null) throw new NullException(() => sqlExecutor);
            _sqlExecutor = sqlExecutor;
        }

        public IEnumerable<int> Question_GetPageOfIDs(int firstIndex, int count)
        {
            return _sqlExecutor.ExecuteReader<int>(SqlEnum.Question_GetPageOfIDs, new { firstIndex, count });
        }

        public int? Question_TryGetRandomID()
        {
            return (int?)_sqlExecutor.ExecuteScalar(SqlEnum.Question_TryGetRandomID);
        }

        public int Question_CountAll()
        {
            return (int)_sqlExecutor.ExecuteScalar(SqlEnum.Question_CountAll);
        }
    }
}