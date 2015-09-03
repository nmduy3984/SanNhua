using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_Common_Banner : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void lnkVN_Click(object sender, EventArgs e)
    {
        //string lang = Session["Lang"].ToString();
        //if (!lang.Equals("vn"))
        //{
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (url.Contains("/EN/") || url.Contains("/CAM/"))
            {
                url = url.Replace("/EN/", "/VN/");
                url = url.Replace("/CAM/", "/VN/");
                //Session["Lang"] = "VN";
                
            }
            Response.Redirect(url);
        //}
    }
    protected void lnkEN_Click(object sender, EventArgs e)
    {
        //string lang = Session["Lang"].ToString();
        //if (!lang.Equals("en"))
        //{
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (url.Contains("/VN/") || url.Contains("/CAM/"))
            {
                url = url.Replace("/VN/", "/EN/");
                url = url.Replace("/CAM/", "/EN/");
                //Session["Lang"] = "EN";
            }
            Response.Redirect(url);
        //}
    }
    protected void lnkCAM_Click(object sender, EventArgs e)
    {
        //string lang = Session["Lang"].ToString();
        //if (!lang.Equals("cam"))
        //{
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            if (url.Contains("/EN/") || url.Contains("/VN/"))
            {
                url = url.Replace("/EN/", "/CAM/");
                url = url.Replace("/VN/", "/CAM/");
                //Session["Lang"] = "CAM";
            }
            Response.Redirect(url);
        //}
    }
}