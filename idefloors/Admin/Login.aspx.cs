using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        string UserName = txtUserName.Text.Trim();
        string Password = txtPassword.Text;
        //UserAccount info = UserAccountBUS.Login(UserName, Password);
        DataTable info = DataAccess.GetRecord("[UserAccount]", "UserName", UserName, "Password", Utilities.MD5(Password));

        if (info.Rows.Count == 1)
        {
            //Cap nhat thong tin user vao session
            Session["UserName"] = info.Rows[0]["UserName"];
            Session["UserID"] = info.Rows[0]["UserID"];
               
            //Set cookie
            if (RememberMe.Checked)
            {
                string contentCookie = Session["UserName"].ToString() + "|" + Session["UserID"].ToString() ;
                Utilities.Cookie_create("cookie_user", contentCookie);
            }
            Response.Redirect("/Admin/Home.aspx");
        }
        else
            MessageBox.Show(Page, "UserName or Password is incorrect");
    }
}