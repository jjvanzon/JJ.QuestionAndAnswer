﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JJ.Apps.QuestionAndAnswer.ViewModels
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecurityToken { get; set; } 

        public bool IsAuthenticated { get; set; }
    }
}
