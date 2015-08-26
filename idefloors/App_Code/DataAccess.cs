using System.Data;
using System.Data.Common;
using dbConnection;
using System.Web.UI.WebControls;


public class DataAccess
{
    static SqlDatabase db = new SqlDatabase(StringHelper.getConnectionString);

    public static DataTable GetData_Paging(string _TableName, string _PK, string _FieldSelect, string _Filter, string _OrderBy, string Page, string Limit, ref int TotalRows)
    {

        DbCommand cmd = db.GetStoredProcCommand("hw_Paging");
        db.AddInParameter(cmd, "@TableName", DbType.String, _TableName);
        db.AddInParameter(cmd, "@PK", DbType.String, _PK);
        db.AddInParameter(cmd, "@FieldSelect", DbType.String, _FieldSelect);
        db.AddInParameter(cmd, "@Filter", DbType.String, _Filter);
        db.AddInParameter(cmd, "@OrderBy", DbType.String, _OrderBy);
        db.AddInParameter(cmd, "@Page", DbType.String, Page);
        db.AddInParameter(cmd, "@Limit", DbType.String, Limit);
        db.AddOutParameter(cmd, "@TotalRows", DbType.Int32, TotalRows);
        cmd.CommandTimeout = 300;

        DataSet ds = db.ExecuteDataSet(cmd);

        TotalRows = (int)(db.GetParameterValue(cmd, "@TotalRows"));

        db.Dispose();
        return ds.Tables[0];
    }

    public static int GetData_Total(string _TableName, string _PK, string _Filter)
    {
        DbCommand cmd = db.GetStoredProcCommand("hw_GetTotal");
        db.AddInParameter(cmd, "@TableName", DbType.String, _TableName);
        db.AddInParameter(cmd, "@PK", DbType.String, _PK);
        db.AddInParameter(cmd, "@Filter", DbType.String, _Filter);

        DataSet ds = db.ExecuteDataSet(cmd);

        db.Dispose();
        return AlwaysConvert.ToInt(ds.Tables[0].Rows[0][0], 0);

    }

    public static DataTable GetDatatable(string sql)
    {
        DbCommand cmd = db.GetSqlStringCommand(sql);
        DataSet ds = db.ExecuteDataSet(cmd);

        db.Dispose();
        return ds.Tables[0];
    }

    public static int Insert(string sql)
    {
        DbCommand cmd = db.GetSqlStringCommand(sql);

        db.Dispose();
        return db.ExecuteNonQuery(cmd);
    }

    public static int Update(string sql)
    {
        DbCommand cmd = db.GetSqlStringCommand(sql);
        db.Dispose();
        return db.ExecuteNonQuery(cmd);
    }

    public static int Delete(string sql)
    {
        DbCommand cmd = db.GetSqlStringCommand(sql);
        db.Dispose();
        return db.ExecuteNonQuery(cmd);
    }

    public static int Delete(string _TableName, string _PK, string _ListID)
    {
        string sql = "delete from " + _TableName + " where " + _PK + " in(" + _ListID + ")";
        DbCommand cmd = db.GetSqlStringCommand(sql);
        db.Dispose();
        return db.ExecuteNonQuery(cmd);
    }
    public static int UpdateUserDeleted(string _TableNametest, string session, string _PK, string _ListID)
    {
        string sql = "update " + _TableNametest + "  set UserDeleted = " + session + " where " + _PK + " in(" + _ListID + ")";
        DbCommand cmd = db.GetSqlStringCommand(sql);
        db.Dispose();
        return db.ExecuteNonQuery(cmd);
    }
    public static DataTable GetRecord(string tableName)
    {
        string sql = "select * from " + tableName;
        DbCommand cmd = db.GetSqlStringCommand(sql);
        DataSet ds = db.ExecuteDataSet(cmd);
        db.Dispose();
        return ds.Tables[0];
    }
    public static DataTable GetRecord(string tableName, string columnName, string value)
    {
        string sql = "select * from " + tableName + " where " + columnName + "='" + value.Replace("'", "''") + "'";
        DbCommand cmd = db.GetSqlStringCommand(sql);
        DataSet ds = db.ExecuteDataSet(cmd);
        db.Dispose();
        return ds.Tables[0];
    }
    public static DataTable GetRecord(string tableName, string columnName1, string value1, string columnName2, string value2)
    {
        string sql = "select * from " + tableName + " where " + columnName1 + "='" + value1.Replace("'", "''") + "' and " + columnName2 + "='" + value2 + "'";
        DbCommand cmd = db.GetSqlStringCommand(sql);
        DataSet ds = db.ExecuteDataSet(cmd);
        db.Dispose();
        return ds.Tables[0];
    }
    public static DataTable GetRecord(string tableName, string columnName1, string value1, string columnName2, string value2, string columnName3, string value3)
    {
        string sql = "select * from " + tableName + " where " + columnName1 + "='" + value1.Replace("'", "''") + "' and " + columnName2 + "='" + value2.Replace("'", "''") + "' and " + columnName3 + "='" + value3.Replace("'", "''") + "'";
        DbCommand cmd = db.GetSqlStringCommand(sql);
        DataSet ds = db.ExecuteDataSet(cmd);
        db.Dispose();
        return ds.Tables[0];
    }

    public static DataTable getSanPhamTheodanhmuc(string madm, string Page, string Limit, ref int total)
    {
        string _TableName = "Product sp left join Category dm on sp.CategoryID = dm.CategoryID";
        string _PK = "ProductID";
        string _FieldSelect = "sp.*,dm.Name as CategoryName";
        string _Filter = "";
        if (madm != "" && madm != "-1")
            _Filter = " and sp.CategoryID = " + madm;

        return GetData_Paging(_TableName, _PK, _FieldSelect, _Filter, "", Page, Limit, ref total);
    }

