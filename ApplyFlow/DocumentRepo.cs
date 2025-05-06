using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;

namespace ApplyFlow
{
    internal class DocumentRepo
    {
        DatabaseManager dbManager = new DatabaseManager();

        // get all application documents 
        public List<Document> GetDocuments(int jobID)
        {
            try
            {
                string query = "SELECT * FROM Document d WHERE d.job_id = (SELECT j.id FROM Job j WHERE j.id = :jobID)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                //parameters.Add(":jobID", jobID);
                parameters.Add(":jobID", 1); // testing
                DataTable result = dbManager.SelectQuery(query, parameters);
                List<Document> docs = new List<Document>();
                foreach(DataRow row in result.Rows)
                {
                    string filename = DatabaseManager.GetSafeString(row, "file_name");
                    string filepath = DatabaseManager.GetSafeString(row, "file_path");
                    //string username = DatabaseManager.GetSafeString(row, "username");
                    Document doc = new Document(filename, filepath);
                    docs.Add(doc);
                }
                return docs;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void InsertDocumet(int jobID, DateTime? appliedDate, string filename)
        {
            try
            {
                string query = "INSERT INTO Document (file_name, job_id, username, applied_date) VALUES (:filename, job_sequence.CURRVAL, :username, SYSDATE)";
                Dictionary <string, object> parameters = new Dictionary<string, object>();
                string username = User.GetInstance().GetUsername();

                parameters.Add(":filename", filename);
                parameters.Add(":jobID", jobID);
                parameters.Add(":username", username);
                parameters.Add(":appliedDate", appliedDate);

                dbManager.ExecuteNonQuery(query, parameters);   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool DocumentExists(int jobID, DateTime? appliedDate, string filename)
        {
            try
            {
                string query = "SELECT 1 FROM Document WHERE LOWER(username) = LOWER(:username) AND job_id = :job_id AND applied_date = :appliedDate AND file_name = :filename";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":username", User.GetInstance().GetUsername());
                parameters.Add(":filename", filename);
                parameters.Add(":jobID", jobID);
                parameters.Add(":appliedDate", appliedDate);
                DataTable result = dbManager.SelectQuery(query, parameters);
                return result.Rows.Count > 0;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void DeleteDocument(string username, int jobID)
        {
            try
            {
                string query = "DELETE FROM Document WHERE username = :username AND job_id = :jobId";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":usernmae", username);
                parameters.Add(":jobID", jobID);
                dbManager.ExecuteNonQuery(query, parameters);
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

