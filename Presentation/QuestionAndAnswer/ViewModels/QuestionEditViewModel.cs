﻿using JJ.Presentation.QuestionAndAnswer.ViewModels.Entities;
using JJ.Presentation.QuestionAndAnswer.ViewModels.Partials;
using JJ.Data.Canonical;
using System.Collections.Generic;
using JJ.Framework.Presentation;

namespace JJ.Presentation.QuestionAndAnswer.ViewModels
{
    public sealed class QuestionEditViewModel
    {
        public LoginPartialViewModel Login { get; set; }

        public QuestionViewModel Question { get; set; }

        public IList<string> ValidationMessages { get; set; }

        public IList<CategoryViewModel> AllCategories { get; set; }

        public string Title { get; set; }
        public bool IsNew { get; set; }
        public bool CanDelete { get; set; }

        public ActionInfo ReturnAction { get; set; }
    }
}
