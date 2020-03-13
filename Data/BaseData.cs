using eOrdination.Log;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace eOrdination.Data
{
    public class BaseData
    {

        public string connectionString = "Server=BEL-RUZMAT-LT01\\SQLEXPRESS2014;DataBase=eOrdination;Trusted_Connection=true";
        public SqlCommand sqlCommand;

        public SqlConnection sqlConnection;
        
        public SqlCommand CreateSqlCommandSP(string spName)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(spName, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
     
            return sqlCommand;
        }
        //public SqlDataReader ExecuteReader(string spName)
        //{

        //    sqlConnection = new SqlConnection(connectionString);

        //    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //    if (sqlConnection.State != System.Data.ConnectionState.Open)
        //    {
        //        sqlConnection.Open();
        //    }
        //    return sqlCommand.ExecuteReader();
        //}
        public SqlDataReader ExecuteReader()
        {
            string parameterValues = string.Empty;
            for (int i = 0; i < sqlCommand.Parameters.Count; i++)
            { 
                parameterValues +=  "Param " + sqlCommand.Parameters[i].ParameterName + 
                    "  value " + sqlCommand.Parameters[i].Value.ToString() + Environment.NewLine;
            }
            Logger.Log(DateTime.Now.ToString() + " calling method " + sqlCommand.CommandText + " with params" + parameterValues ); ; ;
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            return sqlCommand.ExecuteReader();
        }
        public void AddParameterInt(string name, int value)
        {
            sqlCommand.Parameters.Add(name, System.Data.SqlDbType.Int);
            sqlCommand.Parameters[name].Value = value;
            
        }
        public void AddParameterString(string name, string value)
        {
            sqlCommand.Parameters.Add(name, System.Data.SqlDbType.VarChar);
            sqlCommand.Parameters[name].Value = value;
        }

        public void AddParameterDateTime(string name, DateTime value)
        {
            sqlCommand.Parameters.Add(name, System.Data.SqlDbType.VarChar);
            sqlCommand.Parameters[name].Value = value;
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            sqlCommand.Parameters.Clear();
            sqlCommand = null;

        }
    }
}
