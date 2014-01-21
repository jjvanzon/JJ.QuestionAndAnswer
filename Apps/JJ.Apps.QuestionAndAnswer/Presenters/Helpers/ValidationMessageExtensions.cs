﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Apps.QuestionAndAnswer.Presenters.Helpers
{
    internal static class ValidationMessageExtensions
    {
        public static JJ.Models.Canonical.ValidationMessage ToCanonical(this JJ.Framework.Validation.ValidationMessage sourceEntity)
        {
            return new Models.Canonical.ValidationMessage
            {
                PropertyKey = sourceEntity.PropertyKey,
                Text = sourceEntity.Text
            };
        }
    }
}