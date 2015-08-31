using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_ProductByCatagory : System.Web.UI.UserControl
{
    public DataTable categoryById = new DataTable();
    public DataTable categoryByParentId = new DataTable();
    public DataTable categoryLevel1 = new DataTable();
    public string Id = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
             Id = Request.QueryString["Id"] == null ? "" : Request.QueryString["Id"] == "" ? "" : Request.QueryString["Id"];
            if (Id == "2")
            {
                categoryLevel1 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(2)");
                categoryByParentId = DataAccess.GetDatatable("select * from Category where CategoryID =2");
                if (string.IsNullOrEmpty(ltrContent.Text))
                    ltrContent.Text = categoryByParentId.Rows[0]["Description"].ToString();
            }
            else
            {
                categoryById = DataAccess.GetDatatable("select * from fnGetAllChild(" + Id + ")");
                string para = "";
                if (categoryById.Rows.Count > 0)
                {
                    para = categoryById.Rows[0]["ParentID"].ToString();
                }
                else
                {
                    categoryById = DataAccess.GetDatatable("select * from Category where CategoryID =" + Id);
                    para = categoryById.Rows[0]["ParentID"].ToString();
                    ltrContent.Text = categoryById.Rows[0]["Description"].ToString();
                }
                categoryByParentId = DataAccess.GetDatatable("select * from Category where CategoryID =" + para);
                if (string.IsNullOrEmpty(ltrContent.Text))
                    ltrContent.Text = categoryByParentId.Rows[0]["Description"].ToString();
            }
        }
    }
}