﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Control_Projects : System.Web.UI.UserControl
{
    public DataTable projects = new DataTable();

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
    }
    private void showData()
    {
        string ID = Request.QueryString["Id"];
        int total = 0;
        _Page = Request.QueryString["Page"] == null ? "1" : this.IsPostBack ? "1" : Request.QueryString["Page"];
        _Limit = "10";
        projects = DataAccess.getProjects("-1", _Page, _Limit, ref total);

        _Total = total.ToString();
        int from, to;
        from = _Total == "0" ? 0 : (1 + (Convert.ToInt32(_Page) - 1) * 10);
        to = 10 * Convert.ToInt32(_Page) <= Convert.ToInt32(_Total) ? 10 * Convert.ToInt32(_Page) : Convert.ToInt32(_Total);
        //_Status = "<span class='actived_true'>Hiển thị từ " + from.ToString() + " đến " + to.ToString() + " trong tổng số " + _Total + " bản ghi</span>";
        Pagination pg = new Pagination();

        pg.Limit = Convert.ToInt32(_Limit);
        pg.PageNumber = Convert.ToInt32(_Page);
        pg.Total = Convert.ToInt64(_Total);
        pg.Page = "";
        pg.First = "|<";
        pg.Next = ">";
        pg.Previous = "<";
        pg.Last = ">|";
        pg.ItemShowNumber = 10;
        pg.URL = "";//Session["PageOriginal"].ToString();
        _Pagination = pg.getStringPagination();
        //loadColFilter();
    }
}