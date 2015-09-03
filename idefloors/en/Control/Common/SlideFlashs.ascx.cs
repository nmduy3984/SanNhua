using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Control_Common_SlideFlashs : System.Web.UI.UserControl
{
    public DataTable Flash = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Flash = DataAccess.GetDatatable("select * from Flash order by CreatedDate desc");
    }
}