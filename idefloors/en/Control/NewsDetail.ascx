<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsDetail.ascx.cs" Inherits="Control_NewsDetail" %>
<%@ Import Namespace="System.Data" %>
<div class="wrapnewsdetail">
    <div>
        <h2>WRITING</h2>
    </div>
    <br />
    <br />
    <div>
        <h2><asp:Label ID="lblTitle" runat="server"></asp:Label></h2>
    </div>
    <br />
    <br />
    <div style="text-align:justify;">
        <asp:Literal ID="ltrContent" runat="server"></asp:Literal>
    </div>
    <br />
    <%if (newsOtherID.Rows.Count > 0){ %>
    <div>
        <h2>Related Articles</h2>
    </div>
    <br />
    <div class="newsrelate">
        <ul>
            <%
              foreach (DataRow row in newsOtherID.Rows)
              {
            %>
            <li><a href="NewsDetail.aspx?Id=<%=row["Id"] %>"><%=row["TitleEN"] %></a></li>
            <%} %>
        </ul>
    </div>
    <%} %>
</div>
