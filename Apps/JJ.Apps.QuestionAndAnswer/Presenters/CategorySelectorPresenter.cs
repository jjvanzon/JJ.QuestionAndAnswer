﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JJ.Framework.Common;
using JJ.Framework.Persistence;
using JJ.Models.QuestionAndAnswer;
using JJ.Models.QuestionAndAnswer.Persistence.Repositories;
using JJ.Models.QuestionAndAnswer.Persistence.RepositoryInterfaces;
using JJ.Business.QuestionAndAnswer;
using JJ.Apps.QuestionAndAnswer.ViewModels;
using JJ.Apps.QuestionAndAnswer.ViewModels.Helpers;

namespace JJ.Apps.QuestionAndAnswer.Presenters
{
    public class CategorySelectorPresenter
    {
        private ICategoryRepository _categoryRepository;
        private IQuestionRepository _questionRepository;
        private IQuestionFlagRepository _questionFlagRepository;
        private IFlagStatusRepository _flagStatusRepository;
        private IUserRepository _userRepository;

        private CategoryManager _categoryManager;

        public CategorySelectorPresenter(
            ICategoryRepository categoryRepository, 
            IQuestionRepository questionRepository,
            IQuestionFlagRepository questionFlagRepository,
            IFlagStatusRepository flagStatusRepository,
            IUserRepository userRepository)
        {
            if (categoryRepository == null) throw new ArgumentNullException("categoryRepository");
            if (questionRepository == null) throw new ArgumentNullException("questionRepository");
            if (questionFlagRepository == null) throw new ArgumentNullException("questionFlagRepository");
            if (flagStatusRepository == null) throw new ArgumentNullException("flagStatusRepository");
            if (userRepository == null) throw new ArgumentNullException("userRepository");

            _categoryRepository = categoryRepository;
            _questionRepository = questionRepository;
            _questionFlagRepository = questionFlagRepository;
            _flagStatusRepository = flagStatusRepository;
            _userRepository = userRepository;

            _categoryManager = new CategoryManager(_categoryRepository);
        }

        public CategorySelectorViewModel Show()
        {
            return GetViewModel();
        }

        /// <summary>
        /// Required to pass along with the view model:
        /// the ID's of the already selected categories and the categoryID of the category to add.
        /// </summary>
        public CategorySelectorViewModel Add(CategorySelectorViewModel viewModel, int categoryID)
        {
            // TODO: I need to rebuild the complete viewmodel here, because the passed view model is not in tact.
            // But this does not comform to the stateful / stateless nature of the presenters.

            var selectedCategoryIDs = new List<int>();
            AddSelectedCategoryIDsRecursive(selectedCategoryIDs, viewModel.SelectedCategories);
            selectedCategoryIDs.Add(categoryID);

            return GetViewModel(selectedCategoryIDs);
        }

        /// <summary>
        /// Required to pass along with the view model:
        /// the ID's of the already selected categories and the categoryID of the category to remove.
        /// </summary>
        public CategorySelectorViewModel Remove(CategorySelectorViewModel viewModel, int categoryID)
        {
            // TODO: I need to rebuild the complete viewmodel here, because the passed view model is not in tact.
            // But this does not comform to the stateful / stateless nature of the presenters.

            var selectedCategoryIDs = new List<int>();
            AddSelectedCategoryIDsRecursive(selectedCategoryIDs, viewModel.SelectedCategories);

            while (selectedCategoryIDs.Contains(categoryID)) // while is for when there are duplicates
            {
                selectedCategoryIDs.Remove(categoryID);
            }

            return GetViewModel(selectedCategoryIDs);
        }

        public QuestionDetailViewModel ShowQuestions(CategorySelectorViewModel viewModel)
        {
            var categoryIDs = new List<int>();
            AddSelectedCategoryIDsRecursive(categoryIDs, viewModel.SelectedCategories);

            var questionPresenter = new QuestionPresenter(_questionRepository, _categoryRepository, _questionFlagRepository, _flagStatusRepository, _userRepository);
            return questionPresenter.ShowQuestion(categoryIDs.ToArray());
        }

