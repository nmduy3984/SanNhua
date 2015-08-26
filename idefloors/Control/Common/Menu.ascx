<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Control_Common_Menu" %>
<%@ Import Namespace="System.Data" %>
<div class="div_menu">
    <div id="Menu">
        <div style="display: none;">
            <div id="inline1" class="popup-cart" style="width: 650px; height: 600px;">
            </div>
        </div>
        <style type="text/css">
            .order-button-container {
                text-align: right;
                float: right;
                width: 460px;
                margin: 10px 0px;
            }

            .clear {
                overflow: hidden;
                width: 100%;
            }

            .order-button-container a.button {
                background: transparent url('../images/orderbutton/bg_button_a.gif') no-repeat scroll top right;
                color: #444;
                display: block;
                float: right;
                font: normal 12px arial, sans-serif;
                height: 24px;
                margin-right: 6px;
                padding-right: 12px;
                text-decoration: none;
            }

                .order-button-container a.button span {
                    background: transparent url('../images/orderbutton/bg_button_span.gif') no-repeat;
                    display: block;
                    line-height: 14px;
                    padding: 5px 0 5px 12px;
                    font-weight: bold;
                    font-size: 13px;
                }

                .order-button-container a.button:active {
                    background-position: bottom right;
                    color: #000;
                    outline: none;
                }

                    .order-button-container a.button:active span {
                        background-position: bottom left;
                        padding: 6px 0 4px 12px;
                    }
        </style>
        <script type="text/javascript">
            function toggleMenu(el1, el2, over) {
                var p, prefix = 'nav-';
                if (el2 == -1) p = document.getElementById(prefix + el1);
                else p = document.getElementById(prefix + el1 + '-' + el2);
                if (over == 1) { var newClassName = p.className + " over"; p.className = newClassName; }
                else { var newClassName = p.className.replace(" over", ""); p.className = newClassName; }
            }
        </script>
        <div id="menu-container">
            <div id="cssmenu">
                <div id="indicatorContainer">
                    <div style="left: 261px;" id="pIndicator">
                        <div id="cIndicator"></div>
                    </div>
                </div>
                <ul>
                    <!--<li id="menu-button"><a>Menu</a></li>-->
                    <li><a href="Home.aspx"><span class="home">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></a></li>
                    <li><a href="Product.aspx"><span>Sản phẩm</span></a>
                        <ul>
                            <% foreach (DataRow row in Menu.Rows)
                               {
                            %>
                            <li class="spacemenu"><a href="./ProductByCategory.aspx?Id=<%= row["CategoryID"].ToString() %>"><span><%= row["Name"] %></span></a>
                            </li>
                            <%} %>
                        </ul>
                    </li>
                    <li class="active has-sub"><a href="../Page/Certificate.aspx"><span>Chứng nhận chất lượng</span></a>
                    </li>
                    <li><a href="../Page/Advice.aspx"><span>Hướng dẫn lắp đặt</span></a></li>
                    <li class="last"><a href="../Page/References.aspx"><span>Tài liệu tham khảo</span></a></li>
                    <li class="last"><a href="../Page/Projects.aspx"><span>Dự án</span></a></li>
                    <li class="last"><a href="../Page/News.aspx"><span>Tin tức</span></a></li>
                </ul>
            </div>
        </div>
        <br class="Clear" />
    </div>
    <!-- end Menu -->
</div>
