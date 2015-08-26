using System;
using System.Text;
using System.Data;
using System.Web;
using System.Security.Cryptography;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Text;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.Xml.Linq;
using System.Collections;

/// <summary>
/// Summary description for Utilities
/// </summary>

 public class Utilities
    {
        //===== Constant String =================
        public static string LicenseKey = "EQU1-4YRI-KEYA-HERE";
        //=======================================
        public static bool checkDomainID(object[] obj)
        {
            foreach (object o in obj)
            {
                if (o != null)
                {
                    try { long i = Convert.ToInt64(o); }
                    catch { return false; }
                }
            }
            return true;
        }
        public static string MD5(object oString)
        {
            string inputString = oString.ToString();
            UTF32Encoding u = new UTF32Encoding();
            byte[] bytes = u.GetBytes(inputString); //get original string
            MD5 md = new MD5CryptoServiceProvider(); // using md5 algorithm
            byte[] result = md.ComputeHash(bytes); // encrypted input bytes into encrypted bytes
            return Convert.ToBase64String(result).Replace('&', '_').Replace('=', '@').Replace('+', '_'); //return encrypted string
        }
        public static string ranString(object oSize)
        {
            int size = Convert.ToInt32(oSize);
            string str = "0123456789abcdefghijklmnopqrstuvwxzyABCDEFGHIJKLMNOPQRSTUVWXZY";
            string strResult = "";
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                strResult += str.Substring(r.Next(0, str.Length - 2), 1);
            }
            return strResult;
        }
        public static string ranNum(object oSize)
        {
            int size = Convert.ToInt32(oSize);
            string str = "0123456789";//thieu 1 l I  --> de nham lan
            string strResult = "";
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                strResult += str.Substring(r.Next(0, str.Length - 2), 1);
            }
            return strResult;
        }

        public static void redirectClient(System.Web.UI.Page p, object strURL)
        {
            System.Web.UI.LiteralControl lt = new System.Web.UI.LiteralControl();
            lt.Text = "<script language=\"javascript\" type=\"text/javascript\"> window.location='" + strURL.ToString() + "'</script>";
            p.Header.Controls.Add(lt);
        }
        public static void goBackClient(int count)
        {
            HttpContext.Current.Response.Write("<script>window.history.go(" + count.ToString() + ");</script>");
        }
        public static bool isDateTime(string Date)
        {
            try
            {
                Convert.ToDateTime(Date);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string formatDate(object date, object lang)
        {
            try
            {
                DateTime t = Convert.ToDateTime(date);
                switch (lang.ToString())
                {
                    case "VN": return String.Format("{0}/{1}/{2}", t.Day, t.Month, t.Year); //break;
                    case "EN": return String.Format("{0}/{1}/{2}", t.Month, t.Day, t.Year); //break;
                }
            }
            catch { }
            return "";
        }
        public static string formatDate_Vn_To_En(string dateVN)
        {
            try
            {
                string[] arrDate = dateVN.Split('/');
                DateTime dt = new DateTime(Convert.ToInt32(arrDate[2]), Convert.ToInt32(arrDate[1]), Convert.ToInt32(arrDate[0]));
                return dt.ToShortDateString();
            }
            catch { }
            return "1/1/1970";
        }
        public static string formatPrice(object Price, object Currency)
        {
            string sPrice = Price.ToString();
            if (sPrice == "" || sPrice == "0") return "Call";

            return formatNumber(Price) + Currency;
        }
        public static string formatNumber(object Number)
        {
            string sPrice = Number.ToString();
            if (sPrice == "") return "0";
            string str = "";
            for (int i = sPrice.Length; i >= 3; i -= 3)
            {
                str = (i == 3 ? "" : ".") + sPrice.Substring(i - 3 < 0 ? 0 : i - 3, 3) + str;
            }
            str = sPrice.Substring(0, sPrice.Length % 3) + str;
            return str + " ";
        }
        public static bool isNumber(object oNumber)
        {
            string strCheck = "0123456789";
            string str = oNumber.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                if (strCheck.IndexOf(str[i]) < 0) return false;
            }
            return true;
        }
        public static bool isTelNo(object oTelNo)
        {
            string pattern = "0123456789-() ";
            string str = oTelNo.ToString();
            if (str.Length > 0)
            {
                if (str.Length < 5)
                {
                    return false;
                }
                else
                {
                    for (int a = 0; a < str.Length; a++)
                    {
                        if (pattern.IndexOf(str[a]) == -1) return false;
                    }
                }
            }
            return true;
        }
        public static string cutString(object oStr, object oSize)
        {
            int size = Convert.ToInt32(oSize);
            string sCut = oStr.ToString();
            if (size >= sCut.Length) return sCut;
            string str = sCut.Substring(0, size);
            return str.Substring(0, str.LastIndexOf(" ") > 0 ? str.LastIndexOf(" ") : str.Length) + "...";
        }
        public static string generateURL(string Name, object Title, object strId)
        {
            string strTitle = Title.ToString();
            #region Generate SEO Friendly URL based on Title
            //Trim Start and End Spaces.
            strTitle = strTitle.Trim();
            //Trim "-" Hyphen
            strTitle = strTitle.Trim('-');
            //Replace . with - hyphen
            strTitle = strTitle.Replace(".", "-");
            strTitle = strTitle.ToLower();

            char[] chars = @"$%#@!*?;:~`+=()[]{}|\'<>,/^&"".".ToCharArray();
            //Replace Special-Characters
            for (int i = 0; i < chars.Length; i++)
            {
                string strChar = chars.GetValue(i).ToString();
                if (strTitle.Contains(strChar))
                {
                    strTitle = strTitle.Replace(strChar, string.Empty);
                }
            }

            //Replace all spaces with one "-" hyphen
            strTitle = strTitle.Replace(" ", "-");
            //Replace multiple "-" hyphen with single "-" hyphen.
            strTitle = strTitle.Replace("--", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("----", "-");
            //chuyen tieng viet co dau sang khong dau
            strTitle = removeUnicode(strTitle);
            #endregion

            //Append ID at the end of SEO Friendly URL
            strTitle = Name + "/" + strTitle + "-" + strId + ".aspx";
            return strTitle;
        }
        /// <summary>
        /// Chuyen tieng viet co dau sang khong dau
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string removeUnicode(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb.Replace("Đ", "d"); sb.Replace("đ", "d");
            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }
        public static string createPathYahoo(string strTitle)
        {
            return removeSpecialChar(strTitle);
        }
        public static string createPathMagento(string strTitle)
        {
            return removeSpecialChar(strTitle);
        }
        public static string removeSpecialChar(string strTitle)
        {
            //Trim Start and End Spaces.
            strTitle = strTitle.Trim();
            //Trim "-" Hyphen
            strTitle = strTitle.Trim('-');
            //Replace . with - hyphen
            strTitle = strTitle.Replace(".", "-");
            strTitle = strTitle.ToLower();

            strTitle = strTitle.Replace("&", "-");
            char[] chars = @"$%#@!*?;:~`+=()[]{}|\'<>,/^"".".ToCharArray();
            //Replace Special-Characters
            for (int i = 0; i < chars.Length; i++)
            {
                string strChar = chars.GetValue(i).ToString();
                if (strTitle.Contains(strChar))
                {
                    strTitle = strTitle.Replace(strChar, string.Empty);
                }
            }

            strTitle = strTitle.Replace(" - ", "-");
            //Replace all spaces with one "-" hyphen
            strTitle = strTitle.Replace(" ", "-");
            //Replace multiple "-" hyphen with single "-" hyphen.
            strTitle = strTitle.Replace("--", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("----", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("--", "-");

            return strTitle;
        }

        public static bool isEmailAddress(string email)
        {
            try
            {
                int nFirt = int.Parse(email.Substring(0, 1));
                return false;
            }
            catch
            {
                string pattern = @"^[_a-zA-Z0-9][_.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[_.a-zA-Z0-9]+)*\.([a-zA-Z]{2}|[a-zA-Z]{3}|[a-zA-Z]{4}|[a-zA-Z]{5})$";
                //Regular expression object
                Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
                //boolean variable to return to calling method
                bool valid = false;
                //make sure an email address was provided
                if (string.IsNullOrEmpty(email))
                {
                    valid = false;
                }
                else
                {
                    //use IsMatch to validate the address
                    valid = check.IsMatch(email.ToLower());
                }
                //return the value to the calling method
                return valid;
            }
        }
        public static bool checkValidUserName(string username)
        {
            string pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_.0123456789";
            string theStr = username;
            int count = 0;
            for (int i = 0; i < theStr.Length; i++)
            {
                count = pattern.IndexOf(theStr[i]);
                if (count == -1) break;
            }
            if (count < 0) return false;
            else return true;
        }

        public static string formatNumberLength(int number, int length)
        {
            try
            {
                int i = number;
                int size = length;
                string str = "";
                for (int k = size - 1; k >= i.ToString().Length; k--)
                    str += "0";
                str += i.ToString();
                return str;
            }
            catch { }
            return "0";
        }

        public static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            // column names 
            PropertyInfo[] oProps = null;
            if (varlist == null) return dtReturn;
            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }
                DataRow dr = dtReturn.NewRow();
                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }
                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        public static void LoadDropDownList(ref DropDownList ddlName, List<string> ColumnList, string SelectColumMappingName, ref List<string> ColumnSuccess)
        {
            ddlName.Items.Clear();
            SelectColumMappingName = SelectColumMappingName.ToLower().Trim();
            ddlName.Items.Add(new ListItem("--Select Column Name--", "-1"));
            foreach (var name in ColumnList)
            {
                ListItem li = new ListItem();
                li.Text = name;
                li.Value = name;
                ddlName.Items.Add(li);
                if (name.Contains("more-image")) SelectColumMappingName = SelectColumMappingName.Replace("more-img", "more-image");
                if (name == SelectColumMappingName)
                {
                    ColumnSuccess.Add(SelectColumMappingName);
                    ddlName.SelectedValue = SelectColumMappingName;
                }
            }
        }

        public static void LoadPageSize(ref DropDownList ddlPageSize)
        {
            //ddlPageSize.Items.Add(new ListItem("2", "2"));
            ddlPageSize.Items.Add(new ListItem("50", "50"));
            ddlPageSize.Items.Add(new ListItem("100", "100"));
            ddlPageSize.Items.Add(new ListItem("200", "200"));
            ddlPageSize.Items.Add(new ListItem("300", "300"));
            ddlPageSize.Items.Add(new ListItem("400", "400"));
            ddlPageSize.Items.Add(new ListItem("500", "500"));
            ddlPageSize.Items.Add(new ListItem("1000", "1000"));
        }
        public static void LoadIsActived(ref DropDownList ddlIsActived)
        {
            ddlIsActived.Items.Add(new ListItem("--Is Actived--", "-1"));
            ddlIsActived.Items.Add(new ListItem("Yes", "1"));
            ddlIsActived.Items.Add(new ListItem("No", "0"));
        }
        //ashley do
        public static string buildFilter(string Key, string ColFilter)
        {
            string filter = "";
            //build string Filter           
            if (ColFilter != "-1" && ColFilter != "" && Key != "")
            {
                string[] arrCol = ColFilter.Split('@');
                string[] arrKey = Key.Split('@');

                if (ColFilter.Contains("@"))
                {
                    if (arrCol.Length != arrKey.Length)
                    {
                        throw new ArgumentException("Chieu dai cua key != Chieu dai cua Column Filter");
                    }
                }
                else //Truong hop ColFilter ko co @ --> Key co @ thi phai giu nguyen gia tri @ cua key, vi du Key la: congchien@gmail.com
                {
                    arrKey = new string[] { Key };
                }

                for (int i = 0; i < arrCol.Length; i++)
                {
                    if (arrKey[i] != "")
                        filter += " and " + arrCol[i] + buildKey(arrKey[i]);
                }
            }

            return filter;
        }

        /*
         * public static string buildKey(string Key)
        {
            string Ret = "";
            Key = Key.Trim().Replace('*', '%').Replace("'", "''");  // Prevent sql injection

            if (Key == "-1") Ret = " ='' "; //key = -1 de lay ra gia tri rong
            else
            {                if (Key.Contains("="))
                    Ret = (" = '" + Key.Replace("=", "") + "'");
                else
                    Ret = (" like '%" + Key.Replace("=", "") + "%'");
            }

            return Ret;
        }
         */
        public static string buildKey(string Key)
        {
            string Ret = "";
            Key = Key.Trim().Replace('*', '%').Replace("'", "''");  // Prevent sql injection
            if (Key == "-1") Ret = " ='' "; //key = -1 de lay ra gia tri rong
            else
            {
                if (Key.IndexOf('>') == 0)
                {
                    if (Key.IndexOf('=') == 1)
                        Ret = (" >= '" + Key.Replace(">=", "") + "'");
                    else
                        Ret = (" > '" + Key.Replace(">", "") + "'");
                }
                else if (Key.IndexOf('<') == 0)
                {
                    if (Key.IndexOf('=') == 1)
                        Ret = (" <= '" + Key.Replace("<=", "") + "'");
                    else
                        Ret = (" < '" + Key.Replace("<", "") + "'");
                }

                //Truyen key co gia tri giong mau sau: [in 1,2,3] hoac [in abc,def]
                //chuong trinh tu dong chuyen thanh [ in ('1','2','3') ]
                else if (Key.IndexOf("in ") == 0) //phai co khoang trang dang sau
                {
                    string listVal = Key.Replace("in ", "").Trim().Replace(" , ", ",").Replace(" ,", ",").Replace(", ", ",").Replace(",", "','");

                    Ret = (" in ('" + listVal + "')");
                }
                else if (Key.IndexOf('!') == 0 && Key.IndexOf('=') == 1) // Ashley_so sanh != cho chuoi (vd:Left(LocalSKU,2) !='PF')
                    Ret = (" != '" + Key.Replace("!=", "") + "'");
                else if (Key.IndexOf("=int") == 0) // Ashley_so sanh cua gia tri la so (vd : QOH = 1)
                    Ret = (" = " + Key.Replace("=int", ""));
                else if (Key.IndexOf("begin") == 0) // Ashley_so sanh cua gia tri cho chuoi begin voi ki tu nao do (vd:LocalSKU like 'PF%') 
                    Ret = (" like '" + Key.Replace("begin", "").Replace(" ","") + "%'");
                else if (Key.IndexOf("end") == 0) // Ashley_so sanh cua gia tri cho chuoi ket thuc voi ki tu nao do (vd:LocalSKU like '%PF') 
                    Ret = (" like '%" + Key.Replace("end", "").Replace(" ", "") + "'");
                else if (Key.IndexOf('=') == 0)
                    Ret = (" = '" + Key.Replace("=", "") + "'");
                else if (Key.IndexOf("is null") == 0)
                    Ret = " is null ";
                else
                    Ret = (" like '%" + Key + "%'");
            }

            return Ret;
        }
        public static string buildKey_Date(string DateSearch)
        {
            string Ret = "";
            //Kiem tra ngay hop le hay ko
            if (!Utilities.isDateTime(DateSearch))
                return "='1753-01-01'";  //this is min datetime of sql 1753-01-01, min time of .net is 0001-01-01

            DateSearch = DateSearch.Trim().Replace('*', '%').Replace("'", "''");  // Prevent sql injection

            if (DateSearch == "-1") Ret = " is null "; //key = -1 de lay ra gia tri rong
            else
            {
                if (DateSearch.Contains("="))
                    Ret = (" = '" + DateSearch.Replace("=", "") + "'");
                else
                {
                    DateTime t = Convert.ToDateTime(DateSearch);
                    Ret = " between '" + t.ToShortDateString() + "' and '" + t.AddDays(1).ToShortDateString() + "' ";
                }
            }

            return Ret;
        }

        public static void Cookie_create(string name,string value)
        {
            HttpCookie cookie = new HttpCookie(name, value);
            cookie.Expires = DateTime.Now.AddDays(3);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        public static void Cookie_remove(string name)
        {
            HttpContext.Current.Response.Cookies[name].Expires = DateTime.Now.AddHours(-3);
        }

        public static string ConvertTime_UsToVn(DateTime timeUS)
        {
            return timeUS.AddHours(14).ToString();
        }

        //cookie - ashley
        public static void setCookie(string name, string value)
        {
            //get cookie
            HttpCookie sessionCookieStoreID = HttpContext.Current.Response.Cookies[name];
            if (sessionCookieStoreID != null) { sessionCookieStoreID.Value = value; }
            else
            {
                sessionCookieStoreID = new HttpCookie(name);
                sessionCookieStoreID.Value = value;
                HttpContext.Current.Response.Cookies.Add(sessionCookieStoreID);
            }
            sessionCookieStoreID.Expires = DateTime.Now.AddDays(3);
        }

        public static string HtmlEnCode(string sHtml)
        {
            return HttpContext.Current.Server.HtmlEncode(sHtml);
        }
        public static string HtmlDeCode(string sHtml)
        {
            return HttpContext.Current.Server.HtmlDecode(sHtml);
        }

        public static string GetCloseSiteBool()
        {
            return "1";
        }

        public static string GetCloseSiteMessage()
        {
            return "Website is under construction. we are sorry about this inconvenience";
        }

        public static int GetSchedule_HourDownload()
        {
            return 12;
        }
        public static int GetSchedule_PeriodDownload()
        {
            return 1;
        }

        public static bool IsOnServer()
        {
            bool isOnServer = false;
            string hostname = System.Net.Dns.GetHostName();
            if (hostname == "Hedgewig" || hostname == "Simba" || hostname == "MUFASA")
                isOnServer = true;
            return isOnServer;
        }

        public static bool isLocalHost()
        {
            return HttpContext.Current.Request.IsLocal;
        }
        /// <summary>
        /// Get datatable
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(params string[] columns)
        {
            DataTable dt = new DataTable();

            foreach (string column in columns)
                dt.Columns.Add(column);

            return dt;
        }

        /// <summary>
        /// Get datatable
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(List<string> lstColumn)
        {
            DataTable dt = new DataTable();

            foreach (string column in lstColumn)
            {
                int count = 1;
                while (dt.Columns.Contains(column + count.ToString()))
                {
                    count++;
                }
                if (!dt.Columns.Contains(column))
                    dt.Columns.Add(column);
                else
                    dt.Columns.Add(column + (count++).ToString());
            }

            return dt;
        }

        /// <summary>
        /// Get datatable
        /// </summary>
        /// <param name="totalColumn"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(int totalColumn)
        {
            DataTable dt = new DataTable();
           
                for (int i = 0; i < totalColumn; i++)
                    dt.Columns.Add();
           
            return dt;
        }

        /// <summary>
        /// Add row to datatable
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DataTable AddRowToDataTable(DataTable dt, params string[] values)
        {
            DataTable dtTemp = new DataTable();
          
                dtTemp = dt;
                DataRow row = dtTemp.NewRow();
                for (int i = 0; i < values.Length; i++)
                    row[i] = values[i];
                dtTemp.Rows.Add(row);
          
            return dtTemp;
        }

        /// <summary>
        /// Add row to datatable
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DataTable InsertRowToDataTable(DataTable dt, int index, params string[] values)
        {
            DataTable dtTemp = new DataTable();
          
                dtTemp = dt;
                DataRow row = dtTemp.NewRow();
                for (int i = 0; i < values.Length; i++)
                    row[i] = values[i];
                dtTemp.Rows.InsertAt(row, index);
         
            return dtTemp;
        }

        /// <summary>
        /// Add row to datatable
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DataTable AddRowToDataTable(DataTable dt, List<string> values)
        {
            DataTable dtTemp = new DataTable();
           
                dtTemp = dt;
                DataRow row = dtTemp.NewRow();
                for (int i = 0; i < values.Count; i++)
                    row[i] = values[i];
                dtTemp.Rows.Add(row);
     
            return dtTemp;
        }

        public static void WriteXmlRootNode(string filePath, string rootName)
        {
            XmlTextWriter writer = new XmlTextWriter(filePath, Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.WriteStartElement(rootName);
            writer.WriteEndElement();
            writer.Close();
        }

        /// <summary>
        /// Init file name
        /// </summary>
        /// <param name="originalFileName"></param>
        /// <returns></returns>
        public static string InitDateTimeFileName(string originalFileName)
        {
            return string.Format("{0}_{1}", InitDateTimeName(), originalFileName);
        }
        /// <summary>
        /// Init name by date-time
        /// </summary>
        /// <returns></returns>
        public static string InitDateTimeName()
        {
            DateTime now = DateTime.Now;
            return string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[] { now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, now.Millisecond });
        }

        /// <summary>
        /// Check file valid?
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="allowExtension"></param>
        /// <returns></returns>
        public static bool IsValidFile(string filename, params string[] allowExtension)
        {
            string str = Path.GetExtension(filename).ToLower();
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (str == allowExtension[i])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Clear log entry older than olderThan day
        /// </summary>
        /// <param name="olderThan">in day</param>
        public static void ClearXmlLogEntry(int olderThan, string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlElement elem = doc.GetElementsByTagName("ReportEntries").Item(0) as XmlElement;
            List<XmlElement> oldNodeList = new List<XmlElement>();
            foreach (XmlNode node in elem.ChildNodes)
            {
                XmlElement child = node as XmlElement;
                DateTime date = DateTime.Parse(child.GetAttribute("Date"));
                if (DateTime.Now.Subtract(date).TotalDays > olderThan)
                {
                    oldNodeList.Add(child);
                }
            }
            foreach (XmlElement e in oldNodeList)
            {
                elem.RemoveChild(e);
            }
            doc.Save(filePath);
        }

        public static void ClearLogFile(int olderThan, string filePath)
        {
            DirectoryInfo dir = new DirectoryInfo(filePath);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                // except ProcessLog.xml
                if (DateTime.Now.Subtract(f.LastWriteTime).TotalDays > olderThan)
                    f.Delete();
            }
        }

        public static string[] GetListKey(string filePath)
        {
            string[] keyList = null;
          
                StreamReader reader = new StreamReader(filePath);
                string contenKey = reader.ReadToEnd().Replace("\r", "");
                keyList = contenKey.Split('\n');
          
            return keyList;
        }


        public static void getDateTimeFilter(string filter, out DateTime startDate, out DateTime endDate)
        {
            DateTime localNow = DateTime.Now;
            DateTime fromDate;
            switch (filter.ToUpperInvariant())
            {
                case "TODAY":
                    startDate = new DateTime(localNow.Year, localNow.Month, localNow.Day);
                    endDate = DateTime.MinValue;
                    break;
                case "THISWEEK":
                    //this week
                    DateTime firstDayOfWeek = localNow.AddDays(-1 * (int)localNow.DayOfWeek);
                    startDate = new DateTime(firstDayOfWeek.Year, firstDayOfWeek.Month, firstDayOfWeek.Day);
                    endDate = DateTime.MinValue;
                    break;
                case "LASTWEEK":
                    //last week
                    DateTime firstDayOfLastWeek = localNow.AddDays((-1 * (int)localNow.DayOfWeek) - 7);
                    DateTime lastDayOfLastWeek = firstDayOfLastWeek.AddDays(6);
                    startDate = new DateTime(firstDayOfLastWeek.Year, firstDayOfLastWeek.Month, firstDayOfLastWeek.Day);
                    endDate = new DateTime(lastDayOfLastWeek.Year, lastDayOfLastWeek.Month, lastDayOfLastWeek.Day, 23, 59, 59);
                    break;
                case "THISMONTH":
                    //this month
                    startDate = new DateTime(localNow.Year, localNow.Month, 1);
                    endDate = DateTime.MinValue;
                    break;
                case "LASTMONTH":
                    //last month
                    DateTime lastMonth = localNow.AddMonths(-1);
                    startDate = new DateTime(lastMonth.Year, lastMonth.Month, 1);
                    DateTime lastDayOfLastMonth = new DateTime(localNow.Year, localNow.Month, 1).AddDays(-1);
                    endDate = lastDayOfLastMonth;
                    break;
                case "LAST30":
                    //LAST 30 DAYS
                    fromDate = localNow.AddDays(-30);
                    startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
                    endDate = DateTime.MinValue;
                    break;
                case "LAST60":
                    //LAST 60 DAYS
                    fromDate = localNow.AddDays(-60);
                    startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
                    endDate = DateTime.MinValue;
                    break;
                case "LAST90":
                    //LAST 90 DAYS
                    fromDate = localNow.AddDays(-90);
                    startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
                    endDate = DateTime.MinValue;
                    break;
                case "LAST120":
                    //LAST 120 DAYS
                    fromDate = localNow.AddDays(-120);
                    startDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day);
                    endDate = DateTime.MinValue;
                    break;
                case "THISYEAR":
                    //This Year
                    startDate = new DateTime(localNow.Year, 1, 1);
                    endDate = DateTime.MinValue;
                    break;
                default:
                    //DEFAULT TO ALL DATES
                    startDate = DateTime.MinValue;
                    endDate = DateTime.MinValue;
                    break;
            }
        }

        public static void getDateTimeFilter(string filter, ref string startDate, ref string endDate)
        {
            DateTime today = DateTime.Now;
            switch (filter)
            {
                case "Filter_Today":
                    startDate = today.ToShortDateString();
                    endDate = startDate + " 23:59:59.998";
                    break;

                case "Filter_Yesterday":
                    startDate = today.AddDays(-1).ToShortDateString();
                    endDate = startDate + " 23:59:59.998";
                    break;
                /**EBay Listing**/
                case "Filter_TodayListing":
                    startDate = today.ToShortDateString();
                    endDate = startDate + " 23:59:59.998";
                    break;

                case "Filter_YesterdayListing":
                    startDate = today.AddDays(-1).ToShortDateString();
                    endDate = startDate + " 23:59:59.998";
                    break;
                /*******************/
                case "Filter_Last24h":
                    startDate = today.AddDays(-1).ToString();
                    endDate = today.ToString();
                    break;

                case "Filter_CurrentWeek":
                    int totalDaySubtract = Convert.ToInt32(today.DayOfWeek);
                    startDate = today.AddDays(-totalDaySubtract).ToShortDateString();
                    endDate = today.ToString();
                    break;

                case "Filter_LastWeek":
                    int daySubtract = Convert.ToInt32(today.DayOfWeek);
                    startDate = today.AddDays(-daySubtract - 7).ToShortDateString();
                    endDate = today.AddDays(-daySubtract - 1).ToShortDateString() + " 23:59:59.998";
                    break;

                case "Filter_CurrentMonth":
                    startDate = today.AddDays(-today.Day + 1).ToShortDateString();
                    endDate = today.ToString();
                    break;

                case "Filter_LastMonth":
                    DateTime lastMonth = today.AddMonths(-1);
                    startDate = lastMonth.ToShortDateString();
                    DateTime lastDayOfLastMonth = new DateTime(today.Year, today.Month, 1).AddDays(-1);
                    endDate = lastDayOfLastMonth.ToShortDateString()+ " 23:59:59.998";
                    break;

                default: break;
            }




        }

        public static void DownloadFile(string pathFile, bool forceDownload)
        {

            string name = Path.GetFileName(pathFile);
            string ext = Path.GetExtension(pathFile);
            string type = "";
            // set known types based on file extension  
            if (ext != null)
            {
                switch (ext.ToLower())
                {
                    case ".htm":
                    case ".html":
                        type = "text/HTML";
                        break;
                    case ".xls":
                    case ".xlsx":
                        type = "application/excel";
                        break;
                    case ".txt":
                        type = "application/text";
                        break;
                    case ".doc":
                    case ".docx":
                    case ".rtf":
                        type = "Application/msword";
                        break;
                    case ".tif":
                    case ".tiff":
                        type = "image/tiff";
                        break;
                    case ".jpg":
                    case ".jpeg":
                        type = "image/jpeg";
                        break;
                    case ".gif":
                        type = "image/gif";
                        break;
                    case "pdf":
                        type = "Application/pdf";
                        break;
                    case "png":
                        type = "image/png";
                        break;
                    case "bmp":
                        type = "image/bmp";
                        break;
                    default:
                        type = "application/octet-stream";
                        //type = "application/force-download";
                        break;
                }
            }
            if (forceDownload)
            {
                HttpContext.Current.Response.AppendHeader("content-disposition",
                    "attachment; filename=" + name);
            }
            if (type != "")
                HttpContext.Current.Response.ContentType = type;
            HttpContext.Current.Response.WriteFile(pathFile);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.Close();
        }

        public static void redirectNewWindow(System.Web.UI.Page p, object strURL)
        {
            System.Web.UI.LiteralControl lt = new System.Web.UI.LiteralControl();
            lt.Text = "<script language=\"javascript\" type=\"text/javascript\"> window.open('" + strURL.ToString() + "','Open Window','left=200,top=20,width=1000,height=600,toolbar=1,location=1,directories=yes,status=1,menubar=1,scrollbars=1,copyhistory=1, resizable=1'); return false;</script>";
            p.Header.Controls.Add(lt);
        }

        private static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");


        //public static string EncryptStringAES(string plainText, string sharedSecret)
        //{
        //    if (string.IsNullOrEmpty(plainText))
        //        throw new ArgumentNullException("plainText");
        //    if (string.IsNullOrEmpty(sharedSecret))
        //        throw new ArgumentNullException("sharedSecret");

        //    string outStr = null;                       // Encrypted string to return
        //    RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

        //    try
        //    {
        //        // generate the key from the shared secret and the salt
        //        Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

        //        // Create a RijndaelManaged object
        //        // with the specified key and IV.
        //        aesAlg = new RijndaelManaged();
        //        aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
        //        aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

        //        // Create a decrytor to perform the stream transform.
        //        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        //        // Create the streams used for encryption.
        //        using (MemoryStream msEncrypt = new MemoryStream())
        //        {
        //            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
        //                {

        //                    //Write all data to the stream.
        //                    swEncrypt.Write(plainText);
        //                }
        //            }
        //            outStr = Convert.ToBase64String(msEncrypt.ToArray());
        //        }
        //    }
        //    finally
        //    {
        //        // Clear the RijndaelManaged object.
        //        if (aesAlg != null)
        //            aesAlg.Clear();
        //    }

        //    // Return the encrypted bytes from the memory stream.
        //    return outStr;
        //}


        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            RijndaelManaged aesAlg = null;

            string plaintext = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static int WeekNumber(System.DateTime value)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static DateTime GetFirstDayOfWeek(int year, int weekNumber, System.Globalization.CultureInfo culture)
        {
            System.Globalization.Calendar calendar = culture.Calendar;
            DateTime firstOfYear = new DateTime(year, 1, 1, calendar);
            DateTime targetDay = calendar.AddWeeks(firstOfYear, weekNumber - 1);
            DayOfWeek firstDayOfWeek = culture.DateTimeFormat.FirstDayOfWeek;

            while (targetDay.DayOfWeek != firstDayOfWeek)
            {
                targetDay = targetDay.AddDays(-1);
            }

            return targetDay;
        }

        public static string GetFileNameByDate(DateTime date)
        {
            return string.Format("{0}_{1}_{2}_{3}h_{4}m_{5}s_{6}ms", date.Month, date.Day, date.Year, date.Hour, date.Minute, date.Second, date.Millisecond);
        }

        public static HtmlNode GetHTMLNode(string html)
        {
            try
            {
                HtmlDocument htmlDocument = new HtmlDocument();

                htmlDocument.OptionOutputAsXml = true;
                htmlDocument.OptionOutputOptimizeAttributeValues = true;

                htmlDocument.LoadHtml(html);
                return htmlDocument.DocumentNode;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string ReadXmlValue(string strFileName)
        {
            string strTemp = "";
            StreamReader streamReader = new StreamReader(strFileName);
            strTemp = streamReader.ReadToEnd();
            streamReader.Close();
            return strTemp;
        }

        public static string GetXmlElement(string html, string xPath)
        {
            string xmlElement = string.Empty;
            HtmlNode htmlNode = GetHTMLNode(html); // GetHTMLNode(htmlText);
            HtmlNodeCollection node = htmlNode.SelectNodes(xPath.ToLower());
            if (node != null)
            {
                xmlElement = node[0].InnerText;
            }
            return xmlElement;
        }

        public static HtmlNodeCollection GetXmlElementList(string html, string xPath)
        {          
            HtmlNode htmlNode = GetHTMLNode(html); // GetHTMLNode(htmlText);
            HtmlNodeCollection node = htmlNode.SelectNodes(xPath.ToLower());
            return node;
        }

        public static CookieCollection GetAllCookiesFromHeader(string strHeader, string strHost)
        {
            ArrayList al = new ArrayList();
            CookieCollection cc = new CookieCollection();
            if (strHeader != string.Empty)
            {
                al = ConvertCookieHeaderToArrayList(strHeader);
                cc = ConvertCookieArraysToCookieCollection(al, strHost);
            }
            return cc;
        }

        public static ArrayList ConvertCookieHeaderToArrayList(string strCookHeader)
        {
            strCookHeader = strCookHeader.Replace("\r", "");
            strCookHeader = strCookHeader.Replace("\n", "");
            string[] strCookTemp = strCookHeader.Split(',');
            ArrayList al = new ArrayList();
            int i = 0;
            int n = strCookTemp.Length;
            while (i < n)
            {
                if (strCookTemp[i].IndexOf("expires=", StringComparison.OrdinalIgnoreCase) > 0)
                {
                    al.Add(strCookTemp[i] + "," + strCookTemp[i + 1]);
                    i = i + 1;
                }
                else
                {
                    al.Add(strCookTemp[i]);
                }
                i = i + 1;
            }
            return al;
        }

        public static CookieCollection ConvertCookieArraysToCookieCollection(ArrayList al, string strHost)
        {
            CookieCollection cc = new CookieCollection();

            int alcount = al.Count;
            string strEachCook;
            string[] strEachCookParts;
            for (int i = 0; i < alcount; i++)
            {
                strEachCook = al[i].ToString();
                strEachCookParts = strEachCook.Split(';');
                int intEachCookPartsCount = strEachCookParts.Length;
                string strCNameAndCValue = string.Empty;
                string strPNameAndPValue = string.Empty;
                string strDNameAndDValue = string.Empty;
                string[] NameValuePairTemp;
                Cookie cookTemp = new Cookie();

                for (int j = 0; j < intEachCookPartsCount; j++)
                {
                    if (j == 0)
                    {
                        strCNameAndCValue = strEachCookParts[j];
                        if (strCNameAndCValue != string.Empty)
                        {
                            int firstEqual = strCNameAndCValue.IndexOf("=");
                            string firstName = strCNameAndCValue.Substring(0, firstEqual);
                            string allValue = strCNameAndCValue.Substring(firstEqual + 1, strCNameAndCValue.Length - (firstEqual + 1));
                            cookTemp.Name = firstName;
                            cookTemp.Value = allValue;
                        }
                        continue;
                    }
                    if (strEachCookParts[j].IndexOf("path", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        strPNameAndPValue = strEachCookParts[j];
                        if (strPNameAndPValue != string.Empty)
                        {
                            NameValuePairTemp = strPNameAndPValue.Split('=');
                            if (NameValuePairTemp[1] != string.Empty)
                            {
                                cookTemp.Path = NameValuePairTemp[1];
                            }
                            else
                            {
                                cookTemp.Path = "/";
                            }
                        }
                        continue;
                    }

                    if (strEachCookParts[j].IndexOf("domain", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        strPNameAndPValue = strEachCookParts[j];
                        if (strPNameAndPValue != string.Empty)
                        {
                            NameValuePairTemp = strPNameAndPValue.Split('=');

                            if (NameValuePairTemp[1] != string.Empty)
                            {
                                cookTemp.Domain = NameValuePairTemp[1];
                            }
                            else
                            {
                                cookTemp.Domain = strHost;
                            }
                        }
                        continue;
                    }
                }

                if (cookTemp.Path == string.Empty)
                {
                    cookTemp.Path = "/";
                }
                if (cookTemp.Domain == string.Empty)
                {
                    cookTemp.Domain = strHost;
                }
                cc.Add(cookTemp);
            }
            return cc;
        }

    }
