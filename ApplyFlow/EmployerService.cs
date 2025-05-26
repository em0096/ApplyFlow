using ApplyFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyFlow
{
    internal class EmployerService
    {
        private EmployerRepo employerRepo = new EmployerRepo();

        public List<string> GetIndustryList()
        {
            try
            {
               List<string> industryList = employerRepo.GetAllIndustries();
               return industryList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void InsertEmployerIfMissing(Employer employer)
        {
            try
            {
                if (!employerRepo.EmployerExists(employer.GetCompany()))
                {
                    // insert new employer
                    employerRepo.InsertEmployer(employer);
                    //MessageBox.Show("employer " + employer.GetCompany() + " inserted"); //testing
                }
                //else
                //{
                //    MessageBox.Show("employer " + employer.GetCompany() + " already exists"); //testing
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertIndustryIfMissing(List<string> industries)
        {
            try
            {
                foreach (string industry in industries)
                {
                    // if industry does not exist
                    if (!employerRepo.IndustryExists(industry))
                    {
                        // insert new industry
                        employerRepo.InsertIndustry(industry);

                        //MessageBox.Show("industry inserted"); //testing
                    }
                    //else
                    //{
                    //    MessageBox.Show(industry + " industry already exists"); //testing
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertEmployerIndustryIfMissing(List<string> industries, Employer employer)
        {
            try
            {
                foreach (string industry in industries)
                {
                    // if employer industry does not exist
                    if (!employerRepo.EmployerIndustryExists(employer.GetCompany(), industry))
                    {
                        // insert employer industry 
                        employerRepo.InsertEmployerIndustry(employer.GetCompany(), industry);

                        //MessageBox.Show("employer industry inserted"); //testing
                    }
                    //else {
                    //    MessageBox.Show("employer industry already exists"); //testing
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
