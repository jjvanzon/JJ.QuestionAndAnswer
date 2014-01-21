﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<JJ.Apps.QuestionAndAnswer.ViewModels.QuestionDetailViewModel>" %>
<%@ Import Namespace="JJ.Apps.QuestionAndAnswer.Resources" %>
<%@ Import Namespace="JJ.Apps.QuestionAndAnswer.Mvc.Controllers.Helpers" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="ScriptContent" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Titles.QuestionDetails %></h2>

    <table>
        <colgroup>
            <col style="padding-right: 50px" />
            <col />
        </colgroup>
        <tr>
            <th><%: Labels.ID %></th>
            <td><%: Html.DisplayFor(x => x.Question.ID) %></td>
        </tr>
        <tr>
            <th><%: Labels.IsActive %></th>
            <td><%: Model.Question.IsActive ? Titles.Yes : Titles.No %></td>
        </tr>
        <tr>
            <th><%: Labels.Question %></th>
            <td><%: Html.DisplayFor(x => x.Question.Text) %></td>
        </tr>
        <tr>
            <th><%: Labels.Answer %></th>
            <td><%: Html.DisplayFor(x => x.Question.Answer) %></td>
        </tr>
        <tr>
            <th><%: Labels.Categories %></th>
            <td>

                <% foreach (var category in Model.Question.Categories.Select(x => x.Category)) { %>

                    <div>
                        <%: category.ID %> - 
                        <%: String.Join(@" \ ", category.NameParts) %>
                    </div>

                <% } %>

            </td>
        </tr>
        <tr>
            <th><%: Labels.Links %></th>
            <td>
                
                <% foreach (var link in Model.Question.Links) { %>

                    <p>
                        <%: Labels.Description %>
                        <%: link.Description %>
                        <br />

                        <%: Labels.Url %>
                        <%: link.Url %>
                    </p>

                <% } %>

            </td>
        </tr>
    </table>

    <fieldset>
        <legend><%: Titles.ContentFlags %></legend>

        <table>
            <tr>
                <th><%: Labels.HasActiveFlags %></th>
                <td><%: Model.Question.IsFlagged ? Titles.Yes : Titles.No %></td>
            </tr>

            <% foreach (var flag in Model.Question.Flags) { %>

                <tr>
                    <th><%: flag.FlaggedBy%></th>
                    <td>
                        <div>
                            <%: Labels.DateAndTime %>
                            <%: flag.DateAndTime.ToString() %>
                        </div>
                        <div>
                            <%: Labels.Status %>
                            <%: flag.Status.Description %>
                        </div>
                        <div>
                            <%: Labels.Comment %>
                            <%: flag.Comment %>
                        </div>
                        <div>
                            <%: Labels.LastModifiedBy %>
                            <%: flag.LastModifiedBy %>
                        </div>
                    </td>
                </tr>

            <% } %>
        </table>

    </fieldset>

    <p>
        <%: Html.ActionLink(Titles.Edit, ActionNames.Edit, new { id = Model.Question.ID }) %> |
        <%: Html.ActionLink(Titles.BackToList, ActionNames.Index) %>
    </p>

</asp:Content>
