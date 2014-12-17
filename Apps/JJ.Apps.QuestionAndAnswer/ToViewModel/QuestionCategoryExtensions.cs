﻿using JJ.Apps.QuestionAndAnswer.Helpers;
using JJ.Apps.QuestionAndAnswer.ViewModels;
using JJ.Apps.QuestionAndAnswer.ViewModels.Entities;
using JJ.Framework.Reflection;
using JJ.Models.QuestionAndAnswer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Apps.QuestionAndAnswer.ToViewModel
{
    internal static class QuestionCategoryExtensions
    {
        public static QuestionCategoryViewModel ToViewModel(this QuestionCategory questionCategory)
        {
            if (questionCategory == null) throw new NullException(() => questionCategory);

            var questionCategoryViewModel = new QuestionCategoryViewModel
            {
                QuestionCategoryID = questionCategory.ID,
                TemporaryID = Guid.NewGuid()
            };

            if (questionCategory.Category != null)
            {
                questionCategoryViewModel.Category = questionCategory.Category.ToViewModel();
            }
            else
            {
                questionCategoryViewModel.Category = ViewModelHelper.CreateEmptyCategoryViewModel();
            }

            return questionCategoryViewModel;
        }
    }
}
