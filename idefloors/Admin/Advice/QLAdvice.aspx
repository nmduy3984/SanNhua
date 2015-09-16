<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="QLAdvice.aspx.cs" Inherits="Admin_Advice_QLAdvice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">

 
<div class="topPanel">
    <div class="floatLeft">
        <asp:LinkButton CssClass="btn_green" ID="btnAdd" OnClick="btnAdd_Click"
            runat="server">Tạo mới</asp:LinkButton>
        <asp:LinkButton CssClass="btn_green" ForeColor="#ca0303" ID="btnDelete"
            OnClick="btnDelete_Click" OnClientClick="return checkDelete('Are you sure delete all selected items');"
            runat="server">Xóa sản phẩm</asp:LinkButton>
     </div>
</div>

<div style="margin:auto; width:100%">
    <div style="float:right;margin-bottom: 11px;margin-top: 10px;"><%=_Status%> || Page size 
            <asp:DropDownList ID="ddlPageSize" AutoPostBack="true" onselectedindexchanged = "btnGetData_Click" runat="server" >
              <asp:ListItem Text= "4" Value ="4" ></asp:ListItem>
              <asp:ListItem Text= "10" Value ="10" ></asp:ListItem>
              <asp:ListItem Text= "30" Value ="30" ></asp:ListItem>
              <asp:ListItem Text= "50" Value ="50" ></asp:ListItem>
              <asp:ListItem Text= "100" Value ="100" ></asp:ListItem>
            </asp:DropDownList> 
            &nbsp;<%=_Pagination%>
    </div>
    <table class="table_Blue" id="mainData" style="min-width:600px" cellpadding="0" cellspacing="0">
        <tr>
            <th scope="col" width="25">
               
            </th>             
            <th scope="col">
                <span>Tiêu đề</span>
            </th>
            <th scope="col">
                <span>Mô tả</span>
            </th>
            <th scope="col">
                <span>Loại file</span>
            </th>
            <th scope="col">
                <span>Download file</span>
            </th>
            <th scope="col" width="50">
                <span>Hình đại diện (ImgURL)</span>
            </th>
        </tr>

        <%
            for (int i = 0; i < dtAdvice.Rows.Count; i++)
            {
                string ID = dtAdvice.Rows[i]["ID"].ToString();
                string hinhanh = dtAdvice.Rows[i]["ImageURL"].ToString();
                string title = dtAdvice.Rows[i]["Title"].ToString();
                string des = dtAdvice.Rows[i]["Description"].ToString();
                string filename = dtAdvice.Rows[i]["FileName"].ToString();
                string linkVideo = dtAdvice.Rows[i]["LinkVideo"].ToString();
                string type = "PDF";
                if (dtAdvice.Rows[i]["Type"].ToString() =="False")
                    type = "Video";
                
          
        %>
        <tr>
            <td>
                <input type="checkbox" name="chk" value="<%=ID%>" />
            </td>
            
            <td>
                   <a href="Edit.aspx?ID=<%=ID%>"><%=title%></a>
            </td>
            <td>
                <%=des%>
            </td>   
            <td>
                <%=type%>
            </td>
            <td>
                <% if (dtAdvice.Rows[i]["Type"].ToString() == "True"){ %>
                <a href="/Images/PDF/Advice/<%=filename%>" target="_blank"><%=filename%></a>
                <%}else{
                    %>
                <a href="<%=linkVideo%>" target="_blank"><%=linkVideo%></a>
                <%   
                   } %>
            </td>
            <td align="center">
                <img  alt="idefloors.vn" height="150px" width="150px;" src="/Images/Advice/<%=hinhanh%>" />
            </td>
         </tr>
        <%} %>

    </table>
</div>
</asp:Content>

