<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Certificate.ascx.cs" Inherits="Control_Certificate" %>
<%@ Import Namespace="System.Data" %>

<div id="wrapcertificate">
    <div class="certificate">
        <div class="certificatetitle">INTRODUCTION</div>
        <div style='clear: both;'></div>
        <div>
            <%  string gioiThieu = "";
                if (thamso.Rows.Count > 0)
                    gioiThieu = thamso.Rows[0]["DescriptionEN"].ToString(); %>
            <%= gioiThieu %>
            <br />
            <br />
        </div>
    </div>
    <div class="certificate">
        <div class="certificatetitle">Chứng nhận chất lượng</div>
        <div style='clear: both;'></div>
        <div class="fixed_img_col3">
            <% if (certificate.Rows.Count > 0)
               {
                   int count = 1;
                   foreach (DataRow row in certificate.Rows)
                   {
                       if (count > 3) count = 1;
                       if (count == 1)
                       {
            %>
            <ul>
                <%}
                   if (count <= 3)
                   {
                          
                %>
                <li>
                    <a href="../../Images/PDF/Certificate/<%= row["FileName"].ToString()%>" target="_blank">
                        <span style="background: url(../../Images/Certificate/<%= row["ImgUrl"].ToString()%>) no-repeat; background-color: #eee;" class="thumb"></span>
                        <strong><%= row["TitleEN"].ToString()%></strong>
                    </a>
                </li>
                <%}
                   if (count == 3)
                   { %>
            </ul>
            <%}
                       count++;
               }
              }
               else
               {
            %>
            <div>Updating</div>
            <%
              }
            %>
        </div>
    </div>
</div>

