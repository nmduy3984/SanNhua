using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_AboutUS : System.Web.UI.UserControl
{
    public DataTable aboutus = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            aboutus = DataAccess.GetDatatable("select * from aboutus");
            ltrContent.Text = aboutus.Rows[0]["Content"].ToString();
        }
    }
}