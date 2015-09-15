using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Advice : System.Web.UI.UserControl
{
    public DataTable pdf = new DataTable();
    public DataTable video = new DataTable();
    public DataTable thamso = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pdf = DataAccess.GetDatatable("select  * from Advice where type=1  order by CreatedDate desc");
            video = DataAccess.GetDatatable("select  * from Advice where type=0  order by CreatedDate desc");
            thamso = DataAccess.GetDatatable("select * from thamso");
        }
    }
}