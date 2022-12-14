<%@ Control Language="C#" Inherits="ViewUserControl<PagerViewModel>" %>

<table>
    <tr>
        <% if (Model.CanGoToFirstPage) { %>
            <td><%: Html.ActionLinkWithParams("<<", ActionNames.Index, ActionParameterNames.page, 1) %></td>
        <% } %>

        <% if (Model.CanGoToPreviousPage) { %>
            <td><%: Html.ActionLinkWithParams("<", ActionNames.Index, ActionParameterNames.page, Model.PageNumber - 1)%></td>
        <% } %>

        <% if (Model.MustShowLeftEllipsis) { %>
            <td>...</td>
        <% } %>
        
        <% foreach (var pageNumber in Model.VisiblePageNumbers) { %>

            <% if (pageNumber == Model.PageNumber) { %>

                <td><strong><%: pageNumber %></strong></td>

            <% } else { %>

                <td><%: Html.ActionLinkWithParams(pageNumber.ToString(), ActionNames.Index, ActionParameterNames.page, pageNumber)%></td>    

            <% } %>

        <% } %>
        
        <% if (Model.MustShowRightEllipsis) { %>
            <td>...</td>
        <% } %>

        <% if (Model.CanGoToNextPage) { %>
            <td><%: Html.ActionLinkWithParams(">", ActionNames.Index, ActionParameterNames.page, Model.PageNumber + 1) %></td>
        <% } %>

        <% if (Model.CanGoToLastPage) { %>
            <td><%: Html.ActionLinkWithParams(">>", ActionNames.Index, ActionParameterNames.page, Model.PageCount)%></td>
        <% } %>
    </tr>
</table>