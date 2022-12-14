<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="ViewPage<QuestionDetailsViewModel>" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Titles.QuestionDetails %>
</asp:Content>

<asp:Content ID="ScriptContent" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
    <div id="loginDiv"> <% Html.RenderPartial(ViewNames._Login, Model.Login); %> </div>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Titles.QuestionDetails %></h2>

    <table>
        <colgroup>
            <col style="padding-right: 50px" />
            <col />
        </colgroup>
        <tr>
            <th><%: PropertyDisplayNames.ID %></th>
            <td><%: Model.Question.ID %></td>
        </tr>

        <tr>
            <th><%: PropertyDisplayNames.Question %></th>
            <td><%: Model.Question.Text %></td>
        </tr>
        <tr>
            <th><%: PropertyDisplayNames.Answer %></th>
            <td><%: Model.Question.Answer %></td>
        </tr>

        <tr>
            <th><%: PropertyDisplayNames.IsActive %></th>
            <td><%: Model.Question.IsActive ? CommonResourceFormatter.Yes : CommonResourceFormatter.No %></td>
        </tr>
        <tr>
            <th><%: PropertyDisplayNames.Source %></th>
            <td>
                <% if (!string.IsNullOrEmpty(Model.Question.Source.Url)) { %>

                    <a href="<%: Model.Question.Source.Url %>" target="_blank">

                <% } %>

                <%: Model.Question.Source.Description %>

                <% if (!string.IsNullOrEmpty(Model.Question.Source.Url)) { %>

                    </a>

                <% } %>
            </td>
        </tr>
        <tr>
            <th><%: Titles.Type %></th>
            <td><%: Model.Question.Type.Name %></td>
        </tr>

        <tr>
            <th><%: PropertyDisplayNames.Categories %></th>
            <td>

                <% foreach (var category in Model.Question.Categories.Select(x => x.Category)) { %>

                    <div>
                        <%: category.ID %> - 
                        <%: string.Join(@" \ ", category.NameParts) %>
                    </div>

                <% } %>

                
                <% if (Model.Question.Categories.Count == 0) { %>

                    <%: CommonResourceFormatter.None %>

                <% } %>

            </td>
        </tr>
        <tr>
            <th><%: Titles.Links %></th>
            <td>
                
                <% foreach (var link in Model.Question.Links) { %>

                    <%: link.Description %>: <a href="<%: link.Url %>" target="_blank"> <%: link.Url %> </a>
                    <br />

                <% } %>

                <% if (Model.Question.Links.Count == 0) { %>

                    <%: CommonResourceFormatter.None %>

                <% } %>

            </td>
        </tr>
        <tr>
            <th><%: PropertyDisplayNames.LastModifiedByUser %></th>
            <td><%: Model.Question.LastModifiedBy %> </td>
        </tr>
        <tr>
            <th><%: PropertyDisplayNames.IsManual %></th>
            <td>
                <%: Model.Question.IsManual ? CommonResourceFormatter.Yes : CommonResourceFormatter.No %>

                <% if (Model.Question.IsManual) { %>

                    <br />
                    <%: Messages.ExplanationOfIsManualWithParenthesis %>

                <% } %>
            </td>
        </tr>
    </table>

    <fieldset>
        <legend><%: Titles.ContentFlags %></legend>

        <table>
            <tr>
                <th><%: Titles.HasActiveFlags %></th>
                <td><%: Model.Question.IsFlagged ? CommonResourceFormatter.Yes : CommonResourceFormatter.No %></td>
            </tr>

            <% foreach (var flag in Model.Question.Flags) { %>

                <tr>
                    <th><%: flag.FlaggedBy%></th>
                    <td>
                        <div>
                            <%: PropertyDisplayNames.DateTime %>
                            <%: flag.DateAndTime.ToString() %>
                        </div>
                        <div>
                            <%: PropertyDisplayNames.FlagStatus %>
                            <%: flag.Status.Name %>
                        </div>
                        <div>
                            <%: PropertyDisplayNames.Comment %>
                            <%: flag.Comment %>
                        </div>
                        <div>
                            <%: PropertyDisplayNames.LastModifiedByUser %>
                            <%: flag.LastModifiedBy %>
                        </div>
                    </td>
                </tr>

            <% } %>
        </table>

    </fieldset>

    <p>
        <%: Html.ActionLink(CommonResourceFormatter.Edit, ActionNames.Edit, new { id = Model.Question.ID }) %> |
        <%: Html.ActionLink(CommonResourceFormatter.New, ActionNames.Create) %> |
        <%: Html.ActionLink(CommonResourceFormatter.Delete, ActionNames.Delete, new { id = Model.Question.ID }) %> |
        <%: Html.ActionLink(Titles.BackToList, ActionNames.Index) %>
    </p>

</asp:Content>

