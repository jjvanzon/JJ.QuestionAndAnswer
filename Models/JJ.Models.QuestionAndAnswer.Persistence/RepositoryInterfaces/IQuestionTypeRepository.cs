﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJ.Models.QuestionAndAnswer.Persistence.RepositoryInterfaces
{
    public interface IQuestionTypeRepository
    {
        QuestionType Get(int id);
    }
}
