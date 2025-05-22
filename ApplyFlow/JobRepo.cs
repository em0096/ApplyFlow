using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace ApplyFlow
{
    internal class JobRepo
    {
        DatabaseManager dbManager = new DatabaseManager();

        public Job GetJob(int jobID)
        {
            try
            {
                string query = "SELECT * FROM Job j WHERE id = :jobID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":jobID", jobID);
                DataTable result = dbManager.SelectQuery(query, parameters);
                Job job = null;
                foreach (DataRow row in result.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string title = row["title"].ToString();
                    string company = DatabaseManager.GetSafeString(row, "company_name");
                    int? score = DatabaseManager.GetSafeInt(row, "score");
                    string salary = DatabaseManager.GetSafeString(row, "salary");
                    DateTime? openDate = DatabaseManager.GetSafeDate(row, "open_date");
                    DateTime? expiryDate = DatabaseManager.GetSafeDate(row, "expiry_date");
                    DateTime? startDate = DatabaseManager.GetSafeDate(row, "start_date");
                    string workmode = DatabaseManager.GetSafeString(row, "work_mode");
                    string url = DatabaseManager.GetSafeString(row, "url");
                    string platformFound = DatabaseManager.GetSafeString(row, "platform_found");
                   
                    job = new Job(id, title, company, score, salary, openDate, expiryDate, startDate, workmode, url, platformFound);
                }
                //MessageBox.Show("getjob success");
                return job;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void InsertJob(Job job)
        {
            try
            {
                string query = @"INSERT INTO Job (id, title, platform_found, salary, expiry_date, start_date, open_date, url, work_mode, score, company_name)
                    VALUES (job_sequence.NEXTVAL, :title, :platformFound, :salary, TO_DATE(:expiryDate, 'YYYY-MM-DD'), TO_DATE(:startDate, 'YYYY-MM-DD'), 
                    TO_DATE(:openDate, 'YYYY-MM-DD'), :url, :workMode, :score, :companyName)";
                
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add(":title", job.GetTitle());
                parameters.Add(":platformFound", job.GetPlatform());
                parameters.Add(":salary", job.GetSalary());
                parameters.Add(":expiryDate", job.GetExpiryDate());
                parameters.Add(":startDate", job.GetStartDate());
                parameters.Add(":openDate", job.GetOpenDate());
                parameters.Add(":url", job.GetURL());
                parameters.Add(":workMode", job.GetWorkMode());
                parameters.Add(":score", job.GetScore());
                parameters.Add(":companyName", job.GetCompany());

                dbManager.ExecuteNonQuery(query, parameters);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool JobExists(int jobID)
        {
            try
            {
                string query = "SELECT 1 FROM Job WHERE id = :jobID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":jobID", jobID);
                DataTable result = dbManager.SelectQuery(query, parameters);
                return result.Rows.Count > 0;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
