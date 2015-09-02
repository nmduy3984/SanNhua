<%@ Control Language="C#" AutoEventWireup="true" CodeFile="News.ascx.cs" Inherits="Control_News" %>
<%@ Import Namespace="System.Data" %>
<div class="wrapnews">
    <div>
        <h2>Tin tức</h2>
    </div>
    <br />
    <br />
    <%foreach (DataRow row in news.Rows)
      {
    %>
    <div class="img_link">
        <a href="../Page/NewsDetail.aspx?Id=<%=row["Id"] %>">
            <img  alt="idefloors.vn" u="image" class="img" src="../Images/News/<%=row["ImageUrl"] %>" /></a>
    </div>
    <div class="content">
        <div class="title"><a href="../Page/NewsDetail.aspx?Id=<%=row["Id"] %>"><%=row["Title"] %></a></div>
        <div class="desc"><%=row["Description"].ToString()%></div>
        <div class="seemore"><a href='../Page/NewsDetail.aspx?Id=<%=row["Id"] %>'>Xem thêm&nbsp;&#187;</a></div>
    </div>
    <div class="splitspace"></div>
    <%
      } %>

    <div class="page">
        <%=_Pagination%>
    </div>
</div>
