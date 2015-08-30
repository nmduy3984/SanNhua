﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductByCategory.ascx.cs" Inherits="Control_ProductByCatagory" %>
<%@ Import Namespace="System.Data" %>

<div class="c2">
    <p>
        <strong style="font-size: 20px; line-height: 1.538em; color: #6ab901;">Giới thiệu</strong>
    </p>
    <div style="text-align: justify;">
        <asp:Literal ID="ltrContent" runat="server" Text=""></asp:Literal>
    </div>
</div>

<%
    foreach (DataRow row0 in categoryByParentId.Rows)
    {
        foreach (DataRow row1 in categoryById.Rows)
        {
            DataTable productByCategory = new DataTable();
            productByCategory = DataAccess.GetDatatable("select * from Product  where Status=1 and CategoryID =" + row1["CategoryID"].ToString() + " order by CreatedDate desc");
%>
<div class="c2">
    <div class="t_c2"><a href="javascript:void();"><%= row0["Name"]%> - <%= row1["Name"]%></a></div>
    <div class="seemore"></div>
    <div style='clear: both;'></div>
    <% if ((bool)row1["ViewType"])
       { %>
    <div class="fixed_img_col2" id='Popup<%= row1["CategoryID"].ToString() %>'>
        <script type="text/javascript">
            $('#Popup<%= row1["CategoryID"].ToString() %>').magnificPopup({
                delegate: 'a',
                type: 'image',
                tLoading: 'Loading image #%curr%...',
                mainClass: 'mfp-img-mobile',
                gallery: {
                    enabled: true,
                    navigateByImgClick: true,
                    preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
                },
                image: {
                    tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                    titleSrc: function (item) {
                        var arr = item.el.attr('title').split('#idefloors.vn#');
                        return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0];
                    }
                }
            });

        </script>
        <%if (productByCategory.Rows.Count > 0)
          { %>
        <ul>
            <% 
              foreach (DataRow row2 in productByCategory.Rows)
              {
                  
            %>
            <li>
                <a title="<%=row2["Name"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../Images/ProductImages/<%=row2["ImageUrl"]%>">
                    <span class="thumb">
                        <img  alt="idefloors.vn"  src="../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                    </span>
                    <strong><%=row2["Name"]%><br /><%=row2["ProductID"]%></strong>
                </a>
            </li>
            <%
              }
            %>
        </ul>

        <%}
          else
          {
        %>
        <div>Đang cập nhật</div>
        <%   
          }
       }
       else
       { %>
        <div class="fixed_img_col4" id="Popup<%= row1["CategoryID"].ToString() %>">
            <%if (!row0["CategoryID"].ToString().Equals("3"))
              { %>
            <script type="text/javascript">
                $('#Popup<%= row1["CategoryID"].ToString() %>').magnificPopup({
                    delegate: 'a',
                    type: 'image',
                    tLoading: 'Loading image #%curr%...',
                    mainClass: 'mfp-img-mobile',
                    gallery: {
                        enabled: true,
                        navigateByImgClick: true,
                        preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
                    },
                    image: {
                        tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                        titleSrc: function (item) {
                            var arr = item.el.attr('title').split('#idefloors.vn#');
                            return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0];
                        }
                    }
                });

            </script>
            <%}
              if (productByCategory.Rows.Count > 0)
              {
                  int count = 1;
                  foreach (DataRow row2 in productByCategory.Rows)
                  {
                      if (count > 3) count = 1;
                      if (count == 1)
                      {
            %>
            <ul>
                <%}
                      if (count <= 3)
                      {
                          if (!row0["CategoryID"].ToString().Equals("3"))
                          {
                %>
                <li>
                    <a title="<%=row2["Name"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../Images/ProductImages/<%=row2["ImageUrl"]%>">
                        <span class="thumb">
                            <img  alt="idefloors.vn"  src="../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                        </span>
                        <strong><%=row2["Name"]%><br /><%=row2["ProductID"]%></strong>
                    </a>
                </li>
                <%}
                          else
                          {
                %>
                <li>
                    <a title="<%=row2["Name"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../Page/ProductDetail.aspx?Id=<%=row2["ProductID"]%>">
                        <span class="thumb">
                            <img  alt="idefloors.vn"  src="../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                        </span>
                        <strong><%=row2["Name"]%><br /><%=row2["ProductID"]%></strong>
                    </a>
                </li>
                <%  
                          }
                      }
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
            <div>Đang cập nhật</div>
            <%
              }
       } %>
        </div>
    </div>
    <%}
   }
    %>
