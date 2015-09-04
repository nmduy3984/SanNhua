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
        string url = HttpContext.Current.Request.Url.AbsoluteUri;
        if (url.ToLower().Contains("/en/") || url.ToLower().Contains("/cam/"))
        {
            url = url.Replace("/en/", "/vn/");
            url = url.Replace("/cam/", "/vn/");
        }
        Response.Redirect(url);
    }
    protected void lnkEN_Click(object sender, EventArgs e)
    {
        string url = HttpContext.Current.Request.Url.AbsoluteUri;
        if (url.ToLower().Contains("/vn/") || url.ToLower().Contains("/cam/"))
        {
            url = url.Replace("/vn/", "/en/");
            url = url.Replace("/cam/", "/en/");
        }
        Response.Redirect(url);
    }
    protected void lnkCAM_Click(object sender, EventArgs e)
    {
        string url = HttpContext.Current.Request.Url.AbsoluteUri;
        if (url.ToLower().Contains("/en/") || url.ToLower().Contains("/vn/"))
        {
            url = url.Replace("/en/", "/cam/");
            url = url.Replace("/vn/", "/cam/");
        }
        Response.Redirect(url);
    }
}