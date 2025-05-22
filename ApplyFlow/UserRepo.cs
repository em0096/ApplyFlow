using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace ApplyFlow
{
    internal class UserRepo
    {
        private DatabaseManager sql = new DatabaseManager(); 
        public bool queryUser(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM Applicant WHERE username = :username AND password = :password";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":username", username);
                parameters.Add(":password", password);
                DataTable result = sql.SelectQuery(query, parameters);
                return result.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

    }
}
