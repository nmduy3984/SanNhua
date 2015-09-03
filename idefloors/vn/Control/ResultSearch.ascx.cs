using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_ResultSearch : System.Web.UI.UserControl
{
    public string key = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            key = Request.QueryString["key"] == null ? "" : Request.QueryString["key"] == "" ? "" : Request.QueryString["key"];
        }
    }
}