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
                //parameters.Add(":username", username);
                //parameters.Add(":password", password);
                parameters.Add(":username", "alice123");
                parameters.Add(":password", "BrightSky23");
                DataTable result = sql.SelectQuery(query, parameters);
                return result != null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

    }
}
