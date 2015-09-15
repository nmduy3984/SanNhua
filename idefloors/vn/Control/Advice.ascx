﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Advice.ascx.cs" Inherits="Control_Advice" %>
<%@ Import Namespace="System.Data" %>
<div id="wrapadvice">
    <div class="advice">
        <div class="title">Hướng dẫn lắp đặt</div>
        <div style='clear: both;'></div>
        <% foreach (DataRow row in pdf.Rows)
           {
  
        %>
                <div class="content"><%=row["Title"]%></div>
                <div class="download">
                    <div style="background: rgb(238, 238, 238) url(&quot;../../Images/pdf_icon.gif&quot;) no-repeat scroll 0px 0px;" class="thumb"></div>
                    <%=row["Description"]%> <a href="../../Images/PDF/Advice/<%=row["FileName"]%>" target="_blank">(download PDF)</a>
                </div>
        <%} %>

        <% foreach (DataRow row in video.Rows)
           {
  
        %>
                <div class="content"><%=row["Title"]%></div>
                <div>
                    <a href="<%=row["LinkVideo"]%>" target="_blank">
                        <img alt="idefloors.vn" src="../../Images/Advice/<%=row["ImageURL"]%>" width="400px" height="300px" /></a>
                </div>
        <%} %>
        <br />
        <div class="content">Vui lòng liên hệ chúng tôi để biết thêm thông tin:</div>
        <div>Phone: <%=thamso.Rows[0]["Phone"].ToString()%></div>
        <div class="download">
        <% 
            string[] arr = thamso.Rows[0]["Email"].ToString().Split(';');
            for( int i=0 ; i<arr.Length; i++){
                %>
               Email: <a href="mailto:<%= arr[i] %>"><span><%= arr[i] %></span></a> <br />
        <%
            }
            %>

        </div>
    </div>
</div>


