using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Control_Common_SlideFlashs : System.Web.UI.UserControl
{
    public DataTable banner = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            banner = DataAccess.GetDatatable("select * from Banner order by CreatedDate desc");
    }
}