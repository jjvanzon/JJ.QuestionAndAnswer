﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Apps.QuestionAndAnswer.Extensions
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

        public static List<JJ.Models.Canonical.ValidationMessage> ToCanonical(this IEnumerable<JJ.Framework.Validation.ValidationMessage> sourceList)
        {
            var destList = new List<JJ.Models.Canonical.ValidationMessage>();

            foreach (JJ.Framework.Validation.ValidationMessage sourceItem in sourceList)
            {
                JJ.Models.Canonical.ValidationMessage destItem = sourceItem.ToCanonical();
                destList.Add(destItem);
            }

            return destList;
        }
    }
}