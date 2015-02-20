﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JJ.Framework.Reflection;
using JJ.Framework.Persistence;
using JJ.Framework.Presentation;
using JJ.Framework.Presentation.Mvc;
using JJ.Business.CanonicalModel;
using JJ.Persistence.QuestionAndAnswer;
using JJ.Persistence.QuestionAndAnswer.DefaultRepositories.Interfaces;
using JJ.Presentation.QuestionAndAnswer.ViewModels;
using JJ.Presentation.QuestionAndAnswer.ViewModels.Entities;
using JJ.Presentation.QuestionAndAnswer.ViewModels.Partials;
using JJ.Presentation.QuestionAndAnswer.Presenters;
using JJ.Presentation.QuestionAndAnswer.Mvc.Names;
using JJ.Presentation.QuestionAndAnswer.Mvc.Helpers;
using System.Threading;
using System.Collections.Specialized;
using JJ.Framework.Web;

namespace JJ.Presentation.QuestionAndAnswer.Mvc.Controllers
{
    public abstract class MasterController : Controller
    {
        private class Names
        {
            public Names(string controllerName, string actionName, string viewName)
            {
                ControllerName = controllerName;
                ActionName = actionName;
                ViewName = viewName;
            }

            public string ControllerName { get; private set; }
            public string ActionName { get; private set; }
            public string ViewName { get; private set; }
        }

        private const string DEFAULT_CULTURE_NAME = "en-US";

        protected SessionWrapper SessionWrapper { get; private set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            SessionWrapper = new SessionWrapper(Session);

            CultureWebHelper.SetThreadCultureByHttpHeaderOrCookie(ControllerContext.HttpContext, DEFAULT_CULTURE_NAME);

            base.OnActionExecuting(filterContext);
        }

        // Login

        protected string TryGetAuthenticatedUserName()
        {
            return SessionWrapper.AuthenticatedUserName;
        }

        public void SetAuthenticatedUserName(string authenticatedUserName)
        {
            SessionWrapper.AuthenticatedUserName = authenticatedUserName;
        }

        // GetActionResult

        protected ActionResult GetActionResult(string sourceActionName, object viewModel)
        {
            if (viewModel == null) throw new NullException(() => viewModel);

            ActionResult actionResult;

            actionResult = TryGetActionResultFromDictionary(sourceActionName, viewModel);
            if (actionResult != null)
            {
                return actionResult;
            }

            actionResult = TryGetQuestionIndexActionResult(sourceActionName, viewModel);
            if (actionResult != null)
            {
                return actionResult;
            }

            actionResult = TryGetQuestionDetailsActionResult(sourceActionName, viewModel);
            if (actionResult != null)
            {
                return actionResult;
            }

            actionResult = TryGetQuestionEditActionResult(sourceActionName, viewModel);
            if (actionResult != null)
            {
                return actionResult;
            }

            actionResult = TryGetQuestionConfirmDeleteActionResult(sourceActionName, viewModel);
            if (actionResult != null)
            {
                return actionResult;
            }

            throw new UnexpectedViewModelTypeException(viewModel);
        }

        private static IDictionary<Type, Names> _dictionary = new Dictionary<Type, Names>()
        {
            { typeof(CategorySelectorViewModel), new Names(ControllerNames.CategorySelector, ActionNames.Index, ViewNames.Index) },
            { typeof(LoginViewModel), new Names(ControllerNames.Login, ActionNames.Index, ViewNames.Index) },
            { typeof(QuestionDeleteConfirmedViewModel), new Names(ControllerNames.Questions, null, ViewNames.Deleted) },
            { typeof(QuestionNotFoundViewModel), new Names(ControllerNames.Questions, null, ViewNames.NotFound) },
            { typeof(RandomQuestionViewModel), new Names(ControllerNames.Questions, ActionNames.Random, ViewNames.Random) },
            { typeof(NotAuthorizedViewModel), new Names(null, null, ViewNames.NotAuthorized) }
        };

        private ActionResult TryGetActionResultFromDictionary(string sourceActionName, object viewModel)
        {
            Names names;
            if (_dictionary.TryGetValue(viewModel.GetType(), out names))
            {
                bool hasActionName = !String.IsNullOrEmpty(names.ActionName);
                if (!hasActionName)
                {
                    return View(names.ViewName, viewModel);
                }

                bool isSameControllerAndAction = String.Equals(names.ControllerName, GetControllerName()) &&
                                                 String.Equals(names.ActionName, sourceActionName);
                if (isSameControllerAndAction)
                {
                    return View(names.ViewName, viewModel);
                }
                else
                {
                    TempData[TempDataKeys.ViewModel] = viewModel;
                    return RedirectToAction(names.ActionName, names.ControllerName);
                }
            }

            return null;
        }

