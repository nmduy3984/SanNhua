using System;
using System.Configuration;

/// <summary>
/// Summary description for StringHelper
/// </summary>

public class StringHelper
    {
        public StringHelper() { }

        public static string getConnectionString = ConfigurationManager.ConnectionStrings["idefloors"].ConnectionString;
     
        public static string getFolderImages = AppDomain.CurrentDomain.BaseDirectory + "Images\\ProductImages\\";

        public static string getFolderCategoryImages = AppDomain.CurrentDomain.BaseDirectory + "Images\\CategoryImages\\";

        public static string getFolderNewImages = AppDomain.CurrentDomain.BaseDirectory + "Images\\News\\";

        public static string getFolderFlashImages = AppDomain.CurrentDomain.BaseDirectory + "Images\\Flash\\";
        public static string getFolderCerImages = AppDomain.CurrentDomain.BaseDirectory + "Images\\Certificate\\";
        public static string getFolderCerFile = AppDomain.CurrentDomain.BaseDirectory + "Images\\PDF\\Certificate\\";

        public static string PageHome = "/Home.aspx";
        public static string PageLogin = "/Admin/Login.aspx";
        public static string PageErrorDenied = "/error/access-denied.html";
        public static string PageErrorPermissionDenied = "/error/permission-denied.html";
        public static string PageErrorIPDenied = "/error/ip-denied.html";

        public static int LoginTimeOut = 120; //minutes

        public static int MaxFileSizeUpload = 4194304; //4194304 Byte = 4 MB

       
    }
