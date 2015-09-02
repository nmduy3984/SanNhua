using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Common_SlideProjects : System.Web.UI.UserControl
{
    public DataTable projectlogo = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            projectlogo = DataAccess.GetDatatable("select * from projectlogo order by CreatedDate desc");
    }
}