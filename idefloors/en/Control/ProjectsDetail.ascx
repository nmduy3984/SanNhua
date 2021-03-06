﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectsDetail.ascx.cs" Inherits="Control_ProjectsDetail" %>
<%@ Import Namespace="System.Data" %>
<div class="wrapnewsdetail">
    <div>
        <h2>Projects</h2>
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
    <%if (projectsOtherID.Rows.Count > 0){ %>
    <div>
        <h2>Related Project</h2>
    </div>
    <br />
    <div class="newsrelate">
        <ul>
            <%
                foreach (DataRow row in projectsOtherID.Rows)
              {
            %>
            <li><a href="ProjectsDetail.aspx?Id=<%=row["Id"] %>"><%=row["TitleEN"] %></a></li>
            <%} %>
        </ul>
    </div>
    <%} %>
</div>