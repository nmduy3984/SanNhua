using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Common_LeftMenu : System.Web.UI.UserControl
{
    public DataTable CategoryLevel0 = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        CategoryLevel0 = DataAccess.GetRecord("Category", "ParentID", "0");
    }
}