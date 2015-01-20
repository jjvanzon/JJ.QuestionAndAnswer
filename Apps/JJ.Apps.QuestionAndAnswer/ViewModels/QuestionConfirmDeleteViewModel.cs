﻿using JJ.Apps.QuestionAndAnswer.ViewModels.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JJ.Apps.QuestionAndAnswer.ViewModels
{
    public sealed class QuestionConfirmDeleteViewModel
    {
        public LoginPartialViewModel Login { get; set; }
        public LanguageSelectorPartialViewModel LanguageSelector { get; set; }

        public int ID { get; set; }
        public string Question { get; set; }
    }
}
