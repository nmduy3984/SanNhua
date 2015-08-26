using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace dbConnection
{
    /// <summary>
    /// A sql database wrapper
    /// </summary>
    public class SqlDatabase : Database
    {
        /// <summary>
        /// Creates a new instance of the sql database wrapper
        /// </summary>
        /// <param name="connectionString">The connection string for the sql database</param>
        public SqlDatabase(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Derives parameters for a stored procedure
        /// </summary>
        /// <param name="discoveryCommand">The command used to derive parameters</param>
        protected override void DeriveParameters(System.Data.Common.DbCommand discoveryCommand)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Creates a connection
        /// </summary>
        /// <returns>A new DbConnection</returns>
        protected override DbConnection DbProviderCreateConnection()
        {
            return new SqlConnection();
        }

        /// <summary>
        /// Creates a command
        /// </summary>
        /// <returns>A new DbCommand</returns>
        protected override DbCommand DbProviderCreateCommand()
        {
            return new SqlCommand();
        }

        /// <summary>
        /// Creates a data adapter
        /// </summary>
        /// <returns>A new DbDataAdapter</returns>
        protected override DbDataAdapter DbProviderCreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        /// <summary>
        /// Creates a parameter
        /// </summary>
        /// <returns>A new DbParameter</returns>
        protected override DbParameter DbProviderCreateParameter()
        {
            return new SqlParameter();
        }
    }
}