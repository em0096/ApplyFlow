using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections.Generic;
using ApplyFlow;
using System.Windows.Forms;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Collections;
using System.Threading;

namespace ApplyFlow
{
    internal class ApplicationService
    {

        private User user = User.GetInstance(); // get the current user
        private RecordRepo recordRepo = new RecordRepo();
        private JobRepo jobRepo = new JobRepo();
        private EmployerRepo employerRepo = new EmployerRepo();
        private DocumentRepo documentRepo = new DocumentRepo();

        private EmployerService employerService;


        // retrieve all application(s) for user
        public List<Application> GetApplications()
        {
            try
            {
                List<Application> applications = new List<Application>();
                // get all user application records 
                List<Record> records = recordRepo.GetRecords(user.GetUsername());

                foreach (Record record in records)
                {
                    // get job id from record
                    int jobID = record.GetJobID();

                    // get job for application
                    Job job = jobRepo.GetJob(jobID);
                    // get employer for job
                    Employer employer = employerRepo.GetEmployer(jobID);
                    // set employer industry
                    employer.SetIndustries(employerRepo.GetEmployerIndustries(jobID));
                    // get application documents 
                    List<Document> documents = documentRepo.GetDocuments(jobID);

                    Application application = new Application(record, job, employer, documents);
                    applications.Add(application);
                }
                //MessageBox.Show("getApps success");
                return applications;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        public bool InsertApplication(Employer employer, List<string> industries, Job job, List<Document> documents, Record record)
        {
            try
            {
                employerService.InsertEmployerIfMissing(employer);

                if (industries!= null)
                {
                    employerService.InsertIndustryIfMissing(industries);
                    employerService.InsertEmployerIndustryIfMissing(industries, employer);
                }

                if (!jobRepo.JobExists(job.GetJobID()))
                {
                    jobRepo.InsertJob(job);
                }
                if (!recordRepo.RecordExists(job.GetJobID(), User.GetInstance().GetUsername()))
                {
                    recordRepo.InsertRecord(record);
                }
                else { return false; }

                if (documents != null)
                {
                    foreach (Document d in documents)
                    {
                        documentRepo.InsertDocumet(job.GetJobID(), record.GetAppliedDate(), d.GetFilename());
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void DeleteApplication(Record record, Document document)
        {
            documentRepo.DeleteDocument(User.GetInstance().GetUsername(), record.GetJobID());
            recordRepo.DeleteRecord(record.GetJobID(),User.GetInstance().GetUsername());
        }

        // Move to different class?
        public static string GetIndustryNames(List<string> industryList)
        {
            StringBuilder s = new StringBuilder();
            foreach(string i in industryList)
            {
               s.Append(i + ", ");
            }
            return s.ToString();
        }

        public static string GetFilenames(List<Document> docList)
        {
            StringBuilder s = new StringBuilder();
            foreach (Document d in docList)
            {
                s.Append(d.GetFilename() + ", ");
            }
            return s.ToString();
        }

    }
}








