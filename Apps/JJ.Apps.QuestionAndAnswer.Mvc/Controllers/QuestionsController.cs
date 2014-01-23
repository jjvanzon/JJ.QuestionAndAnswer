﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JJ.Framework.Persistence;
using JJ.Apps.QuestionAndAnswer.ViewModels;
using JJ.Apps.QuestionAndAnswer.Presenters;
using JJ.Models.QuestionAndAnswer.Persistence.RepositoryInterfaces;
using JJ.Apps.QuestionAndAnswer.Mvc.Controllers.Helpers;
using JJ.Framework.Common;
using JJ.Framework.Presentation;
using JJ.Models.Canonical;
using JJ.Apps.QuestionAndAnswer.Mvc.Views;
using JJ.Apps.QuestionAndAnswer.ViewModels.Helpers;
using JJ.Apps.QuestionAndAnswer.Mvc.Views.Helpers;

namespace JJ.Apps.QuestionAndAnswer.Mvc.Controllers
{
    public class QuestionsController : MasterController
    {
        public QuestionsController()
        {
            // The request must not be validated because so much text in the questions and answers will contain '<' and '>' characters,
            // because many questions are about HTML.
            ValidateRequest = false;
        }

        // GET: /Questions
        // GET: /Questions/Index

        public ActionResult Index()
        {
            QuestionListPresenter presenter = CreateListPresenter();
            QuestionListViewModel viewModel = presenter.Show();
            return View(viewModel);
        }

        // GET: /Questions/Details/5

