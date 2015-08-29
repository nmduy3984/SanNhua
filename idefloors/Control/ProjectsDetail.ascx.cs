using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_ProjectsDetail : System.Web.UI.UserControl
{
    public DataTable projectsByID = new DataTable();
    public DataTable projectsOtherID = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string Id = Request.QueryString["Id"] == null ? "" : Request.QueryString["Id"] == "" ? "" : Request.QueryString["Id"];
            projectsByID = DataAccess.GetRecord("Projects", "Id", Id);
            ltrContent.Text = Server.HtmlDecode(projectsByID.Rows[0]["Content"].ToString());
            lblTitle.Text = projectsByID.Rows[0]["Title"].ToString();
            projectsOtherID = DataAccess.GetDatatable("select * from Projects where  Id <> " + Id + " order by CreatedDate desc");
        }
    }
}