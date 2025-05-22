using System.Collections.Generic;

namespace ApplyFlow
{
    public class Employer
    {
        private string _company = "";
        private string _website = "";
        private string _city = "";
        private string _country = "";
        private List<string> _industries = new List<string>();
        public Employer(string company, string website, string city, string country)
        {
            _company = company;
            _website = website;
            _city = city;
            _country = country;
        }

        public void SetIndustries(List<string> industries)
        {
            _industries = industries;
        }
        public List<string> GetIndustries()
        {
            return _industries;
        }
        public string GetCompany()
        {
            return _company;
        }
        public string GetWebsite()
        {
            return _website;
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetCountry()
        {
            return _country;
        }
    }
}
