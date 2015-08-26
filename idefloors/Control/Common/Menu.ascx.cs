using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Control_Common_Menu : System.Web.UI.UserControl
{
    public DataTable Menu = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        Menu = DataAccess.GetDatatable("exec GetAllCategoryLevel 1");
    }
}