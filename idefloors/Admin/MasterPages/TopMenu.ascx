<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TopMenu.ascx.cs" Inherits="Hedgewig.Web.MasterPages.TopMenu" %>

<ul id="navi">
    <li>        
        <a href="/Admin/Home.aspx" class="mHome" style="text-align: center;">Trang chủ</a>
    </li>
    <li>
        <a href="#" class="mAmazon" style="text-align: center;" >Hệ thống</a>
        <div class="sub" id="lAmazon">
         <table cellpadding="0" cellspacing="0" class="tableMenu">
            <tr>
                <td>
                    <ul style="width:200px!important;">
                        <li>Quản lý</li>
                        <li><a href="/Admin/DanhMuc/QLDanhMucSP.aspx">Quản lý danh mục sản phẩm</a></li>
                        <li><a href="/Admin/SanPham/QLSanPham.aspx">Quản lý sản phẩm</a></li>
                        <li><a href="/Admin/TinTuc/QLTinTuc.aspx">Quản lý Tin Tức</a></li>
                        <li><a href="/Admin/Project/QLProject.aspx">Quản lý Project</a></li>
                        <li><a href="/Admin/Flash/QLFlash.aspx">Quản lý Flash</a></li>
                       <%-- <li><a href="/Admin/QLUser.aspx">Quản lý user</a></li>--%>
                    </ul>
                  </td>    
            </tr>
        </table>
        </div>
    </li>
</ul>