<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SlideProjects.ascx.cs" Inherits="Control_Common_SlideProjects" %>
<%@ Import Namespace="System.Data" %>
<div id="SlideProjects" style="position: relative; top: 0px; left: 0px; width: 960px; height: 100px; overflow: hidden;">
    <!-- Loading Screen -->
    <div u="loading" style="position: absolute; top: 0px; left: 0px;">
        <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000; top: 0px; left: 0px; width: 100%; height: 100%;">
        </div>
        <div style="position: absolute; display: block; background: url(../../Images/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
        </div>
    </div>

    <!-- Slides Container -->
    <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 980px; height: 60px; overflow: hidden;">
        <% foreach (DataRow row in projectlogo.Rows)
           {
               string link = row["Link"].ToString().Trim() == "" ? "javascript:void();" : row["Link"].ToString();
        %>
        <div>
            <a href="<%= link%>" target="_blank">
                <img alt="idefloors.vn" u="image" alt="amazon" src="../../Images/ProjectLogo/<%= row["ImgUrl"].ToString()%>" /></a>
        </div>

        <%} %>
    </div>
</div>
