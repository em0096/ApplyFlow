using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyFlow
{
    internal class EmployerRepo
    {
        private DatabaseManager dbManager = new DatabaseManager();
        private Employer employer = new Employer(null, null, null, null);
        public Employer GetEmployer(int jobID)
        {
            try
            {
                string query = "SELECT * FROM Employer e WHERE e.company_name = (SELECT j.company_name FROM Job j WHERE j.id = :jobID)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":jobID", jobID);
                DataTable result = dbManager.SelectQuery(query, parameters);
                foreach (DataRow row in result.Rows)
                {
                    string company_name = row["company_name"].ToString();
                    string website = DatabaseManager.GetSafeString(row, "website");
                    string city = DatabaseManager.GetSafeString(row, "city");
                    string country = DatabaseManager.GetSafeString(row, "country");
                    employer = new Employer(company_name, website, city, country);
                }
                return employer;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // check employer exists
        public bool EmployerExists(string companyName)
        {
            try
            {
                string query = "SELECT 1 FROM Employer WHERE LOWER(company_name) = LOWER(:companyName)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":companyName", companyName);
                DataTable datatable = dbManager.SelectQuery(query, parameters);
                return datatable.Rows.Count > 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // get industry for employer
        public List<string> GetEmployerIndustries(int jobID)
        {
            try
            {
                string query = "SELECT i.industry_name FROM Employer_Industry i WHERE i.company_name = (SELECT j.company_name FROM Job j WHERE j.id = :jobID)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":jobID", jobID);
                List<string> industries = new List<string>();
                DataTable result = dbManager.SelectQuery(query, parameters);
                foreach(DataRow row in result.Rows)
                {
                    string industry = row["industry_name"].ToString();  
                    industries.Add(industry);
                }
                return industries;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void InsertEmployer(Employer employer)
        {
            try
            {
                string query = "INSERT INTO Employer (company_name, website, country, city) VALUES (:companyName, :website, :country, :city)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":company", employer.GetCompany());
                parameters.Add(":website", employer.GetWebsite());
                parameters.Add(":city", employer.GetCity());
                parameters.Add(":Country", employer.GetCountry());
                dbManager.ExecuteNonQuery(query, parameters);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertIndustry(string industry)
        {
            try
            {
                string query = "INSERT INTO Industry (name) VALUES (:name)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":name", industry);
                dbManager.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertEmployerIndustry(string companyName, string industry)
        {
            try
            {
                string query = "INSERT INTO Employer_Industry (company_name, industry_name) VALUES (:companyName, :industryName)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":industryName", industry);
                parameters.Add(":companyName", companyName);

                dbManager.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IndustryExists(string industry)
        {
            try
            {
                string query = "SELECT 1 FROM Industry WHERE LOWER(name) = LOWER(:industryName)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":industryName", industry);
                DataTable result = dbManager.SelectQuery(query, parameters);
                return result.Rows.Count > 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool EmployerIndustryExists(string companyName, string industry)
        {
            try
            {
                string query = "SELECT 1 FROM Employer_Industry WHERE LOWER(company_name) = LOWER(:companyName) AND LOWER(industry_name) = LOWER(:industryName)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":companyName", companyName);
                parameters.Add(":industry", industry);
                DataTable dataTable = dbManager.SelectQuery(query, parameters);
                return dataTable.Rows.Count > 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
