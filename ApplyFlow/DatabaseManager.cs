using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace ApplyFlow
{
    internal class DatabaseManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyOracleDB"].ConnectionString;
        private OracleConnection connection;
        private OracleCommand command;
        private OracleDataReader read;
        
         
        // Select all query
        public DataTable SelectQuery(string query)
        {
            try
            {
                using (connection = new OracleConnection(connectionString))
                {
                    command = new OracleCommand(query, connection);
                    connection.Open();
                    read = command.ExecuteReader();
                    DataTable result = new DataTable();
                    result.Load(read);
                    return result;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Select with parameters

        public DataTable SelectQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (connection = new OracleConnection(connectionString))
                {
                    command = new OracleCommand(query, connection);
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> p in parameters)
                        {
                            command.Parameters.Add(p.Key, p.Value);
                        }
                    }
                    connection.Open();
                    read = command.ExecuteReader();
                    DataTable result = new DataTable();
                    result.Load(read);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        // Insert / Update / Delete 
        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using(connection = new OracleConnection(connectionString))
                {
                    command = new OracleCommand(query, connection);
                    if (parameters != null)
                    {
                        foreach(KeyValuePair<string, object> p in parameters)
                        {
                            command.Parameters.Add(p.Key, p.Value);
                        }
                    }
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    //MessageBox.Show("Rows Affected: " + rowsAffected); // testing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // helper method(s) for checking null column values 
        public static string GetSafeString(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? row[columnName].ToString() : "";
        }
        public static int? GetSafeInt(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToInt32(row[columnName]) : (int?)null;
        }

        public static DateTime? GetSafeDate(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToDateTime(row[columnName]) : (DateTime?)null;
        }
    }
}
