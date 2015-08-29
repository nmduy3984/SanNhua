
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Web;

namespace dbConnection
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Database
    {
        /// <summary>
        /// The default timeout value assigned to sql queries
        /// </summary>
        private const int SqlCommandTimeoutDefault = 120;

        /// <summary>
        /// The maximum timeout value that can be assigned to sql queries
        /// </summary>
        private const int SqlCommandTimeoutMax = 600;

        /// <summary>
        /// Private storage for the database-specific connection implementation
        /// </summary>
        private DbConnection _Connection;

        /// <summary>
        /// Private storage for the connection string
        /// </summary>
        private string _ConnectionString;

        /// <summary>
        /// Private storage for the connection string
        /// </summary>
        private string _ConnectionStringNoCredentials;

        /// <summary>
        /// Timeout to apply to commands run on the connection
        /// </summary>
        private int _CommandTimeout;

        /// <summary>
        /// Private storage for the current transaction queue
        /// </summary>
        private List<DbTransaction> _Transactions;

        /// <summary>
        /// Private storage for a flag that tells whether the connection should be closed when all
        /// pending transactions are committed
        /// </summary>
        private bool _CloseConnectionOnCommit = false;

#if (DEBUG)
        /// <summary>
        /// The sql logger
        /// </summary>
        private SqlLogger logger;
#endif

        private Database() { }

        /// <summary>
        /// Creates a new instance of GenericDatabase class with the given connection string.
        /// </summary>
        /// <param name="connectionString">Connection string used to initialize the database</param>
        protected Database(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("The value can not be null or an empty string", "connectionString");
            }

            // INITIALIZE THE CONNECTION OBJECT
            _Connection = this.DbProviderCreateConnection();
            _Connection.ConnectionString = connectionString;
            _ConnectionString = connectionString;
            _ConnectionStringNoCredentials = _Connection.ConnectionString;
            _Transactions = new List<DbTransaction>();
#if (DEBUG)
            logger = SqlLogger.Instance;
            logger.Append("***** DATABASE INSTANCE INITIALIZED *****");
            TraceWrite("Database", "Database Instance Initialized");
#endif

            // CONFIGURE THE COMMAND TIMEOUT In AppSetting, if null then get default value
            string commandTimeout = ConfigurationManager.AppSettings["AbleCommerce:SqlCommandTimeout"];
            if (!string.IsNullOrEmpty(commandTimeout))
            {
                try
                {
                    _CommandTimeout = Convert.ToInt32(commandTimeout);
                }
                catch
                {
                    _CommandTimeout = SqlCommandTimeoutDefault;
                }
                if (_CommandTimeout < 1) _CommandTimeout = SqlCommandTimeoutDefault;
                if (_CommandTimeout > SqlCommandTimeoutMax) _CommandTimeout = SqlCommandTimeoutMax;
            }
            else
            {
                _CommandTimeout = SqlCommandTimeoutDefault;
            }
        }

        /// <summary>
        /// Adds a new instance of a <see cref="DbParameter"/> object to the command.
        /// </summary>
        /// <param name="command">The command to add the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        public void AddInParameter(DbCommand command, string name, DbType dbType)
        {
            this.AddParameter(command, name, dbType, ParameterDirection.Input, string.Empty, DataRowVersion.Default, null);
        }

        /// <summary>
        /// Adds a new instance of a <see cref="DbParameter"/> object to the command.
        /// </summary>
        /// <param name="command">The command to add the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        /// <param name="value">The value of the parameter.</param>
        public void AddInParameter(DbCommand command, string name, DbType dbType, object value)
        {
            this.AddParameter(command, name, dbType, ParameterDirection.Input, string.Empty, DataRowVersion.Default, value);
        }

        /// <summary>
        /// Adds a new instance of a <see cref="DbParameter"/> object to the command.
        /// </summary>
        /// <param name="command">The command to add the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        /// <param name="sourceColumn">The name of the source column mapped to the DataSet and used for loading or returning the <paramref name="value"/>.</param>
        /// <param name="sourceVersion">One of the <see cref="DataRowVersion"/> values.</param>
        public void AddInParameter(DbCommand command, string name, DbType dbType, string sourceColumn, DataRowVersion sourceVersion)
        {
            this.AddParameter(command, name, dbType, 0, ParameterDirection.Input, true, 0, 0, sourceColumn, sourceVersion, null);
        }

        /// <summary>
        /// Adds a new instance of a <see cref="DbParameter"/> object to the command.
        /// </summary>
        /// <param name="command">The command to add the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        /// <param name="size">The maximum size of the data within the column.</param>
        public void AddOutParameter(DbCommand command, string name, DbType dbType, int size)
        {
            this.AddParameter(command, name, dbType, size, ParameterDirection.Output, true, 0, 0, string.Empty, DataRowVersion.Default, DBNull.Value);
        }

        /// <summary>
        /// Adds a new instance of a <see cref="DbParameter"/> object to the command.
        /// </summary>
        /// <param name="command">The command to add the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        /// <param name="direction">One of the <see cref="ParameterDirection"/> values.</param>
        /// <param name="sourceColumn">The name of the source column mapped to the DataSet and used for loading or returning the <paramref name="value"/>.</param>
        /// <param name="sourceVersion">One of the <see cref="DataRowVersion"/> values.</param>
        /// <param name="value">The value of the parameter.</param>
        public void AddParameter(DbCommand command, string name, DbType dbType, ParameterDirection direction, string sourceColumn, DataRowVersion sourceVersion, object value)
        {
            this.AddParameter(command, name, dbType, 0, direction, false, 0, 0, sourceColumn, sourceVersion, value);
        }

        /// <summary>
        /// Adds a new instance of a <see cref="DbParameter"/> object to the command.
        /// </summary>
        /// <param name="command">The command to add the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        /// <param name="size">The maximum size of the data within the column.</param>
        /// <param name="direction">One of the <see cref="ParameterDirection"/> values.</param>
        /// <param name="nullable">A value indicating whether the parameter accepts <see langword="null"/> (<b>Nothing</b> in Visual Basic) values.</param>
        /// <param name="precision">The maximum number of digits used to represent the <paramref name="value"/>.</param>
        /// <param name="scale">The number of decimal places to which <paramref name="value"/> is resolved.</param>
        /// <param name="sourceColumn">The name of the source column mapped to the DataSet and used for loading or returning the <paramref name="value"/>.</param>
        /// <param name="sourceVersion">One of the <see cref="DataRowVersion"/> values.</param>
        /// <param name="value">The value of the parameter.</param>
        public virtual void AddParameter(DbCommand command, string name, DbType dbType, int size, ParameterDirection direction, bool nullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value)
        {
            DbParameter parameter = this.CreateParameter(name, dbType, size, direction, nullable, precision, scale, sourceColumn, sourceVersion, value);
            command.Parameters.Add(parameter);
        }

        private void AssignParameterValues(DbCommand command, object[] values)
        {
            int num = this.UserParametersStartIndex();
            for (int i = 0; i < values.Length; i++)
            {
                IDataParameter parameter = command.Parameters[i + num];
                this.SetParameterValue(command, parameter.ParameterName, values[i]);
            }
        }

        private DbTransaction BeginTransaction(DbConnection connection)
        {
            return connection.BeginTransaction();
        }

        /// <summary>
        /// Begins a transaction
        /// </summary>
        /// <param name="isolationLevel"></param>
        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            // IF THERE ARE NO OPEN TRANSACTIONS, DETERMINE IF THE CONNECTION SHOULD BE CLOSED ON COMMIT
            if (_Transactions.Count == 0)
                _CloseConnectionOnCommit = !this.HasPersistentConnection;
            //NOW MAKE SURE WE HAVE A VALID OPEN CONNECTION FOR TRANSACTION
            this.OpenPersistentConnection();
            //BEGIN THE TRANSACTION
            _Transactions.Add(_Connection.BeginTransaction(isolationLevel));
        }

        /// <summary>
        /// Returns the formatted parameter name
        /// </summary>
        /// <param name="name">The parameter name</param>
        /// <returns>The parameter name formatted for the implemented database.</returns>
        public virtual string BuildParameterName(string name)
        {
            return name;
        }

        /// <summary>
        /// Clears the parameter cache
        /// </summary>
        public static void ClearParameterCache()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Closes the connection associated with this instance
        /// </summary>
        public void ClosePersistentConnection()
        {
            RollBackAllTransactions();
            if (this.HasPersistentConnection)
            {
                try
                {
                    _Connection.Close();
                }
                catch { }
            }
        }

        /// <summary>
        /// Commits the transaction most recently initiated
        /// </summary>
        public void CommitTransaction()
        {
            if (_Transactions.Count > 0)
            {
                int currentTransactionIndex = _Transactions.Count - 1;
                DbTransaction currentTransaction = _Transactions[currentTransactionIndex];
                _Transactions.RemoveAt(currentTransactionIndex);
                try
                {
                    currentTransaction.Commit();
                }
                finally
                {
                    currentTransaction.Dispose();
                }
                if (_Transactions.Count == 0 && _CloseConnectionOnCommit) this.ClosePersistentConnection();
            }
        }

        private void CommitTransaction(DbTransaction tran)
        {
            tran.Commit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dbType">One of the <see cref="DbType"/> values.</param>
        /// <param name="size">The maximum size of the data within the column.</param>
        /// <param name="direction">One of the <see cref="ParameterDirection"/> values.</param>
        /// <param name="nullable">A value indicating whether the parameter accepts <see langword="null"/> (<b>Nothing</b> in Visual Basic) values.</param>
        /// <param name="precision">The maximum number of digits used to represent the <paramref name="value"/>.</param>
        /// <param name="scale">The number of decimal places to which <paramref name="value"/> is resolved.</param>
        /// <param name="sourceColumn">The name of the source column mapped to the DataSet and used for loading or returning the <paramref name="value"/>.</param>
        /// <param name="sourceVersion">One of the <see cref="DataRowVersion"/> values.</param>
        /// <param name="value">The value of the parameter.</param>
        protected virtual void ConfigureParameter(DbParameter param, string name, DbType dbType, int size, ParameterDirection direction, bool nullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value)
        {
            param.DbType = dbType;
            param.Size = size;
            param.Value = (value == null) ? DBNull.Value : value;
            param.Direction = direction;
            param.IsNullable = nullable;
            param.SourceColumn = sourceColumn;
            param.SourceVersion = sourceVersion;
        }

        private DbCommand CreateCommandByCommandType(CommandType commandType, string commandText)
        {
            DbCommand command = this.DbProviderCreateCommand();
            command.CommandType = commandType;
            command.CommandText = commandText;
            command.CommandTimeout = _CommandTimeout;
            return command;
        }

        /// <summary>
        /// Creates a connection
        /// </summary>
        /// <returns>A new DbConnection</returns>
        public DbConnection CreateConnection()
        {
            DbConnection connection = this.DbProviderCreateConnection();
            connection.ConnectionString = this.ConnectionString;
            return connection;
        }

        /// <summary>
        /// Creates a parameter with the given name
        /// </summary>
        /// <param name="name">The parameter name</param>
        /// <returns>A new DbParameter</returns>
        protected DbParameter CreateParameter(string name)
        {
            DbParameter parameter = this.DbProviderCreateParameter();
            parameter.ParameterName = this.BuildParameterName(name);
            return parameter;
        }

        /// <summary>
        /// Creates a parameter with the given properties
        /// </summary>
        /// <param name="name">The parameter name</param>
        /// <param name="dbType">The parameter type</param>
        /// <param name="size">The parameter size</param>
        /// <param name="direction">Flag indicating if the parameter is input or output</param>
        /// <param name="nullable">Flag indicating if the parameter is nullable</param>
        /// <param name="precision">Parameter precision</param>
        /// <param name="scale">Parameter scale</param>
        /// <param name="sourceColumn">Source column</param>
        /// <param name="sourceVersion">Source version</param>
        /// <param name="value">Value of the parameter</param>
        /// <returns>The new DbParameter</returns>
        protected DbParameter CreateParameter(string name, DbType dbType, int size, ParameterDirection direction, bool nullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value)
        {
            DbParameter param = this.CreateParameter(name);
            this.ConfigureParameter(param, name, dbType, size, direction, nullable, precision, scale, sourceColumn, sourceVersion, value);
            return param;
        }

        /// <summary>
        /// Creates a connection
        /// </summary>
        /// <returns>A new DbConnection</returns>
        protected abstract DbConnection DbProviderCreateConnection();

        /// <summary>
        /// Creates a command
        /// </summary>
        /// <returns>A new DbCommand</returns>
        protected abstract DbCommand DbProviderCreateCommand();

        /// <summary>
        /// Creates a data adapter
        /// </summary>
        /// <returns>A new DbDataAdapter</returns>
        protected abstract DbDataAdapter DbProviderCreateDataAdapter();

        /// <summary>
        /// Creates a parameter
        /// </summary>
        /// <returns>A new DbParameter</returns>
        protected abstract DbParameter DbProviderCreateParameter();

        /// <summary>
        /// Derives parameters for a stored procedure
        /// </summary>
        /// <param name="discoveryCommand">The command used to derive parameters</param>
        protected abstract void DeriveParameters(DbCommand discoveryCommand);

        /// <summary>
        /// Discovers parameters for a stored procedure
        /// </summary>
        /// <param name="command">The command used to discover parameters</param>
        public void DiscoverParameters(DbCommand command)
        {
            using (DbConnection connection = this.OpenConnection())
            {
                using (DbCommand command2 = this.CreateCommandByCommandType(command.CommandType, command.CommandText))
                {
                    command2.Connection = connection;
                    this.DeriveParameters(command2);
                    foreach (IDataParameter parameter in command2.Parameters)
                    {
                        IDataParameter parameter2 = (IDataParameter)((ICloneable)parameter).Clone();
                        command.Parameters.Add(parameter2);
                    }
                }
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <returns>The number of records affected by the query.</returns>
        private int DoExecuteNonQuery(DbCommand command)
        {
            int result;
            try
            {
#if (DEBUG)
                logger.Append("ExecuteNonQuery|" + GetCommandLogString(command));
                TraceWrite("ExecuteNonQuery", "Executing Command...");
#endif
                result = command.ExecuteNonQuery();
#if (DEBUG)
                TraceWrite("ExecuteNonQuery", GetCommandLogString(command));
#endif
            }
            catch (Exception exception)
            {
                this.FireCommandFailedEvent(command.CommandText, command.Connection.ConnectionString, exception);
                throw;
            }
            return result;
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="behavior">One of the <see cref="System.Data.CommandBehavior"/> values.</param>
        /// <returns>Result returned by the database engine.</returns>
        private IDataReader DoExecuteReader(DbCommand command, CommandBehavior behavior)
        {
            IDataReader reader;
            try
            {
#if (DEBUG)
                logger.Append("ExecuteReader|" + GetCommandLogString(command));
                TraceWrite("ExecuteReader", "Executing Command...");
#endif
                reader = command.ExecuteReader(behavior);
#if (DEBUG)
                TraceWrite("ExecuteReader", GetCommandLogString(command));
#endif
            }
            catch (Exception exception)
            {
                this.FireCommandFailedEvent(command.CommandText, this.ConnectionString, exception);
                throw;
            }
            return reader;
        }

        /// <summary>
        /// <summary>Executes the specified command against the current connection.</summary>
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <returns>Result returned by the database engine.</returns>
        private object DoExecuteScalar(DbCommand command)
        {
            object result;
            try
            {
#if (DEBUG)
                logger.Append("ExecuteScalar|" + GetCommandLogString(command));
                TraceWrite("ExecuteScalar", "Executing Command...");
#endif
                result = command.ExecuteScalar();
#if (DEBUG)
                TraceWrite("ExecuteScalar", GetCommandLogString(command));
#endif
            }
            catch (Exception exception)
            {
                this.FireCommandFailedEvent(command.CommandText, this.ConnectionString, exception);
                throw;
            }
            return result;
        }

        private void DoLoadDataSet(DbCommand command, DataSet dataSet, string[] tableNames)
        {
            if (tableNames == null)
            {
                throw new ArgumentNullException("tableNames");
            }
            if (tableNames.Length == 0)
            {
                throw new ArgumentException("The table name array used to map results to user-specified table names cannot be empty", "tableNames");
            }
            for (int i = 0; i < tableNames.Length; i++)
            {
                if (string.IsNullOrEmpty(tableNames[i]))
                {
                    throw new ArgumentException("The value can not be null or an empty string", "tableNames[" + i + "]");
                }
            }
            using (DbDataAdapter adapter = this.GetDataAdapter(UpdateBehavior.Standard))
            {
                ((IDbDataAdapter)adapter).SelectCommand = command;
                try
                {
                    string str = "Table";
                    for (int j = 0; j < tableNames.Length; j++)
                    {
                        string sourceTable = (j == 0) ? str : (str + j);
                        adapter.TableMappings.Add(sourceTable, tableNames[j]);
                    }
#if (DEBUG)
                    logger.Append("LoadDataSet|" + GetCommandLogString(command));
                    TraceWrite("LoadDataSet", "Executing Command...");
#endif
                    adapter.Fill(dataSet);
#if (DEBUG)
                    TraceWrite("LoadDataSet", GetCommandLogString(command));
#endif
                }
                catch (Exception exception)
                {
                    this.FireCommandFailedEvent(command.CommandText, this.ConnectionStringNoCredentials, exception);
                    throw;
                }
            }
        }

        private int DoUpdateDataSet(UpdateBehavior behavior, DataSet dataSet, string tableName, DbCommand insertCommand, DbCommand updateCommand, DbCommand deleteCommand)
        {
            int result;
            if (string.IsNullOrEmpty(tableName))
            {
                throw new ArgumentException("The value can not be null or an empty string", "tableName");
            }
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (((insertCommand == null) && (updateCommand == null)) && (deleteCommand == null))
            {
                throw new ArgumentException("At least one command must be initialized");
            }
            using (DbDataAdapter adapter = this.GetDataAdapter(behavior))
            {
                if (insertCommand != null)
                {
                    adapter.InsertCommand = insertCommand;
                }
                if (updateCommand != null)
                {
                    adapter.UpdateCommand = updateCommand;
                }
                if (deleteCommand != null)
                {
                    adapter.DeleteCommand = deleteCommand;
                }
                try
                {
                    result = adapter.Update(dataSet.Tables[tableName]);
                }
                catch (Exception exception)
                {
                    this.FireCommandFailedEvent("DbDataAdapter.Update() " + tableName, this.ConnectionStringNoCredentials, exception);
                    throw;
                }
            }
            return result;
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <returns>Result returned by the database engine.</returns>
        public virtual DataSet ExecuteDataSet(DbCommand command)
        {
            DataSet dataSet = new DataSet();
            dataSet.Locale = CultureInfo.InvariantCulture;
            this.LoadDataSet(command, dataSet, "Table");
            return dataSet;
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>The resulting dataset</returns>
        public virtual DataSet ExecuteDataSet(CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteDataSet(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <returns>Result returned by the database engine.</returns>
        public virtual DataSet ExecuteDataSet(DbCommand command, DbTransaction transaction)
        {
            DataSet dataSet = new DataSet();
            dataSet.Locale = CultureInfo.InvariantCulture;
            this.LoadDataSet(command, dataSet, "Table", transaction);
            return dataSet;
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>Result returned by the database engine.</returns>
        public virtual DataSet ExecuteDataSet(string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteDataSet(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>Result returned by the database engine.</returns>
        public virtual DataSet ExecuteDataSet(DbTransaction transaction, CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteDataSet(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>Result returned by the database engine.</returns>
        public virtual DataSet ExecuteDataSet(DbTransaction transaction, string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteDataSet(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <returns>Number of records affected by the query.</returns>
        public virtual int ExecuteNonQuery(DbCommand command)
        {
            if (this.HasPersistentConnection)
            {
                PrepareCommand(command, _Connection, GetCurrentTransaction());
                return this.DoExecuteNonQuery(command);
            }
            else
            {
                using (DbConnection connection = this.OpenConnection())
                {
                    PrepareCommand(command, connection);
                    return this.DoExecuteNonQuery(command);
                }
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>Number of records affected by the query.</returns>
        public virtual int ExecuteNonQuery(CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteNonQuery(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <returns>Number of records affected by the query.</returns>
        public virtual int ExecuteNonQuery(DbCommand command, DbTransaction transaction)
        {
            PrepareCommand(command, transaction);
            return this.DoExecuteNonQuery(command);
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>Number of records affected by the query.</returns>
        public virtual int ExecuteNonQuery(string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteNonQuery(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>Number of records affected by the query.</returns>
        public virtual int ExecuteNonQuery(DbTransaction transaction, CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteNonQuery(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>Number of records affected by the query.</returns>
        public virtual int ExecuteNonQuery(DbTransaction transaction, string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteNonQuery(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <returns>An IDataReader with the results of the command.</returns>
        public virtual IDataReader ExecuteReader(DbCommand command)
        {
            IDataReader reader;
            if (this.HasPersistentConnection)
            {
                PrepareCommand(command, _Connection, GetCurrentTransaction());
                reader = this.DoExecuteReader(command, CommandBehavior.Default);
            }
            else
            {
                DbConnection connection = this.OpenConnection();
                PrepareCommand(command, connection);
                try
                {
                    reader = this.DoExecuteReader(command, CommandBehavior.CloseConnection);
                }
                catch
                {
                    connection.Close();
                    throw;
                }
            }
            return reader;
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>An IDataReader with the results of the command.</returns>
        public IDataReader ExecuteReader(CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteReader(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <returns>An IDataReader with the results of the command.</returns>
        public virtual IDataReader ExecuteReader(DbCommand command, DbTransaction transaction)
        {
            PrepareCommand(command, transaction);
            return this.DoExecuteReader(command, CommandBehavior.Default);
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>An IDataReader with the results of the command.</returns>
        public IDataReader ExecuteReader(string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteReader(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>An IDataReader with the results of the command.</returns>
        public IDataReader ExecuteReader(DbTransaction transaction, CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteReader(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>An IDataReader with the results of the command.</returns>
        public IDataReader ExecuteReader(DbTransaction transaction, string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteReader(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <returns>The result of the command.</returns>
        public virtual object ExecuteScalar(DbCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (this.HasPersistentConnection)
            {
                PrepareCommand(command, _Connection, GetCurrentTransaction());
                return this.DoExecuteScalar(command);
            }
            else
            {
                using (DbConnection connection = this.OpenConnection())
                {
                    PrepareCommand(command, connection);
                    return this.DoExecuteScalar(command);
                }
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>The result of the command.</returns>
        public virtual object ExecuteScalar(CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteScalar(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <returns>The result of the command.</returns>
        public virtual object ExecuteScalar(DbCommand command, DbTransaction transaction)
        {
            PrepareCommand(command, transaction);
            return this.DoExecuteScalar(command);
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>The result of the command.</returns>
        public virtual object ExecuteScalar(string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteScalar(command);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <returns>The result of the command.</returns>
        public virtual object ExecuteScalar(DbTransaction transaction, CommandType commandType, string commandText)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                return this.ExecuteScalar(command, transaction);
            }
        }

        /// <summary>
        /// Executes the specified command against the current connection.
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="storedProcedureName">Stored procedure name</param>
        /// <param name="parameterValues">Array of parameter values</param>
        /// <returns>The result of the command.</returns>
        public virtual object ExecuteScalar(DbTransaction transaction, string storedProcedureName, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                return this.ExecuteScalar(command, transaction);
            }
        }

        private void FireCommandFailedEvent(string errorText, string connectionString, Exception ex)
        {
#if (DEBUG)
            logger.Append(errorText);
            TraceWrite("Database", errorText);
#endif
            Logger.Warn(errorText, ex);
        }

        private void FireConnectionFailedEvent(string errorText, Exception ex)
        {
#if (DEBUG)
            logger.Append(errorText);
            TraceWrite("Database", errorText);
#endif
        }

#if (DEBUG)
        private static string GetCommandLogString(DbCommand command)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(command.CommandText);
            foreach (DbParameter param in command.Parameters)
            {
                sb.Append("|" + param.ParameterName + "=");
                sb.Append(param.Value.ToString());
            }
            return sb.ToString();
        }

        private static void TraceWrite(string category, string message)
        {
            if (HttpContext.Current != null)
            {
                HttpContext.Current.Trace.Write(category, message);
            }
        }
#endif

        /// <summary>
        /// Gets the current transaction
        /// </summary>
        /// <returns>The current transaction, or null if none exists.</returns>
        protected DbTransaction GetCurrentTransaction()
        {
            int transactionCount = _Transactions.Count;
            if (transactionCount > 0) return _Transactions[transactionCount - 1];
            return null;
        }

        /// <summary>
        /// Gets a data adapter
        /// </summary>
        /// <returns>A new DbDataAdapter</returns>
        public DbDataAdapter GetDataAdapter()
        {
            return this.GetDataAdapter(UpdateBehavior.Standard);
        }

        /// <summary>
        /// Gets a data adapter with the specified update behavior
        /// </summary>
        /// <param name="updateBehavior">The update behavior</param>
        /// <returns>A new DbDataAdapter</returns>
        protected DbDataAdapter GetDataAdapter(UpdateBehavior updateBehavior)
        {
            DbDataAdapter adapter = this.DbProviderCreateDataAdapter();
            if (updateBehavior == UpdateBehavior.Continue)
            {
                this.SetUpRowUpdatedEvent(adapter);
            }
            return adapter;
        }

        /// <summary>
        /// Gets the value of the parameter
        /// </summary>
        /// <param name="command">The command</param>
        /// <param name="name">The parameter name</param>
        /// <returns>The value of the parameter</returns>
        public virtual object GetParameterValue(DbCommand command, string name)
        {
            return command.Parameters[this.BuildParameterName(name)].Value;
        }

        /// <summary>Gets a DbCommand object with the specified <see cref="DbCommand.CommandText"/>.</summary>
        /// <param name="query">The SQL query.</param>
        /// <returns>A DbCommand object with the specified <see cref="DbCommand.CommandText"/>.</returns>
        public DbCommand GetSqlStringCommand(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentException("The value can not be null or an empty string", "query");
            }
            return this.CreateCommandByCommandType(CommandType.Text, query);
        }

        /// <summary>
        /// Gets a DbCommand object for the specified Stored Procedure.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure.</param>
        /// <returns>A DbCommand object for the specified Stored Procedure.</returns>
        public virtual DbCommand GetStoredProcCommand(string storedProcedureName)
        {
            if (string.IsNullOrEmpty(storedProcedureName))
            {
                throw new ArgumentException("The value can not be null or an empty string", "storedProcedureName");
            }
            return this.CreateCommandByCommandType(CommandType.StoredProcedure, storedProcedureName);
        }

        /// <summary>
        /// Gets a DbCommand object for the specified Stored Procedure.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure.</param>
        /// <param name="parameterValues">Parameter values for the stored procedure command.</param>
        /// <returns>A DbCommand object for the specified Stored Procedure.</returns>
        public virtual DbCommand GetStoredProcCommand(string storedProcedureName, params object[] parameterValues)
        {
            //TODO: ParameterCache
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Gets a DbCommand object for the specified Stored Procedure.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure.</param>
        /// <param name="sourceColumns"></param>
        /// <returns>A DbCommand object for the specified Stored Procedure.</returns>
        public DbCommand GetStoredProcCommandWithSourceColumns(string storedProcedureName, params string[] sourceColumns)
        {
            if (string.IsNullOrEmpty(storedProcedureName))
            {
                throw new ArgumentException("The value can not be null or an empty string", "storedProcedureName");
            }
            if (sourceColumns == null)
            {
                throw new ArgumentNullException("sourceColumns");
            }
            DbCommand storedProcCommand = this.GetStoredProcCommand(storedProcedureName);
            using (DbConnection connection = this.CreateConnection())
            {
                storedProcCommand.Connection = connection;
                this.DiscoverParameters(storedProcCommand);
            }
            int index = 0;
            foreach (IDataParameter parameter in storedProcCommand.Parameters)
            {
                if ((parameter.Direction == ParameterDirection.Input) | (parameter.Direction == ParameterDirection.InputOutput))
                {
                    parameter.SourceColumn = sourceColumns[index];
                    index++;
                }
            }
            return storedProcCommand;
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="command">DbCommand to execute against the connection</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableName">Name of the dataset table</param>
        public virtual void LoadDataSet(DbCommand command, DataSet dataSet, string tableName)
        {
            this.LoadDataSet(command, dataSet, new string[] { tableName });
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="command">DbCommand to execute against the connection</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableNames">Names of the dataset table</param>
        public virtual void LoadDataSet(DbCommand command, DataSet dataSet, string[] tableNames)
        {
            using (DbConnection connection = this.CreateConnection())
            {
                PrepareCommand(command, connection);
                this.DoLoadDataSet(command, dataSet, tableNames);
            }
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableNames">Names of the dataset table</param>
        public virtual void LoadDataSet(CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                this.LoadDataSet(command, dataSet, tableNames);
            }
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="command">DbCommand to execute against the connection</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableName">Name of the dataset table</param>
        /// <param name="transaction">The transaction context for the command.</param>
        public virtual void LoadDataSet(DbCommand command, DataSet dataSet, string tableName, DbTransaction transaction)
        {
            this.LoadDataSet(command, dataSet, new string[] { tableName }, transaction);
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="command">DbCommand to execute against the connection</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableNames">Names for the dataset tables</param>
        /// <param name="transaction">The transaction context for the command.</param>
        public virtual void LoadDataSet(DbCommand command, DataSet dataSet, string[] tableNames, DbTransaction transaction)
        {
            PrepareCommand(command, transaction);
            this.DoLoadDataSet(command, dataSet, tableNames);
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="storedProcedureName">Name of the stored procedure</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableNames">Names for the dataset tables</param>
        /// <param name="parameterValues">Array of prameter values</param>
        public virtual void LoadDataSet(string storedProcedureName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                this.LoadDataSet(command, dataSet, tableNames);
            }
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="commandType">The command type.</param>
        /// <param name="commandText">The command text.</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableNames">Names for the dataset tables</param>
        public void LoadDataSet(DbTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
        {
            using (DbCommand command = this.CreateCommandByCommandType(commandType, commandText))
            {
                this.LoadDataSet(command, dataSet, tableNames, transaction);
            }
        }

        /// <summary>
        /// Loads the dataset
        /// </summary>
        /// <param name="transaction">The transaction context for the command.</param>
        /// <param name="storedProcedureName">Name of the stored procedure</param>
        /// <param name="dataSet">Target dataset to be loaded</param>
        /// <param name="tableNames">Names for the dataset tables</param>
        /// <param name="parameterValues">Array of prameter values</param>
        public virtual void LoadDataSet(DbTransaction transaction, string storedProcedureName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
        {
            using (DbCommand command = this.GetStoredProcCommand(storedProcedureName, parameterValues))
            {
                this.LoadDataSet(command, dataSet, tableNames, transaction);
            }
        }

        /// <summary>
        /// Establishes a connection for this database instance
        /// </summary>
        public virtual void OpenPersistentConnection()
        {
            if (!this.HasPersistentConnection)
                _Connection = OpenConnection();
        }

        /// <summary>
        /// Creates and opens a new connection
        /// </summary>
        /// <returns></returns>
        protected DbConnection OpenConnection()
        {
            DbConnection connection = null;
            try
            {
                try
                {
                    connection = this.CreateConnection();
                    connection.Open();
                }
                catch (Exception exception)
                {
                    this.FireConnectionFailedEvent(this.ConnectionStringNoCredentials, exception);
                    throw;
                }
            }
            catch
            {
                if (connection != null)
                {
                    connection.Close();
                }
                throw;
            }
            return connection;
        }

        /// <summary>
        /// Prepares the command
        /// </summary>
        /// <param name="command">The DbCommand</param>
        /// <param name="connection">The connection to apply to the command</param>
        protected static void PrepareCommand(DbCommand command, DbConnection connection)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }
            command.Connection = connection;
        }

        /// <summary>
        /// Prepares the command
        /// </summary>
        /// <param name="command">The DbCommand</param>
        /// <param name="transaction">The transaction to apply to the command</param>
        protected static void PrepareCommand(DbCommand command, DbTransaction transaction)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (transaction == null)
            {
                throw new ArgumentNullException("transaction");
            }
            PrepareCommand(command, transaction.Connection);
            command.Transaction = transaction;
        }

        /// <summary>
        /// Prepares the command using the specified connection or transaction
        /// </summary>
        /// <param name="command">The command</param>
        /// <param name="connection">The db connection</param>
        /// <param name="transaction">The transaction, can be null for no transaction</param>
        private static void PrepareCommand(DbCommand command, DbConnection connection, DbTransaction transaction)
        {
            if (transaction != null) PrepareCommand(command, transaction);
            else PrepareCommand(command, connection);
        }

        /// <summary>
        /// Rolls back all pending transactions
        /// </summary>
        private void RollBackAllTransactions()
        {
            // ROLL BACK ANY PENDING TRANSACTIONS
            for (int i = _Transactions.Count - 1; i >= 0; i--)
            {
                DbTransaction currentTransaction = _Transactions[i];
                try
                {
                    currentTransaction.Rollback();
                }
                finally
                {
                    currentTransaction.Dispose();
                }
            }

            // CLEAR TRANSACTION QUEUE
            _Transactions.Clear();
        }

        private void RollbackTransaction(DbTransaction tran)
        {
            tran.Rollback();
        }

        /// <summary>
        /// Rolls back all pending transactions
        /// </summary>
        public void RollbackTransaction()
        {
            //RELEASE DOES AN IMPLICIT ROLLBACK
            if (_CloseConnectionOnCommit) this.ClosePersistentConnection();
            else RollBackAllTransactions();
        }

        /// <summary>
        /// Determines if the command has the same number of parameters and values
        /// </summary>
        /// <param name="command">The command with associated parameters</param>
        /// <param name="values">The array of parameter values</param>
        /// <returns>True if the number of parameters and values matches; false otherwise.</returns>
        protected virtual bool SameNumberOfParametersAndValues(DbCommand command, object[] values)
        {
            int count = command.Parameters.Count;
            int length = values.Length;
            return (count == length);
        }

        /// <summary>
        /// Sets the parameter value
        /// </summary>
        /// <param name="command">The DbCommand</param>
        /// <param name="parameterName">The parameter name</param>
        /// <param name="value">The value to set for the parameter</param>
        public virtual void SetParameterValue(DbCommand command, string parameterName, object value)
        {
            command.Parameters[this.BuildParameterName(parameterName)].Value = (value == null) ? DBNull.Value : value;
        }

        /// <summary>
        /// Sets up the row updated event for the adapater
        /// </summary>
        /// <param name="adapter">The DbDataAdapter</param>
        protected virtual void SetUpRowUpdatedEvent(DbDataAdapter adapter)
        {
        }

        /// <summary>
        /// Updates the dataset
        /// </summary>
        /// <param name="dataSet">The dataset</param>
        /// <param name="tableName">The tablename</param>
        /// <param name="insertCommand">The insert command</param>
        /// <param name="updateCommand">The update command</param>
        /// <param name="deleteCommand">The delete command</param>
        /// <param name="updateBehavior">The update behavior</param>
        /// <returns>The number of records affected</returns>
        public int UpdateDataSet(DataSet dataSet, string tableName, DbCommand insertCommand, DbCommand updateCommand, DbCommand deleteCommand, UpdateBehavior updateBehavior)
        {
            // TODO: MAKE USE OF PERSISTENT CONNECTION IF AVAILABLE
            using (DbConnection connection = this.OpenConnection())
            {
                if (updateBehavior == UpdateBehavior.Transactional)
                {
                    DbTransaction transaction = this.BeginTransaction(connection);
                    try
                    {
                        int num = this.UpdateDataSet(dataSet, tableName, insertCommand, updateCommand, deleteCommand, transaction);
                        this.CommitTransaction(transaction);
                        return num;
                    }
                    catch
                    {
                        this.RollbackTransaction(transaction);
                        throw;
                    }
                }
                if (insertCommand != null)
                {
                    PrepareCommand(insertCommand, connection);
                }
                if (updateCommand != null)
                {
                    PrepareCommand(updateCommand, connection);
                }
                if (deleteCommand != null)
                {
                    PrepareCommand(deleteCommand, connection);
                }
                return this.DoUpdateDataSet(updateBehavior, dataSet, tableName, insertCommand, updateCommand, deleteCommand);
            }
        }

        /// <summary>
        /// Updates the dataset
        /// </summary>
        /// <param name="dataSet">The dataset</param>
        /// <param name="tableName">The tablename</param>
        /// <param name="insertCommand">The insert command</param>
        /// <param name="updateCommand">The update command</param>
        /// <param name="deleteCommand">The delete command</param>
        /// <param name="transaction">The transaction context for the the command</param>
        /// <returns>The number of records affected</returns>
        public int UpdateDataSet(DataSet dataSet, string tableName, DbCommand insertCommand, DbCommand updateCommand, DbCommand deleteCommand, DbTransaction transaction)
        {
            if (insertCommand != null)
            {
                PrepareCommand(insertCommand, transaction);
            }
            if (updateCommand != null)
            {
                PrepareCommand(updateCommand, transaction);
            }
            if (deleteCommand != null)
            {
                PrepareCommand(deleteCommand, transaction);
            }
            return this.DoUpdateDataSet(UpdateBehavior.Transactional, dataSet, tableName, insertCommand, updateCommand, deleteCommand);
        }

        /// <summary>
        /// The user parameter start index
        /// </summary>
        /// <returns>The user parameter start index</returns>
        protected virtual int UserParametersStartIndex()
        {
            return 0;
        }

        /// <summary>
        /// Gets the connection string
        /// </summary>
        protected internal string ConnectionString
        {
            get
            {
                return this._ConnectionString;
            }
        }

        /// <summary>
        /// Gets the connection string without user credentials
        /// </summary>
        protected string ConnectionStringNoCredentials
        {
            get
            {
                return this._ConnectionStringNoCredentials;
            }
        }

        /// <summary>
        /// Gets the connection string without user credentials
        /// </summary>
        public string ConnectionStringWithoutCredentials
        {
            get
            {
                return this._ConnectionStringNoCredentials;
            }
        }

        /// <summary>
        /// Indicates whether there is an open persistent connection associated with this instance
        /// </summary>
        public bool HasPersistentConnection
        {
            get
            {
                return (_Connection != null && _Connection.State == ConnectionState.Open);
            }
        }

        /// <summary>
        /// Gets the count of currently open transactions for the current connection
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return _Transactions.Count;
            }
        }

        #region IDisposable Members
        /// <summary>Disposes the resources associated with the current database connection.</summary>
        ~Database()
        {
            Dispose(false);
        }

        /// <summary>
        /// Disposes of managed and unmanaged resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose of this instance
        /// </summary>
        /// <param name="disposing">This is set to true if dispose is being called manually.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.ClosePersistentConnection();
            }
        }
        #endregion

        /// <summary>
        /// Gets the major version of the sql server database
        /// </summary>
        public int SqlServerMajorVersion
        {
            get
            {
                string sql = "SELECT SERVERPROPERTY('productversion')";
                DbCommand command = this.GetSqlStringCommand(sql);
                string version = AlwaysConvert.ToString(this.ExecuteScalar(command));
                string[] tokens = version.Split(".".ToCharArray());
                return AlwaysConvert.ToInt(tokens[0]);
            }
        }

        /// <summary>
        /// Gets the schema version for the AbleCommerce tables
        /// <remarks>Value is 2000, 2005, or empty string if the version cannot be determined.</remarks>
        /// </summary>
        public string AbleCommerceSchemaVersion
        {
            get
            {
                // BUILD LIST OF TABLES AND FIELDS THAT USE VARCHAR(MAX) IN 2005 SCHEMA
                Dictionary<string, string> maxFields = new Dictionary<string, string>();
                maxFields["ac_CustomFields"] = "FieldValue";
                maxFields["ac_Products"] = "Summary";
                maxFields["ac_ShipGateways"] = "ConfigData";
                maxFields["ac_StoreSettings"] = "FieldValue";
                maxFields["ac_Users"] = "Comment";

                // KEEP TRACK OF RESULTS
                int votesFor2005 = 0;
                int votesFor2000 = 0;
                int votesForUnknown = 0;

                // SPOT CHECK COLUMN LENGHTS
                foreach (string tableName in maxFields.Keys)
                {
                    int colLength = this.GetColumnLength(tableName, maxFields[tableName]);
                    if (colLength < 0) votesFor2005++;
                    else if (colLength > 0) votesFor2000++;
                    else votesForUnknown++;
                }

                // RETURN THE VERSION
                if (votesForUnknown == maxFields.Count) return string.Empty;
                if (votesFor2000 > votesFor2005) return "2000";
                return "2005";
            }
        }

        private int GetColumnLength(string tableName, string columnName)
        {
            string sql = "SELECT COL_LENGTH('" + tableName + "','" + columnName + "')";
            DbCommand command = this.GetSqlStringCommand(sql);
            return AlwaysConvert.ToInt(this.ExecuteScalar(command));
        }
    }

}