        public ActionResult Details(int id)
        {
            QuestionDetailsPresenter presenter = CreateDetailPresenter();
            object viewModel = presenter.Show(id);

            var detailModel = viewModel as QuestionDetailsViewModel;
            if (detailModel != null)
            {
                return View(detailModel);
            }

            var notFoundViewModel = viewModel as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // GET: /Questions/Create

        public ActionResult Create()
        {
            object viewModel;
            if (TempData.ContainsKey(TempDataKeys.ViewModel))
            {
                viewModel = TempData[TempDataKeys.ViewModel];
            }
            else
            {
                QuestionEditPresenter presenter = CreateEditPresenter();
                viewModel = presenter.Create();
            }

            var editViewModel = viewModel as QuestionEditViewModel;
            if (editViewModel != null)
            {
                foreach (ValidationMessage validationMessage in editViewModel.ValidationMessages)
                {
                    ModelState.AddModelError(validationMessage.PropertyKey, validationMessage.Text);
                }

                return View(ViewNames.Edit, editViewModel);
            }

            var notFoundViewModel = viewModel as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // POST: /Questions/Create

        /// <summary> Post create. Saves the new question. </summary>
        [HttpPost]
        public ActionResult Create(QuestionEditViewModel viewModel)
        {
            QuestionEditPresenter presenter = CreateEditPresenter();
            object viewModel2 = presenter.Save(viewModel);

            var editViewModel = viewModel2 as QuestionEditViewModel;
            if (editViewModel != null)
            {
                TempData[TempDataKeys.ViewModel] = editViewModel;
                return RedirectToAction(ActionNames.Create);
            }

            var detailsViewModel = viewModel2 as QuestionDetailsViewModel;
            if (detailsViewModel != null)
            {
                return RedirectToAction(ActionNames.Details, new { id = detailsViewModel.Question.ID });
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // GET: /Questions/Edit/5

        public ActionResult Edit(int id)
        {
            object viewModel;
            if (TempData.ContainsKey(TempDataKeys.ViewModel))
            {
                viewModel = TempData[TempDataKeys.ViewModel];
            }
            else
            {
                QuestionEditPresenter presenter = CreateEditPresenter();
                viewModel = presenter.Edit(id);
            }

            var editViewModel = viewModel as QuestionEditViewModel;
            if (editViewModel != null)
            {
                foreach (ValidationMessage validationMessage in editViewModel.ValidationMessages)
                {
                    ModelState.AddModelError(validationMessage.PropertyKey, validationMessage.Text);
                }

                return View(editViewModel);
            }

            var notFoundViewModel = viewModel as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // POST: /Questions/Edit/5

        /// <summary> Post edit. Saves the question. </summary>
        [HttpPost]
        public ActionResult Edit(QuestionEditViewModel viewModel)
        {
            QuestionEditPresenter presenter = CreateEditPresenter();
            object viewModel2 = presenter.Save(viewModel);

            var editViewModel = viewModel2 as QuestionEditViewModel;
            if (editViewModel != null)
            {
                TempData[TempDataKeys.ViewModel] = editViewModel;
                return RedirectToAction(ActionNames.Edit, new { id = editViewModel.Question.ID });
            }

            var detailsViewModel = viewModel2 as QuestionDetailsViewModel;
            if (detailsViewModel != null)
            {
                return RedirectToAction(ActionNames.Details, new { id = detailsViewModel.Question.ID });   
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // GET: /Questions/Delete/5

        /// <summary> Asks for confirmation that the question can be deleted. </summary>
        public ActionResult Delete(int id)
        {
            QuestionDeletePresenter presenter = CreateDeletePresenter();
            object viewModel = presenter.Show(id);

            var confirmDeleteViewModel = viewModel as QuestionConfirmDeleteViewModel;
            if (confirmDeleteViewModel != null)
            {
                return View(ViewNames.Delete, confirmDeleteViewModel);
            }

            var notFoundViewModel = viewModel as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // POST: /Questions/Delete/5

        /// <summary>
        /// With this action the user confirms that the question can be deleted.
        /// </summary>
        /// <param name="viewModel">
        /// Do nothing with this view model. 
        /// It is only provided to give the HTTP get and post actions different method signatures.
        /// </param>
        [HttpPost]
        public ActionResult Delete(QuestionConfirmDeleteViewModel viewModel, int id)
        {
            QuestionDeleteConfirmedPresenter presenter = CreateDeleteConfirmedPresenter();
            object viewModel2 = presenter.Show(id);

            var deleteConfirmedViewModel = viewModel2 as QuestionDeleteConfirmedViewModel;
            if (deleteConfirmedViewModel != null)
            {
                return View(ViewNames.Deleted, deleteConfirmedViewModel);
            }

            var notFoundViewModel = viewModel2 as QuestionDeleteConfirmedViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel2);
        }

        // POST: /Questions/AddLink

        [HttpPost]
        public ActionResult AddLink(QuestionEditViewModel viewModel)
        {
            QuestionEditPresenter presenter = CreateEditPresenter();
            QuestionEditViewModel viewModel2 = presenter.AddLink(viewModel);
            TempData[TempDataKeys.ViewModel] = viewModel2;
            if (viewModel.IsNew)
            {
                return RedirectToAction(ActionNames.Create);
            }
            else
            {
                return RedirectToAction(ActionNames.Edit, new { id = viewModel.Question.ID });
            }
        }

        // POST: /Questions/RemoveLink?temporaryID=12345678-90AB-CDEF

        [HttpPost]
        public ActionResult RemoveLink(QuestionEditViewModel viewModel, Guid temporaryID)
        {
            QuestionEditPresenter presenter = CreateEditPresenter();
            QuestionEditViewModel viewModel2 = presenter.RemoveLink(viewModel, temporaryID);
            TempData[TempDataKeys.ViewModel] = viewModel2;
            if (viewModel.IsNew)
            {
                return RedirectToAction(ActionNames.Create);
            }
            else
            {
                return RedirectToAction(ActionNames.Edit, new { id = viewModel.Question.ID });
            }
        }

        // POST: /Questions/AddCategory

        [HttpPost]
        public ActionResult AddCategory(QuestionEditViewModel viewModel)
        {
            QuestionEditPresenter presenter = CreateEditPresenter();
            QuestionEditViewModel viewModel2 = presenter.AddCategory(viewModel);
            TempData[TempDataKeys.ViewModel] = viewModel2;
            if (viewModel.IsNew)
            {
                return RedirectToAction(ActionNames.Create);
            }
            else
            {
                return RedirectToAction(ActionNames.Edit, new { id = viewModel.Question.ID });
            }
        }

        // POST: /Questions/RemoveCategory?temporaryID=12345678-90AB-CDEF

        [HttpPost]
        public ActionResult RemoveCategory(QuestionEditViewModel viewModel, Guid temporaryID)
        {
            QuestionEditPresenter presenter = CreateEditPresenter();
            QuestionEditViewModel viewModel2 = presenter.RemoveCategory(viewModel, temporaryID);
            TempData[TempDataKeys.ViewModel] = viewModel2;
            if (viewModel.IsNew)
            {
                return RedirectToAction(ActionNames.Create);
            }
            else
            {
                return RedirectToAction(ActionNames.Edit, new { id = viewModel.Question.ID });
            }
        }

        // GET: /Questions/Random
        // GET: /Questions/Random?c=1&c=2

        public ViewResult Random(int[] c)
        {
            RandomQuestionPresenter presenter = CreateRandomQuestionPresenter();
            
            object viewModel = presenter.Show(c);

            var randomQuestionViewModel = viewModel as RandomQuestionViewModel;
            if (randomQuestionViewModel != null)
            {
                return View(randomQuestionViewModel);
            }

            var notFoundViewModel = viewModel as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        // POST: /Questions/ShowAnswer/5

        [HttpPost]
        public ViewResult ShowAnswer(RandomQuestionViewModel viewModel)
        {
            string authenticatedUserName = TryGetAuthenticatedUserName();

            RandomQuestionPresenter presenter = CreateRandomQuestionPresenter();
            object viewModel2 = presenter.ShowAnswer(viewModel, authenticatedUserName);

            var randomQuestionViewModel = viewModel2 as RandomQuestionViewModel;
            if (randomQuestionViewModel != null)
            {
                return View(ViewNames.Random, randomQuestionViewModel);
            }

            var notFoundViewModel = viewModel2 as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel2);
        }

        // POST: /Questions/HideAnswer/5

        [HttpPost]
        public ViewResult HideAnswer(RandomQuestionViewModel viewModel)
        {
            string authenticatedUserName = TryGetAuthenticatedUserName();

            RandomQuestionPresenter presenter = CreateRandomQuestionPresenter();
            object viewModel2 = presenter.HideAnswer(viewModel, authenticatedUserName);

            var randomQuestionViewModel = viewModel2 as RandomQuestionViewModel;
            if (randomQuestionViewModel != null)
            {
                return View(ViewNames.Random, randomQuestionViewModel);
            }

            var notFoundViewModel = viewModel2 as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            throw new UnexpectedViewModelTypeException(viewModel2);
        }

        // POST: /Question/Flag/5

        [HttpPost]
        public ViewResult Flag(RandomQuestionViewModel viewModel)
        {
            string authenticatedUserName = TryGetAuthenticatedUserName();

            RandomQuestionPresenter presenter = CreateRandomQuestionPresenter();
            object viewModel2 = presenter.Flag(viewModel, authenticatedUserName);

            var randomQuestionViewModel = viewModel2 as RandomQuestionViewModel;
            if (randomQuestionViewModel != null)
            {
                return View(ViewNames.Random, randomQuestionViewModel);
            }

            var notFoundViewModel = viewModel2 as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            var notAuthenticatedViewModel = viewModel2 as NotAuthenticatedViewModel;
            if (notAuthenticatedViewModel != null)
            {
                return View(ViewNames.NotAuthenticated);
            }

            throw new UnexpectedViewModelTypeException(viewModel2);
        }

        // POST: /Question/Unflag/5

        [HttpPost]
        public ViewResult Unflag(RandomQuestionViewModel viewModel)
        {
            string authenticatedUserName = TryGetAuthenticatedUserName();

            RandomQuestionPresenter presenter = CreateRandomQuestionPresenter();
            object viewModel2 = presenter.Unflag(viewModel, authenticatedUserName);


            var randomQuestionViewModel = viewModel2 as RandomQuestionViewModel;
            if (randomQuestionViewModel != null)
            {
                return View(ViewNames.Random, randomQuestionViewModel);
            }

            var notFoundViewModel = viewModel2 as QuestionNotFoundViewModel;
            if (notFoundViewModel != null)
            {
                return View(ViewNames.NotFound, notFoundViewModel);
            }

            var notAuthenticatedViewModel = viewModel2 as NotAuthenticatedViewModel;
            if (notAuthenticatedViewModel != null)
            {
                return View(ViewNames.NotAuthenticated);
            }

            throw new UnexpectedViewModelTypeException(viewModel2);
        }

        // Helpers

        private RandomQuestionPresenter CreateRandomQuestionPresenter()
        {
            IContext context = ContextHelper.CreateContextFromConfiguration();
            IQuestionRepository questionRepository = RepositoryFactory.CreateQuestionRepository(context);
            ICategoryRepository categoryRepository = RepositoryFactory.CreateCategoryRepository(context);
            IQuestionFlagRepository questionFlagRepository = RepositoryFactory.CreateQuestionFlagRepository(context);
            IFlagStatusRepository flagStatusRepository = RepositoryFactory.CreateFlagStatusRepository(context);
            IUserRepository userRepository = RepositoryFactory.CreateUserRepository(context);
            return new RandomQuestionPresenter(questionRepository, categoryRepository, questionFlagRepository, flagStatusRepository, userRepository);
        }

        private QuestionEditPresenter CreateEditPresenter()
        {
            IContext context = ContextHelper.CreateContextFromConfiguration();
            IQuestionRepository questionRepository = RepositoryFactory.CreateQuestionRepository(context);
            IAnswerRepository answerRepository = RepositoryFactory.CreateAnswerRepository(context);
            ICategoryRepository categoryRepository = RepositoryFactory.CreateCategoryRepository(context);
            IQuestionCategoryRepository questionCategoryRepository = RepositoryFactory.CreateQuestionCategoryRepository(context);
            IQuestionLinkRepository questionLinkRepository = RepositoryFactory.CreateQuestionLinkRepository(context);
            IQuestionFlagRepository questionFlagRepository = RepositoryFactory.CreateQuestionFlagRepository(context);
            IFlagStatusRepository flagStatusRepository = RepositoryFactory.CreateFlagStatusRepository(context);
            ISourceRepository sourceRepository = RepositoryFactory.CreateSourceRepository(context);
            IQuestionTypeRepository questionTypeRepository = RepositoryFactory.CreateQuestionTypeRepository(context);
            return new QuestionEditPresenter(questionRepository, answerRepository, categoryRepository, questionCategoryRepository, questionLinkRepository, questionFlagRepository, flagStatusRepository, sourceRepository, questionTypeRepository);
        }

        private QuestionDetailsPresenter CreateDetailPresenter()
        {
            IContext context = ContextHelper.CreateContextFromConfiguration();
            IQuestionRepository questionRepository = RepositoryFactory.CreateQuestionRepository(context);
            IAnswerRepository answerRepository = RepositoryFactory.CreateAnswerRepository(context);
            ICategoryRepository categoryRepository = RepositoryFactory.CreateCategoryRepository(context);
            IQuestionCategoryRepository questionCategoryRepository = RepositoryFactory.CreateQuestionCategoryRepository(context);
            IQuestionLinkRepository questionLinkRepository = RepositoryFactory.CreateQuestionLinkRepository(context);
            IQuestionFlagRepository questionFlagRepository = RepositoryFactory.CreateQuestionFlagRepository(context);
            IFlagStatusRepository flagStatusRepository = RepositoryFactory.CreateFlagStatusRepository(context);
            ISourceRepository sourceRepository = RepositoryFactory.CreateSourceRepository(context);
            IQuestionTypeRepository questionTypeRepository = RepositoryFactory.CreateQuestionTypeRepository(context);
            return new QuestionDetailsPresenter(questionRepository, answerRepository, categoryRepository, questionCategoryRepository, questionLinkRepository, questionFlagRepository, flagStatusRepository, sourceRepository, questionTypeRepository);
        }

        private QuestionDeletePresenter CreateDeletePresenter()
        {
            IContext context = ContextHelper.CreateContextFromConfiguration();
            IQuestionRepository questionRepository = RepositoryFactory.CreateQuestionRepository(context);
            IAnswerRepository answerRepository = RepositoryFactory.CreateAnswerRepository(context);
            ICategoryRepository categoryRepository = RepositoryFactory.CreateCategoryRepository(context);
            IQuestionCategoryRepository questionCategoryRepository = RepositoryFactory.CreateQuestionCategoryRepository(context);
            IQuestionLinkRepository questionLinkRepository = RepositoryFactory.CreateQuestionLinkRepository(context);
            IQuestionFlagRepository questionFlagRepository = RepositoryFactory.CreateQuestionFlagRepository(context);
            IFlagStatusRepository flagStatusRepository = RepositoryFactory.CreateFlagStatusRepository(context);
            ISourceRepository sourceRepository = RepositoryFactory.CreateSourceRepository(context);
            IQuestionTypeRepository questionTypeRepository = RepositoryFactory.CreateQuestionTypeRepository(context);
            return new QuestionDeletePresenter(questionRepository, answerRepository, categoryRepository, questionCategoryRepository, questionLinkRepository, questionFlagRepository, flagStatusRepository, sourceRepository, questionTypeRepository);
        }

        private QuestionDeleteConfirmedPresenter CreateDeleteConfirmedPresenter()
        {
            IContext context = ContextHelper.CreateContextFromConfiguration();
            IQuestionRepository questionRepository = RepositoryFactory.CreateQuestionRepository(context);
            IAnswerRepository answerRepository = RepositoryFactory.CreateAnswerRepository(context);
            ICategoryRepository categoryRepository = RepositoryFactory.CreateCategoryRepository(context);
            IQuestionCategoryRepository questionCategoryRepository = RepositoryFactory.CreateQuestionCategoryRepository(context);
            IQuestionLinkRepository questionLinkRepository = RepositoryFactory.CreateQuestionLinkRepository(context);
            IQuestionFlagRepository questionFlagRepository = RepositoryFactory.CreateQuestionFlagRepository(context);
            IFlagStatusRepository flagStatusRepository = RepositoryFactory.CreateFlagStatusRepository(context);
            ISourceRepository sourceRepository = RepositoryFactory.CreateSourceRepository(context);
            IQuestionTypeRepository questionTypeRepository = RepositoryFactory.CreateQuestionTypeRepository(context);
            return new QuestionDeleteConfirmedPresenter(questionRepository, answerRepository, categoryRepository, questionCategoryRepository, questionLinkRepository, questionFlagRepository, flagStatusRepository, sourceRepository, questionTypeRepository);
        }

        private QuestionListPresenter CreateListPresenter()
        {
            IContext context = ContextHelper.CreateContextFromConfiguration();
            IQuestionRepository questionRepository = RepositoryFactory.CreateQuestionRepository(context);
            IAnswerRepository answerRepository = RepositoryFactory.CreateAnswerRepository(context);
            ICategoryRepository categoryRepository = RepositoryFactory.CreateCategoryRepository(context);
            IQuestionCategoryRepository questionCategoryRepository = RepositoryFactory.CreateQuestionCategoryRepository(context);
            IQuestionLinkRepository questionLinkRepository = RepositoryFactory.CreateQuestionLinkRepository(context);
            IQuestionFlagRepository questionFlagRepository = RepositoryFactory.CreateQuestionFlagRepository(context);
            IFlagStatusRepository flagStatusRepository = RepositoryFactory.CreateFlagStatusRepository(context);
            ISourceRepository sourceRepository = RepositoryFactory.CreateSourceRepository(context);
            IQuestionTypeRepository questionTypeRepository = RepositoryFactory.CreateQuestionTypeRepository(context);
            return new QuestionListPresenter(questionRepository, answerRepository, categoryRepository, questionCategoryRepository, questionLinkRepository, questionFlagRepository, flagStatusRepository, sourceRepository, questionTypeRepository);
        }
    }
}
