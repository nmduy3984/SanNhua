using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_NewsDetail : System.Web.UI.UserControl
{
    public DataTable newsByID = new DataTable();
    public DataTable newsOtherID = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string Id = Request.QueryString["Id"] == null ? "" : Request.QueryString["Id"] == "" ? "" : Request.QueryString["Id"];
            newsByID = DataAccess.GetRecord("News", "Id", Id);
            ltrContent.Text = Server.HtmlDecode(newsByID.Rows[0]["Content"].ToString());
            lblTitle.Text = newsByID.Rows[0]["Title"].ToString();
            newsOtherID = DataAccess.GetDatatable("select * from News where  Id <> " + Id + " order by CreatedDate desc");
        }
    }
}