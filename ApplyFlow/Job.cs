using System;

namespace ApplyFlow
{
    public class Job
    {
        private int _id = 0;
        private string _title = "";
        private string _company = "";
        private string _salary = "";
        private int? _score = 0;
        private DateTime? _openDate;
        private DateTime? _expiryDate;
        private DateTime? _startDate;
        private string _workMode = "";
        private string _url = "";
        private string _platformFound = "";

        public Job(int id, string title, string company, int? score, string salary, DateTime? openDate, DateTime? expiryDate, DateTime? startDate, string workMode, string url, string platformFound)
        {
            _id = id;
            _title = title;
            _company = company;
            _score = score;
            _salary = salary;
            _openDate = openDate;
            _expiryDate = expiryDate;
            _startDate = startDate;
            _workMode = workMode;
            _url = url;
            _platformFound = platformFound;
        }
        public int GetJobID()
        {
            return _id;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetCompany()
        {
            return _company;
        }
        public int? GetScore()
        {
            return _score;
        }
        public string GetSalary()
        {
            return _salary;
        }
        public DateTime? GetOpenDate()
        {
            return _openDate;
        }

        public DateTime? GetExpiryDate()
        {
            return _expiryDate;
        }
        public DateTime? GetStartDate()
        {
            return _startDate;
        }
        public string GetWorkMode()
        {
            return _workMode;
        }
        public string GetPlatform()
        {
            return _platformFound;
        }
        public string GetURL()
        {
            return _url;
        }
    }
}
