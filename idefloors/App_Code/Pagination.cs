using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pagination
/// </summary>
public class Pagination
{
    public Pagination() { }
    private int _Limit = 10;
    private int _PageNumber = 1;
    private string _Next = "Next";
    private string _Prev = "Previous";
    private string _First = "First";
    private string _Last = "Last";
    private long _Total = 0;
    private string _Page = "Page";
    private string _URL = "";
    private int _ItemShowNumber = 5;

    public string URL { set { _URL = value; } }
    public int ItemShowNumber { set { _ItemShowNumber = value; } }
    public string Page { set { _Page = value; } }
    public long Total { set { _Total = value; } }
    public string First { set { _First = value; } }
    public string Last { set { _Last = value; } }
    public int Limit { set { _Limit = value; } }
    public int PageNumber { set { _PageNumber = value; } }
    public string Next { set { _Next = value; } }
    public string Previous { set { _Prev = value; } }
    /// <summary>
    /// Return string for pagination 
    /// </summary>
    /// <param name="sPage">String to show "Page"</param>
    /// <param name="iPageNumber">Current page</param>
    /// <param name="iLimit">Limit item to dislay</param>
    /// <param name="lTotal">Total of record</param>
    /// <param name="iItemShowNuber">Number of page to show</param>
    /// <param name="sNext">String "Next"</param>
    /// <param name="sPrev">String "Previous"</param>
    /// <param name="sFirst">String "First page"</param>
    /// <param name="sLast">String "Last page"</param>
    /// <param name="sURL">URL to Link</param>    
    public Pagination(string sPage, int iPageNumber, int iLimit, long lTotal, int iItemShowNuber, string sNext, string sPrev, string sFirst, string sLast, string sURL)
    {
        _Page = sPage;
        _PageNumber = iPageNumber;
        _Limit = iLimit;
        _Total = lTotal;
        _ItemShowNumber = iItemShowNuber;
        _Next = sNext;
        _Prev = sPrev;
        _First = sFirst;
        _Last = sLast;
        _URL = sURL;
    }
   

    public string getStringPagination()
    {
        if (_Limit >= _Total) return String.Empty;
        long tmp = _Total / _Limit;
        int item = _ItemShowNumber / 2;
        string strTmp = "<div id=\"Paging\"><strong>" + _Page + "</strong>&nbsp;";
        if (!_URL.Contains("?")) _URL += "?";
        if (_PageNumber > 1)
        {
            strTmp += "<span><a href=\"" + _URL + "Page=1\">" + _First + "</a></span>&nbsp;";
            strTmp += "<span><a href=\"" + _URL + "Page=" + (_PageNumber - 1) + "\">" + _Prev + "</a></span>&nbsp;";
        }

        for (int i = 0; i < tmp; i++)
        {
            if (i + 1 == _PageNumber) strTmp += "<span id=\"PagingActive\" class='selected'>" + (i + 1) + "</span>&nbsp;";
            else if (((i + 1 >= _PageNumber - item) && (i + 1 <= _PageNumber + item)) || ((i + 1 > _Total - _ItemShowNumber) && (i + 1 < _PageNumber)) || ((i + 1 < _ItemShowNumber) && (i + 1 > _PageNumber))) strTmp += "<span><a href=\"" + _URL + "&Page=" + (i + 1) + "\">" + (i + 1) + "</a></span>&nbsp;";
        }
        if (tmp * _Limit < _Total)
        {
            if (_PageNumber >= tmp + 1) strTmp += "<span id=\"PagingActive\" class='selected'>" + (tmp + 1) + "</span>&nbsp;";
            else
            {
                strTmp += "<span><a href=\"" + _URL + "Page=" + (tmp + 1) + "\">" + (tmp + 1) + "</a></span>&nbsp;";
                strTmp += "<span><a href=\"" + _URL + "Page=" + (_PageNumber + 1) + "\">" + _Next + "</a></span>&nbsp;";
                strTmp += "<span><a href=\"" + _URL + "Page=" + (tmp + 1) + "\">" + _Last + "</a></span>&nbsp;";
            }
        }
        else if (_PageNumber < tmp)
        {
            strTmp += "<span><a href=\"" + _URL + "Page=" + (_PageNumber + 1) + "\">" + _Next + "</a></span>&nbsp;";
            strTmp += "<span><a href=\"" + _URL + "Page=" + (tmp) + "\">" + _Last + "</a></span>&nbsp;";
        }
        return strTmp + "</div>";
    }
    public string getStringPaginationAjax(int iAction)
    {
        if (_Limit >= _Total) return String.Empty;
        long tmp = _Total / _Limit;
        int item = _ItemShowNumber / 2;
        string strTmp = "<div id=\"Paging\"><strong>" + _Page + "</strong>&nbsp;";
        if (!_URL.Contains("?")) _URL += "?";
        if (_PageNumber > 1)
        {
            strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=1'," + iAction + ");return false;\">" + _First + "</a>&nbsp;";
            strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (_PageNumber - 1) + "'," + iAction + ");return false;\">" + _Prev + "</a>&nbsp;";
        }

        for (int i = 0; i < tmp; i++)
        {
            if (i + 1 == _PageNumber) strTmp += "<span id=\"PagingActive\">" + (i + 1) + "</span>&nbsp;";
            else if (((i + 1 >= _PageNumber - item) && (i + 1 <= _PageNumber + item)) || ((i + 1 > _Total - _ItemShowNumber) && (i + 1 < _PageNumber)) || ((i + 1 < _ItemShowNumber) && (i + 1 > _PageNumber))) strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (i + 1) + "'," + iAction + ");return false;\">" + (i + 1) + "</a>&nbsp;";
        }
        if (tmp * _Limit < _Total)
        {
            if (_PageNumber >= tmp + 1) strTmp += "<span id=\"PagingActive\">" + (tmp + 1) + "</span>&nbsp;";
            else
            {
                strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (tmp + 1) + "'," + iAction + ");return false;\">" + (tmp + 1) + "</a>&nbsp;";
                strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (_PageNumber + 1) + "'," + iAction + ");return false;\">" + _Next + "</a>&nbsp;";
                strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (tmp + 1) + "'," + iAction + ");return false;\">" + _Last + "</a>&nbsp;";
            }
        }
        else if (_PageNumber < tmp)
        {
            strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (_PageNumber + 1) + "'," + iAction + ");return false;\">" + _Next + "</a>&nbsp;";
            strTmp += "<a href=\"#\" onclick=\"createAjax('" + _URL + "&Page=" + (tmp) + "'," + iAction + ");return false;\">" + _Last + "</a>&nbsp;";
        }
        strTmp += "</div>";
        return strTmp;
    }

