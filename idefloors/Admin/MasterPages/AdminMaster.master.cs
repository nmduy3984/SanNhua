using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MasterPages_AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        checkCurrentLogin();
        //Load Username
        lblUser.Text = Session["UserName"].ToString();
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
         //Xoa cookie
        Utilities.Cookie_remove("cookie_us");

        Response.Redirect(StringHelper.PageLogin);

    }
    private void checkCurrentLogin()
    {
        //Check session first
        if (Session["UserName"] == null || Session["UserName"].ToString() == "")
        {
            //Check Cookie
            if (Request.Cookies["cookie_us"] != null)
            {
                string[] arg = Request.Cookies["cookie_us"].Value.Split('|');
                Session["UserName"] = arg[0];
                Session["UserID"] = arg[1];
                Session["IsAdmin"] = arg[2];
                //string IP = Request.UserHostAddress;
                //if (arg[3] != Utilities.MD5(IP)) //Neu thong tin khong trung khop thi xoa cookie di
                //{
                //    Utilities.Cookie_remove("cookie_us");
                //    Response.Redirect(StringHelper.PageLogin + "?Return=" + Server.UrlEncode(Request.RawUrl.ToString()));
                //}
                //else  //Neu thong tin trung khop, cap nhat lai cookie
                //{
                string contentCookie = Session["UserName"].ToString() + "|" + Session["UserID"].ToString() + "|" + Session["IsAdmin"].ToString();//+ "|" + Utilities.MD5(IP);
                    Utilities.Cookie_create("cookie_us", contentCookie);
                //}

            }
            else
                Response.Redirect(StringHelper.PageLogin + "?Return=" + Server.UrlEncode(Request.RawUrl.ToString()));


        }


    }

    
}