        private ActionResult TryGetQuestionEditActionResult(string sourceActionName, object viewModel)
        {
            var viewModel2 = viewModel as QuestionEditViewModel;
            if (viewModel2 != null)
            {
                if (viewModel2.IsNew)
                {
                    bool isSameControllerAndAction = String.Equals(GetControllerName(), ControllerNames.Questions) &&
                                                     String.Equals(sourceActionName, ActionNames.Create);
                    if (isSameControllerAndAction)
                    {
                        ModelState.ClearModelErrors();
                        foreach (ValidationMessage validationMessage in viewModel2.ValidationMessages)
                        {
                            ModelState.AddModelError(validationMessage.PropertyKey, validationMessage.Text);
                        }

                        return View(ViewNames.Edit, viewModel);
                    }
                    else
                    {
                        TempData[TempDataKeys.ViewModel] = viewModel;
                        return RedirectToAction(ActionNames.Create, ControllerNames.Questions);
                    }
                }
                else
                {
                    bool isSameControllerAndAction = String.Equals(GetControllerName(), ControllerNames.Questions) &&
                                                     String.Equals(sourceActionName, ActionNames.Edit);
                    if (isSameControllerAndAction)
                    {
                        ModelState.ClearModelErrors();
                        foreach (ValidationMessage validationMessage in viewModel2.ValidationMessages)
                        {
                            ModelState.AddModelError(validationMessage.PropertyKey, validationMessage.Text);
                        }

                        return View(ViewNames.Edit, viewModel);
                    }
                    else
                    {
                        TempData[TempDataKeys.ViewModel] = viewModel;
                        return RedirectToAction(ActionNames.Edit, ControllerNames.Questions, new { id = viewModel2.Question.ID });
                    }
                }
            }

            return null;
        }

        private ActionResult TryGetQuestionIndexActionResult(string sourceActionName, object viewModel)
        {
            var viewModel2 = viewModel as QuestionListViewModel;
            if (viewModel2 != null)
            {
                bool isSameControllerAndAction = String.Equals(GetControllerName(), ControllerNames.Questions) &&
                                                 String.Equals(sourceActionName, ActionNames.Index);
                if (isSameControllerAndAction)
                {
                    return View(viewModel);
                }
                else
                {
                    TempData[TempDataKeys.ViewModel] = viewModel;
                    return RedirectToAction(ActionNames.Index, new { page = viewModel2.Pager.PageNumber });
                }
            }

            return null;
        }

        private ActionResult TryGetQuestionDetailsActionResult(string sourceActionName, object viewModel)
        {
            var viewModel2 = viewModel as QuestionDetailsViewModel;
            if (viewModel2 != null)
            {
                bool isSameControllerAndAction = String.Equals(GetControllerName(), ControllerNames.Questions) &&
                                                 String.Equals(sourceActionName, ActionNames.Details);
                if (isSameControllerAndAction)
                {
                    return View(viewModel);
                }
                else
                {
                    TempData[TempDataKeys.ViewModel] = viewModel;
                    return RedirectToAction(ActionNames.Details, new { id = viewModel2.Question.ID });
                }
            }

            return null;
        }

        private ActionResult TryGetQuestionConfirmDeleteActionResult(string sourceActionName, object viewModel)
        {
            var viewModel2 = viewModel as QuestionConfirmDeleteViewModel;
            if (viewModel2 != null)
            {
                bool isSameControllerAndAction = String.Equals(GetControllerName(), ControllerNames.Questions) &&
                                                 String.Equals(sourceActionName, ActionNames.Delete);
                if (isSameControllerAndAction)
                {
                    return View(viewModel);
                }
                else
                {
                    TempData[TempDataKeys.ViewModel] = viewModel;
                    return RedirectToAction(ActionNames.Delete, ControllerNames.Questions, new { id = viewModel2.ID });
                }
            }

            return null;
        }

        private string GetControllerName()
        {
            string controllerName = (string)ControllerContext.RequestContext.RouteData.Values["controller"];
            return controllerName;
        }
    }
}
