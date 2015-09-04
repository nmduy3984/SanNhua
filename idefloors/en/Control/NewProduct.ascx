<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewProduct.ascx.cs" Inherits="Control_NewProduct" %>
<%@ Import Namespace="System.Data" %>

<div class="c2">
    <div class="t_c2"><a href='javascript:void();'>Sản phẩm mới</a></div>
    <div class="seemore"></div>
    <div style='clear: both;'></div>
    <%if (new_product.Rows.Count > 0)
      { %>
    <div class="spec_products">
        <div id="SlideNewProduct" style="position: relative; top: 0px; left: 0px; width: 751px; height: 250px; overflow: hidden;">

            <!-- Loading Screen -->
            <div u="loading" style="position: absolute; top: 0px; left: 0px;">
                <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000; top: 0px; left: 0px; width: 100%; height: 100%;">
                </div>
                <div style="position: absolute; display: block; background: url(../../images/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
                </div>
            </div>

            <!-- Slides Container -->
            <div class="ProductList" u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 751px; height: 250px; overflow: hidden;">
                <% foreach (DataRow row in new_product.Rows)
                   {
                       DataTable productPopup = new DataTable();
                       productPopup = DataAccess.GetDatatable("select * from Product  where Status=1 and CategoryID = " + row["CategoryID"].ToString() + " and ProductID <> '" + row["ProductID"].ToString() + "'");
                %>
                <div id='PopupNewProduct<%= row["ProductID"].ToString()%>'>
                    <%if (productPopup.Rows.Count > 0)
                      { %>
                    <script type="text/javascript">
                        $('#PopupNewProduct<%= row["ProductID"].ToString() %>').magnificPopup({
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
                                    return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; font-weight:normal;"><a href="../../Page/ProductByCategory.aspx?Id=<%= row["CategoryID"].ToString() %>" style="color:#6ab901;">See more&nbsp;&#187;</a></div>';
                                }
                            }
                        });
                    </script>
                    <%}
                      else
                      {
                    %>
                    <script type="text/javascript">
                        $('#PopupNewProduct<%= row["ProductID"].ToString() %>').magnificPopup({
                            delegate: 'a',
                            type: 'image',
                            tLoading: 'Loading image #%curr%...',
                            mainClass: 'mfp-img-mobile',
                            gallery: {
                                enabled: false,
                                navigateByImgClick: false,
                                preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
                            },
                            image: {
                                tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
                                titleSrc: function (item) {
                                    var arr = item.el.attr('title').split('#idefloors.vn#');
                                    return '<div style="float:left;padding-left:5px;color:#403d3b;font-size:12px;font-weight:normal;">' + arr[1] + '</div>' + arr[0] + '<div style="float:right;font-size:12px; font-weight:normal;"><a href="../../Page/ProductByCategory.aspx?Id=<%= row["CategoryID"].ToString() %>" style="color:#6ab901;">See more&nbsp;&#187;</a></div>';
                                }
                            }
                        });
                    </script>
                    <%   
                      } %>
                    <%int dem = 1;
                      foreach (DataRow row1 in productPopup.Rows)
                      {
                          if (dem == 1)
                          {
                              dem++;
                    %>
                    <div>
                        <a title="<%=row["NameEN"]%> - <%=row["ProductID"]%>#idefloors.vn#<%=row["Size"]%>" href="../../Images/ProductImages/<%=row["ImageUrl"]%>">
                            <img  alt="idefloors.vn"  u="image" class="img" src="../../Images/ProductImages/<%=row["ImageUrl"]%>" /></a>
                    </div>
                    <div style="text-align: center; color: #555"><strong><%=row["NameEN"]%><br /><%=row["ProductID"]%></strong></div>
                    <%}
                    %>
                    <div style="display: none;">
                        <a title="<%=row1["NameEN"]%> - <%=row1["ProductID"]%>#idefloors.vn#<%=row1["Size"]%>" href="../../Images/ProductImages/<%=row1["ImageUrl"]%>">
                            <span class="thumb">
                                <img  alt="idefloors.vn"  src="../../Images/ProductImages/<%=row1["ImageUrl"]%>" />
                            </span>
                            <strong><%=row1["NameEN"]%><br /><%=row1["ProductID"]%></strong><em>Zoom</em>
                        </a>
                    </div>
                    <%
                      }
                    %>
                </div>
                <%} %>
            </div>

            <!--#region Bullet Navigator Skin Begin -->
            <style>
                /* jssor slider bullet navigator skin 03 css */
                /*
            .jssorb03 div           (normal)
            .jssorb03 div:hover     (normal mouseover)
            .jssorb03 .av           (active)
            .jssorb03 .av:hover     (active mouseover)
            .jssorb03 .dn           (mousedown)
            */
                .jssorb03 {
                    position: absolute;
                }

                    .jssorb03 div, .jssorb03 div:hover, .jssorb03 .av {
                        position: absolute;
                        /* size of bullet elment */
                        width: 21px;
                        height: 21px;
                        text-align: center;
                        line-height: 21px;
                        color: white;
                        font-size: 12px;
                        /*background: url(../img/b03.png) no-repeat;*/
                        overflow: hidden;
                        cursor: pointer;
                    }

                    .jssorb03 div {
                        background-position: -5px -4px;
                    }

                        .jssorb03 div:hover, .jssorb03 .av:hover {
                            background-position: -35px -4px;
                        }

                    .jssorb03 .av {
                        background-position: -65px -4px;
                    }

                    .jssorb03 .dn, .jssorb03 .dn:hover {
                        background-position: -95px -4px;
                    }
            </style>
            <!-- bullet navigator container -->
            <div u="navigator" class="jssorb03" style="bottom: 4px; right: 6px;">
                <!-- bullet navigator item prototype -->
                <div u="prototype">
                    <div u="numbertemplate"></div>
                </div>
            </div>
            <!--#endregion Bullet Navigator Skin End -->

            <!--#region Arrow Navigator Skin Begin -->
            <style>
                /* jssor slider arrow navigator skin 03 css */
                /*
            .jssora03l                  (normal)
            .jssora03r                  (normal)
            .jssora03l:hover            (normal mouseover)
            .jssora03r:hover            (normal mouseover)
            .jssora03l.jssora03ldn      (mousedown)
            .jssora03r.jssora03rdn      (mousedown)
            */
                .jssora03l, .jssora03r {
                    display: block;
                    position: absolute;
                    /* size of arrow element */
                    width: 55px;
                    height: 55px;
                    cursor: pointer;
                    background: url(../images/a03.png) no-repeat;
                    overflow: hidden;
                }

                .jssora03l {
                    background-position: -3px -33px;
                }

                .jssora03r {
                    background-position: -63px -33px;
                }

                .jssora03l:hover {
                    background-position: -123px -33px;
                }

                .jssora03r:hover {
                    background-position: -183px -33px;
                }

                .jssora03l.jssora03ldn {
                    background-position: -243px -33px;
                }

                .jssora03r.jssora03rdn {
                    background-position: -303px -33px;
                }
            </style>
            <!-- Arrow Left -->
            <span u="arrowleft" class="jssora03l" style="top: 123px; left: 8px;"></span>
            <!-- Arrow Right -->
            <span u="arrowright" class="jssora03r" style="top: 123px; right: 45px;"></span>
            <!--#endregion Arrow Navigator Skin End -->
        </div>
    </div>
    <%} %>
</div>
