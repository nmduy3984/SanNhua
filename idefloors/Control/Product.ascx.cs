using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_CatagoryDetail : System.Web.UI.UserControl
{
    public DataTable categoryLevel1 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            categoryLevel1 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(1)");
    }
}