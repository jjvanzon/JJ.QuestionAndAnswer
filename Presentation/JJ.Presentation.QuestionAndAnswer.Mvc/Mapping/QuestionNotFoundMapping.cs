﻿using JJ.Framework.Presentation.Mvc;
using JJ.Presentation.QuestionAndAnswer.Mvc.Names;
using JJ.Presentation.QuestionAndAnswer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JJ.Presentation.QuestionAndAnswer.Mvc.Mapping
{
    public class QuestionNotFoundMapping : ViewMapping<QuestionNotFoundViewModel>
    {
        public QuestionNotFoundMapping()
            : base(ViewNames.NotFound)
        {
            ControllerName = ControllerNames.Questions;
        }
    }
}