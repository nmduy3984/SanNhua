using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Certificate : System.Web.UI.UserControl
{
    public DataTable certificate = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            certificate = DataAccess.GetDatatable("select * from Certificate");
    }
}