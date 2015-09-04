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
        <a href="NewsDetail.aspx?Id=<%=row["Id"] %>">
            <img  alt="idefloors.vn" u="image" class="img" src="../../Images/News/<%=row["ImageUrl"] %>" /></a>
    </div>
    <div class="content">
        <div class="title"><a href="NewsDetail.aspx?Id=<%=row["Id"] %>"><%=row["TitleEN"] %></a></div>
        <div class="desc"><%= System.Net.WebUtility.HtmlDecode(row["DescriptionEN"].ToString())%></div>
        <div class="seemore"><a href='NewsDetail.aspx?Id=<%=row["Id"] %>'>See more&nbsp;&#187;</a></div>
    </div>
    <div class="splitspace"></div>
    <%
      } %>

    <div class="page">
        <%=_Pagination%>
    </div>
</div>
