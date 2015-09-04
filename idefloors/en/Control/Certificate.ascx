<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Certificate.ascx.cs" Inherits="Control_Certificate" %>
<%@ Import Namespace="System.Data" %>

<div id="wrapcertificate">
    <div class="certificate">
        <div class="certificatetitle">Giới thiệu</div>
        <div style='clear: both;'></div>
        <div>
            <span style="line-height: 1.538em;">Sàn nhựa&nbsp;</span><br>
            <span style="line-height: 1.538em;">Kích thước đa dạng ...</span><br>
            <span style="line-height: 1.538em;">Size : 6″ × 36″(152.4mm × 914.4mm:24pcs, 3.34㎡/box)
           8″ × 48″(203.2mm × 1.219.2mm:13pcs, 3.22㎡/box)
           184mm × 950mm(19pcs, 3.32㎡/box)</span>
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

