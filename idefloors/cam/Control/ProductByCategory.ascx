<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductByCategory.ascx.cs" Inherits="Control_ProductByCatagory" %>
<%@ Import Namespace="System.Data" %>

<div class="c2">
    <p>
        <strong style="font-size: 20px; line-height: 1.538em; color: #6ab901;">Giới thiệu</strong>
    </p>
    <div style="text-align: justify;">
        <asp:Literal ID="ltrContent" runat="server" Text=""></asp:Literal>
    </div>
</div>
<%if (Id != "2")
  { 
      foreach (DataRow row0 in categoryByParentId.Rows)
      {
          foreach (DataRow row1 in categoryById.Rows)
          {
              DataTable productByCategory = new DataTable();
              productByCategory = DataAccess.GetDatatable("select * from Product  where Status=1 and CategoryID =" + row1["CategoryID"].ToString() + " order by seq");
%>
                <div class="c2">
                <div class="t_c2"><a href="javascript:void();"><%= row0["NameCAM"]%> - <%= row1["NameCAM"]%></a></div>
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
                          {
                              int count = 1;
                              int dem = 0;
                              foreach (DataRow row2 in productByCategory.Rows)
                              {
                                  dem++;
                                  if (count > 2) count = 1;
                                  if (count == 1 )
                                  {%><ul><%}
                                   if (count <= 2)
                                   {
                       
                                       string name = row2["NameCAM"].ToString().Trim();
                                        %>
                                        <li>
                                            <a title="<%=row2["NameCAM"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                                <span class="thumb">
                                                    <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                                </span>
                                                <strong><% if (name != "")
                                                           { %><%=name%><br />
                                                    <% } %><%=row2["ProductID"]%></strong>
                                            </a>
                                        </li>
                                        <%
                                   }
                                  if (count == 2 || dem == productByCategory.Rows.Count)
                                  {%></ul><%}
                                  count++;
                             }
                          }
                          else
                          {
                            %><div>Đang cập nhật</div><%   
                          }
                   }
                   else
                   { %>
                        <div class="fixed_img_col4" id="Div1">
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
                              int dem = 0;
                              foreach (DataRow row2 in productByCategory.Rows)
                              {
                                  dem++;
                                  string name = row2["NameCAM"].ToString().Trim();
                                  if (count > 3) count = 1;
                                  if (count == 1)
                                  {%><ul><%}
                                  if (count <= 3)
                                  {
                                      if (!row0["CategoryID"].ToString().Equals("3"))
                                      {                              
                                            %>
                                            <li>
                                                <a title="<%=row2["NameCAM"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                                    <span class="thumb">
                                                        <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                                    </span>
                                                    <strong><% if (name != "")
                                                               { %><%=name%><br />
                                                        <% } %><%=row2["ProductID"]%></strong>
                                                </a>
                                            </li>
                                            <%
                                      }
                                      else
                                      {
                                            %>
                                            <li>
                                                <a title="<%=row2["NameCAM"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="ProductDetail.aspx?Id=<%=row2["ProductID"]%>">
                                                    <span class="thumb">
                                                        <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                                    </span>
                                                    <strong><% if (name != "")
                                                               { %><%=name%><br />
                                                        <% } %><%=row2["ProductID"]%></strong>
                                                </a>
                                            </li>
                                            <%  
                                      }
                                  }
                                  if (count == 3 || dem == productByCategory.Rows.Count)
                                  { %></ul><%}
                                  count++;
                              }
                          }
                          else
                          {
                            %><div>Đang cập nhật</div><%
                          }
                   } %>
                    </div>
                </div>
    <%    }
      }
  }
  else
  {
       int numRow = 0;
       foreach (DataRow row0 in categoryLevel1.Rows)
       {
           DataTable categoryLevel2 = new DataTable();
           categoryLevel2 = DataAccess.GetDatatable("select * from fnGetAllChild(" + row0["CategoryID"].ToString() + ")");
           foreach (DataRow row1 in categoryLevel2.Rows)
           {
               DataTable productByCategory = new DataTable();
               productByCategory = DataAccess.GetDatatable("select * from Product  where Status=1 and CategoryID =" + row1["CategoryID"].ToString() + " order by CreatedDate desc");
    %>
                <div class="c2">
                <%if (productByCategory.Rows.Count > 0)
                { %>
                    <div class="t_c2"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>"><%= row0["NameCAM"] %> - <%= row1["NameCAM"] %></a></div>
                    <div class="seemore" style="display: none;"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>">Xem thêm&nbsp;&#187;</a></div>
                    <div style='clear: both;'></div>
                <%}
                else
                {
                %>
                    <div class="t_c2"><a href="javascript:void();"><%= row0["NameCAM"] %> - <%= row1["NameCAM"] %></a></div>
                    <div class="seemore" style="display: none;"><a href="javascript:void();">Xem thêm&nbsp;&#187;</a></div>
                    <div style='clear: both;'></div>
                <%
                } 
                if ((bool)row1["ViewType"])
                { %>
                    <div class="fixed_img_col2" id="Div2">
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
                                        return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; font-weight:normal;"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>" style="color:#6ab901;">Xem thêm&nbsp;&#187;</a></div>';
                                    }
                                }
                            });

                        </script>
                        
                            <% int count = 1;
                               int dem = 0;
                               foreach (DataRow row2 in productByCategory.Rows)
                               {
                                  dem++;
                                  if (count > 2) count = 1;
                                  if (count == 1 )
                                  {%><ul><%}
                                   if (count <= 2)
                                   {
                       
                                       string name = row2["NameCAM"].ToString().Trim();
                                        %>
                                        <li>
                                            <a title="<%=row2["NameCAM"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                                <span class="thumb">
                                                    <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                                </span>
                                                <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                                            </a>
                                        </li>
                                        <%
                                  }
                                  if (count == 2 || dem == productByCategory.Rows.Count)
                                  {%></ul><%}
                                  count++;
                               }
                }
                else
                { %>
                        <div class="fixed_img_col4" id="Div3">
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
                                            return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; color:#6ab901; font-weight:normal;"><a href="ProductByCategory.aspx?Id=<%= row1["CategoryID"].ToString() %>" style="color:#6ab901;">Xem thêm&nbsp;&#187;</a></div>';
                                        }
                                    }
                                });

                            </script>
                            <% 
                       int count = 1;
                       int dem = 0;
                       foreach (DataRow row2 in productByCategory.Rows)
                       {
                            dem++;
                            string name = row2["NameCAM"].ToString().Trim();
                            if (count > 3) count = 1;
                            if (count == 1)
                            {%><ul><%}
                            if (count <= 3)
                            {                  
                                %>
                                <li>
                                    <a title="<%=row2["NameCAM"]%> - <%=row2["ProductID"]%>#idefloors.vn#<%=row2["Size"]%>" href="../../Images/ProductImages/<%=row2["ImageUrl"]%>">
                                        <span class="thumb">
                                            <img alt="idefloors.vn" src="../../Images/ProductImages/<%=row2["ImageUrl"]%>" />
                                        </span>
                                        <strong><% if (name != ""){ %><%=name%><br /><% } %><%=row2["ProductID"]%></strong>
                                    </a>
                                </li>
                                <%                     
                           }
                           if (count == 3 || dem == productByCategory.Rows.Count)
                            { %></ul><%}
                            count++;
                       }  
               } %>
                </div>
            </div>
        <%}
      }
  } %>
