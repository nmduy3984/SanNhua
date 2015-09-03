using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_NewProduct : System.Web.UI.UserControl
{
    public DataTable new_product = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            new_product = DataAccess.GetDatatable("select top 20 * from Product where Status=1 and IsNewProduct=1 order by CreatedDate desc");
    }
}