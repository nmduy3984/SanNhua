using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_ProductDetail : System.Web.UI.UserControl
{
    public DataTable productByID = new DataTable();
    public DataTable productOtherID = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string Id = Request.QueryString["Id"] == null ? "" : Request.QueryString["Id"] == "" ? "" : Request.QueryString["Id"];
            productByID = DataAccess.GetRecord("Product", "ProductID", Id);
            productOtherID = DataAccess.GetDatatable("select * from Product  where Status=1 and CategoryID=" + productByID.Rows[0]["CategoryID"].ToString() + " and ProductID <> '" + Id + "' order by CreatedDate desc");
        }
    }
}