    public static DataTable getSanPham(string madm, string tenDM, string Page, string Limit, ref int total)
    {
        string _TableName = "Category";
        string _PK = "CategoryID";
        string _FieldSelect = "*";
        string _Filter = "";
        if (madm != "" && madm != "-1")
            _Filter = " and CategoryID = " + madm;
        if (tenDM != "" && tenDM != "-1")
            _Filter = " and Name = '" + tenDM + "'";

        return GetData_Paging(_TableName, _PK, _FieldSelect, _Filter, "", Page, Limit, ref total);
    }

    public static DataTable getNews(string Id, string Page, string Limit, ref int total)
    {
        string _TableName = "News n";
        string _PK = "Id";
        string _FieldSelect = "n.*";
        string _Filter = "";
        if (Id != "" && Id != "-1")
            _Filter = " n.Id = " + Id;

        return GetData_Paging(_TableName, _PK, _FieldSelect, _Filter, " id desc", Page, Limit, ref total);
    }
    public static DataTable getProjects(string Id, string Page, string Limit, ref int total)
    {
        string _TableName = "Projects n";
        string _PK = "Id";
        string _FieldSelect = "n.*";
        string _Filter = "";
        if (Id != "" && Id != "-1")
            _Filter = " n.Id = " + Id;

        return GetData_Paging(_TableName, _PK, _FieldSelect, _Filter, " Id desc", Page, Limit, ref total);
    }
    public static DataTable get_CategoryTree(string categoryid)
    {
        string sql = @"                           
                            with TableTemp (CategoryID,ParentID,Name, [LevelCount])
                            as
                            (
	                            select CategoryID,ParentID,Name,0 AS [LevelCount]
	                            from dbo.Category
	                            where (ParentID is NULL OR ParentID = 0)
	                            union ALL
	                            select R1.CategoryID, R1.ParentID, R1.Name, [LevelCount]+1 AS [LevelCount]
	                            from dbo.Category as R1
	                            join TableTemp as R2 on R1.ParentID = R2.CategoryID
                            )
                            SELECT * FROM TableTemp 
                            where LevelCount >0
                            ORDER BY LevelCount DESC"
                           ;
        //return GetDatatable(sql);



        sql = @"                           
                            with TableTemp (CategoryID,ParentID, Name, [Level],[Path])
                            as
                            (
	                            select CategoryID,ParentID,Name,0 AS [Level], convert(varchar(1000),'Channels/'+Name) as [Path]
	                            from dbo.rCategory
	                            where (ParentID is NULL OR ParentID = 0)
	                            union ALL
	
	                            select R1.CategoryID, R1.ParentID, R1.Name, [Level]+1 AS [Level],
	
	                            case 
		                            when len(R2.[Path]) > 0 
		                            then convert(varchar(1000),R2.[Path] + '/' + cast(R1.Name as varchar(1000)))
			                        end
		                            else convert(varchar(1000), cast(R1.Name as varchar(1000)) + '/' + cast(R1.Name as varchar(1000)))
	                            end 
	
	                            as [Path]
	
	                            from dbo.Category as R1
	
	                            join TableTemp as R2 on R1.ParentID = R2.CategoryID
                            )
                            SELECT * FROM TableTemp ORDER BY [Path] ASC"
                        ;
        return DataAccess.GetDatatable(sql);
    }

    public static void LoadCategory(ref DropDownList ddlDanhMucCha,string selectvalue)
    {
        string prefix = "|- -";
        ddlDanhMucCha.Items.Add(new ListItem(" - -Root - -", "-1"));
        DataTable dtCat0 = DataAccess.GetRecord("Category", "ParentID", "0");
        foreach (DataRow row0 in dtCat0.Rows)
        {
            prefix = "|- -";
            ddlDanhMucCha.Items.Add(new ListItem(prefix + row0["Name"].ToString(), row0["CategoryID"].ToString()));

            DataTable CategoryLevel1 = new DataTable();
            CategoryLevel1 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(" + row0["CategoryID"].ToString() + ")");
            if (CategoryLevel1.Rows.Count > 0)
            {
                foreach (DataRow row1 in CategoryLevel1.Rows)
                {
                    prefix = "|- - - -";
                    ddlDanhMucCha.Items.Add(new ListItem(prefix + row1["Name"].ToString(), row1["CategoryID"].ToString()));

                    DataTable CategoryLevel2 = new DataTable();
                    CategoryLevel2 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(" + row1["CategoryID"].ToString() + ")");
                    foreach (DataRow row2 in CategoryLevel2.Rows)
                    {
                        prefix = "|- - - - - -";
                        ddlDanhMucCha.Items.Add(new ListItem(prefix + row2["Name"].ToString(), row2["CategoryID"].ToString()));

                        DataTable CategoryLevel3 = new DataTable();
                        CategoryLevel3 = DataAccess.GetDatatable("select * from fnGetAllChildHaveFilter(" + row2["CategoryID"].ToString() + ")");
                        foreach (DataRow row3 in CategoryLevel3.Rows)
                        {
                            prefix = "|- - - - - - - -";
                            ddlDanhMucCha.Items.Add(new ListItem(prefix + row3["Name"].ToString(), row3["CategoryID"].ToString()));
                        }
                    }
                }
            }
        }
        ddlDanhMucCha.SelectedValue = selectvalue;
    }

   
}