    //New
    public string getStringPaginationAjax_Location(string objectIDName)
    {
        if (_Limit >= _Total) return String.Empty;
        long tmp = _Total / _Limit;
        int item = _ItemShowNumber / 2;
        string strTmp = "<div id=\"Paging\"><strong>" + _Page + "</strong>&nbsp;";
        if (!_URL.Contains("?")) _URL += "?";
        if (_PageNumber > 1)
        {
            strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=1','" + objectIDName + "');return false;\">" + _First + "</a>&nbsp;";
            strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (_PageNumber - 1) + "','" + objectIDName + "');return false;\">" + _Prev + "</a>&nbsp;";
        }

        for (int i = 0; i < tmp; i++)
        {
            if (i + 1 == _PageNumber) strTmp += "<span id=\"PagingActive\">" + (i + 1) + "</span>&nbsp;";
            else if (((i + 1 >= _PageNumber - item) && (i + 1 <= _PageNumber + item)) || ((i + 1 > _Total - _ItemShowNumber) && (i + 1 < _PageNumber)) || ((i + 1 < _ItemShowNumber) && (i + 1 > _PageNumber))) strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (i + 1) + "','" + objectIDName + "');return false;\">" + (i + 1) + "</a>&nbsp;";
        }
        if (tmp * _Limit < _Total)
        {
            if (_PageNumber >= tmp + 1) strTmp += "<span id=\"PagingActive\">" + (tmp + 1) + "</span>&nbsp;";
            else
            {
                strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (tmp + 1) + "','" + objectIDName + "');return false;\">" + (tmp + 1) + "</a>&nbsp;";
                strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (_PageNumber + 1) + "','" + objectIDName + "');return false;\">" + _Next + "</a>&nbsp;";
                strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (tmp + 1) + "','" + objectIDName + "');return false;\">" + _Last + "</a>&nbsp;";
            }
        }
        else if (_PageNumber < tmp)
        {
            strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (_PageNumber + 1) + "','" + objectIDName + "');return false;\">" + _Next + "</a>&nbsp;";
            strTmp += "<a href=\"javascript:void(0);\" onclick=\"getData('" + _URL + "&Page=" + (tmp) + "','" + objectIDName + "');return false;\">" + _Last + "</a>&nbsp;";
        }
        return strTmp + "</div>";
    } 
}