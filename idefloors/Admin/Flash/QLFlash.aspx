<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPages/AdminMaster.master" AutoEventWireup="true" CodeFile="QLFlash.aspx.cs" Inherits="Admin_Flash_QLFlash" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
<div class="topPanel">
    <div class="floatLeft">
        <asp:LinkButton CssClass="btn_green" ID="btnAdd" OnClick="btnAdd_Click"
            runat="server">Tạo mới</asp:LinkButton>
        <asp:LinkButton CssClass="btn_green" ForeColor="#ca0303" ID="btnDelete"
            OnClick="btnDelete_Click" OnClientClick="return checkDelete('Are you sure delete all selected items');"
            runat="server">Xóa Flash</asp:LinkButton>
       
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
            <th scope="col" width="25">
                <span>Image</span>
            </th>
           
            <th scope="col">
                <span>Thumb</span>
            </th>
            <th scope="col">
               Link
            </th>
        </tr>

        <%
        foreach (System.Data.DataRow dr in dt.Rows)
        {    
        %>
        <tr>
            <td>
                <input type="checkbox" name="chk" value="<%=dr["Id"]%>" />
            </td>
             <td>
                 <a href="Edit.aspx?ID=<%=dr["Id"]%>"><img height="150px" width="150px;" src="/Images/Flash/<%=dr["ImgUrl"]%>" /></a>
            </td> 
            <td>
                <a href="Edit.aspx?ID=<%=dr["Id"]%>"><%=dr["Title"]%></a>
            </td>  
             <td>
                <%=dr["Link"].ToString()%>
            </td>
             
         </tr>
        <%} %>

    </table>
</div>
</asp:Content>


