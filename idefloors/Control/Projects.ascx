<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Projects.ascx.cs" Inherits="Control_Projects" %>
 <%@ Import Namespace="System.Data" %>
<div class="wrapnews">
    <div>
        <h2>Dự Án</h2>
    </div>
    <br />
    <br />
    <%foreach (DataRow row in projects.Rows)
      {
    %>
    <div class="img_link">
        <a href="../Page/ProjectsDetail.aspx?Id=<%=row["Id"] %>">
            <img u="image" class="img" src="../Images/Projects/<%=row["ImageUrl"] %>" /></a>
    </div>
    <div class="content">
        <div class="title"><a href="../Page/ProjectsDetail.aspx?Id=<%=row["Id"] %>"><%=row["Title"] %></a></div>
        <div class="desc"><%=Server.HtmlDecode(row["Description"].ToString()) %></div>
        <div class="seemore"><a href='../Page/ProjectsDetail.aspx?Id=<%=row["Id"] %>'>Xem thêm&nbsp;&#187;</a></div>
    </div>
    <div class="splitspace"></div>
    <%
      } %>

    <div class="page">
        <%=_Pagination%>
    </div>
</div>