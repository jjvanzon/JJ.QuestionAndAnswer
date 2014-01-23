﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<JJ.Apps.QuestionAndAnswer.ViewModels.QuestionEditViewModel>" %>
<%@ Import Namespace="JJ.Apps.QuestionAndAnswer.Resources" %>
<%@ Import Namespace="JJ.Apps.QuestionAndAnswer.Mvc.Views" %>
<%@ Import Namespace="JJ.Apps.QuestionAndAnswer.Mvc.Controllers.Helpers" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Titles.EditQuestion %>
</asp:Content>

<asp:Content ID="ScriptContent" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <% using (Html.BeginForm()) { %>

        <h2><%: Titles.EditQuestion %></h2>

        <% Html.RenderPartial(ViewNames._Editor); %>

        <%-- TODO: These actions must be reflected by the Presenter code. --%>

        <p>
            <input type="submit" value="<%: Titles.Save %>" /> |
            <%: Html.ActionLink(Titles.Cancel, ActionNames.Details, new { id = Model.Question.ID }) %> |
            <%: Html.ActionLink(Titles.Delete, ActionNames.Delete, new { id = Model.Question.ID }) %> |
            <%: Html.ActionLink(Titles.BackToList, ActionNames.Index) %>
        </p>

    <% } %>

</asp:Content>
