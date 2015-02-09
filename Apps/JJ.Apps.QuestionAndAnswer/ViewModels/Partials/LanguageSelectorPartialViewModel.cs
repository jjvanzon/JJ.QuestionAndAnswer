﻿using JJ.Apps.QuestionAndAnswer.ViewModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JJ.Apps.QuestionAndAnswer.ViewModels.Partials
{
    public sealed class LanguageSelectorPartialViewModel
    {
        public string SelectedLanguageCultureName { get; set; }
        public IList<LanguageViewModel> Languages { get; set; }
    }
}