        // Private Methods

        // TODO: Use GetRecursive method.

        private CategorySelectorViewModel GetViewModel()
        {
            List<CategoryViewModel> availableCategories = GetCategoryViewModelRecursive();
            List<CategoryViewModel> selectedCategories = GetCategoryViewModelRecursive();

            HideAllNodesRecursive(selectedCategories);

            var viewModel = new CategorySelectorViewModel
            {
                AvailableCategories = availableCategories,
                SelectedCategories = selectedCategories
            };

            viewModel.NoCategoriesAvailable = viewModel.AvailableCategories.Count == 0;

            return viewModel;
        }

        private CategorySelectorViewModel GetViewModel(IEnumerable<int> selectedCategoryIDs)
        {
            CategorySelectorViewModel viewModel = GetViewModel();
            HideSelectedLeafNodesRecursive(viewModel.AvailableCategories, selectedCategoryIDs);
            ShowSelectedNodesRecursive(viewModel.SelectedCategories, selectedCategoryIDs);
            return viewModel;
        }

        private List<CategoryViewModel> GetCategoryViewModelRecursive()
        {
            IEnumerable<Category> categories = _categoryManager.GetCategoryTree();

            var viewModels = new List<CategoryViewModel>();

            foreach (Category category in categories)
            {
                CategoryViewModel viewModel = category.ToViewModelRecursive();
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        private void HideAllNodesRecursive(List<CategoryViewModel> categoryViewModels)
        {
            foreach (CategoryViewModel categoryViewModel in categoryViewModels)
            {
                categoryViewModel.Visible = false;

                HideAllNodesRecursive(categoryViewModel.SubCategories);
            }
        }

        private void AddSelectedCategoryIDsRecursive(List<int> outputList, List<CategoryViewModel> categoryViewModels)
        {
            if (categoryViewModels == null)
            {
                return;
            }

            foreach (CategoryViewModel categoryViewModel in categoryViewModels)
            {
                if (categoryViewModel.Visible)
                {
                    outputList.Add(categoryViewModel.ID);
                }

                AddSelectedCategoryIDsRecursive(outputList, categoryViewModel.SubCategories);
            }
        }

        private void ShowSelectedNodesRecursive(List<CategoryViewModel> categoryViewModels, IEnumerable<int> selectedCategoryIDs)
        {
            foreach (CategoryViewModel categoryViewModel in categoryViewModels)
            {
                bool isSelected = selectedCategoryIDs.Contains(categoryViewModel.ID);
                if (isSelected)
                {
                    categoryViewModel.Visible = true;
                }

                ShowSelectedNodesRecursive(categoryViewModel.SubCategories, selectedCategoryIDs);
            }
        }

        private void HideSelectedLeafNodesRecursive(List<CategoryViewModel> categoryViewModels, IEnumerable<int> selectedCategoryIDs)
        {
            foreach (CategoryViewModel categoryViewModel in categoryViewModels)
            {
                bool isSelected = selectedCategoryIDs.Contains(categoryViewModel.ID);
                bool isLeaf = categoryViewModel.SubCategories.Count == 0;

                if (isSelected && isLeaf)
                {
                    categoryViewModel.Visible = false;
                }

                HideSelectedLeafNodesRecursive(categoryViewModel.SubCategories, selectedCategoryIDs);
            }
        }

        // A start at code, that works statefully.

        //private CategorySelectorViewModel _viewModel;

        /*public void Add(int categoryID)
        {
            if (_viewModel == null)
            {
                throw new Exception("Call Show before calling other methods.");
            }
            
            bool alreadyPresent = _viewModel.SelectedCategories.Any(x => x.ID == categoryID);
            if (!alreadyPresent)
            {
                Category category = _categoryRepository.Get(categoryID);
                CategoryViewModel categoryModel = category.ToViewModel();
                _viewModel.SelectedCategories.Add(categoryModel);
            }
        }*/
    }
}
