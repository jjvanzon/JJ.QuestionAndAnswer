﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JJ.Framework.Data;

namespace JJ.Data.QuestionAndAnswer.DefaultRepositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        Category TryGetByIdentifier(string identifier);
        Category TryGetCategoryByParentAndIdentifier(Category parentCategory, string identifier);
        IList<Category> GetRootCategories();
    }
}