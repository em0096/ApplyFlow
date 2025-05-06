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
        private EmployerRepo employerRepo;
        public void InsertEmployerIfMissing(Employer employer)
        {
            try
            {
                if (!employerRepo.EmployerExists(employer.GetCompany()))
                {
                    // insert new employer
                    employerRepo.InsertEmployer(employer);
                }
            }
            catch(Exception ex)
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
                    if (!employerRepo.IndustryExists(industry)){
                        // insert new industry
                        employerRepo.InsertIndustry(industry);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertEmployerIndustryIfMissing(List<string> industries, Employer employer) {
            try
            {
                foreach (string industry in industries)
                {
                    // if employer industry does not exist
                    if (!employerRepo.EmployerIndustryExists(industry, employer.GetCompany()))
                    {
                        // insert employer industry 
                        employerRepo.InsertEmployerIndustry(employer.GetCompany(), industry);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
