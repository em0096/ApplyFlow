using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyFlow
{
    internal class RecordRepo
    {
        DatabaseManager dbManager = new DatabaseManager();

        // get all application records
        public List<Record> GetRecords(string username)
        {
            try
            {
                string query = "SELECT * FROM Application WHERE username = :username";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                //parameters.Add(":username", username);
                parameters.Add(":username", "alice123"); // testing
                DataTable result = dbManager.SelectQuery(query, parameters);
                List<Record> records = new List<Record>();
                foreach (DataRow row in result.Rows)
                {
                    // public ApplicationRecord(string status, DateTime appliedDate, int jobID)
                    string status = DatabaseManager.GetSafeString(row, "status");
                    DateTime appliedDate = Convert.ToDateTime(row["applied_date"]);
                    int jobID = Convert.ToInt32(row["job_id"]);

                    Record record = new Record(status, appliedDate, jobID);
                    records.Add(record);
                }
               // MessageBox.Show("getRecords success");
                return records;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
        
        // insert application record in database 

        public void InsertRecord(Record record)
        {
            try
            {
                string query = "INSERT INTO Application (status, applied_date, job_id, username) VALUES (:status, :appliedDate, job_sequence.CURRVAL, :username)";
                
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":status", record.GetStatus());
                parameters.Add(":appliedDate", record.GetAppliedDate());
                parameters.Add(":jobID", record.GetJobID());
                parameters.Add("username", User.GetInstance().GetUsername());

                dbManager.ExecuteNonQuery(query, parameters);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        public bool RecordExists(int jobID, string username)
        {
            try
            {
                string query = "SELECT 1 FROM Application WHERE LOWER(username) = LOWER(:username) AND job_id = :job_id";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":username", username);
                parameters.Add(":jobID", jobID);
                DataTable result = dbManager.SelectQuery(query, parameters);
                return result.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void DeleteRecord(int jobID, string username)
        {
            try
            {
                string query = "DELETE FROM Application WHERE username = :username AND job_id = :jobId";
                Dictionary <string, object> parameters = new Dictionary<string, object>();
                parameters.Add (":username", username);
                parameters.Add(":jobID", jobID);
                dbManager.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateRecord(string status, DateTime appliedDate, int jobID, string username)
        {
            try
            {
                string query = "";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":status", status);
                parameters.Add(":appliedDate", appliedDate);
                parameters.Add(":jobID", jobID);
                parameters.Add("username", username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
