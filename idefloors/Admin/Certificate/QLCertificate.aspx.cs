﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Certificate_QLCertificate : System.Web.UI.Page
{
    public DataTable dt = new DataTable();
    //--------------------------------------------------
    public string _Pagination = "";
    private string _Page = "0";
    private string _Limit = "0";
    public string _Total = "0";
    public string _Order = "";
    public string _Status = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            showData();
        }
        //DataAccess.Delete("CREATE TABLE [dbo].[Certificate]( 	[CertificateID] [int] IDENTITY(1,1) NOT NULL, 	[Title] [nvarchar](200) NULL, 	[ImgUrl] [nvarchar](1000) NULL, 	[FileName] [nvarchar](1000) NULL,  CONSTRAINT [PK_Certificate] PRIMARY KEY CLUSTERED  ( 	[CertificateID] ASC )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]");
    }
     protected void btnDelete_Click(object sender, EventArgs e)
     {
         string x = Request.Form["chk"];
         Utilities.redirectClient(Page, "/Admin/Certificate/Delete.aspx?ID="+x);
     }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Utilities.redirectClient(Page, "/Admin/Certificate/Insert.aspx");
    }
    private void showData()
    {
        string ID = Request.QueryString["CategoryID"];
        int total = 0;
        _Page = Request.QueryString["Page"] == null ? "1" : this.IsPostBack ? "1" : Request.QueryString["Page"];
        _Limit = ddlPageSize.SelectedValue;
        dt = DataAccess.getCertificate("-1", _Page, _Limit, ref total);

        _Total = total.ToString();
        int from, to;
        from = _Total == "0" ? 0 : (1 + (Convert.ToInt32(_Page) - 1) * Convert.ToInt32(ddlPageSize.SelectedValue));
        to = Convert.ToInt32(ddlPageSize.SelectedValue) * Convert.ToInt32(_Page) <= Convert.ToInt32(_Total) ? Convert.ToInt32(ddlPageSize.SelectedValue) * Convert.ToInt32(_Page) : Convert.ToInt32(_Total);
        _Status = "<span class='actived_true'>Viewing " + from.ToString() + " to " + to.ToString() + " of " + _Total + "</span>";
        Pagination pg = new Pagination();

        pg.Limit = Convert.ToInt32(_Limit);
        pg.PageNumber = Convert.ToInt32(_Page);
        pg.Total = Convert.ToInt64(_Total);
        pg.Page = "Pages";
        pg.First = "|<";
        pg.Next = ">";
        pg.Previous = "<";
        pg.Last = ">|";
        pg.ItemShowNumber = 10;
        pg.URL = "";//Session["PageOriginal"].ToString();
        _Pagination = pg.getStringPagination();
        //loadColFilter();
    }

    protected void btnGetData_Click(object sender, EventArgs e)
    {
        showData();
    }
}