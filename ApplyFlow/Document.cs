using System;

namespace ApplyFlow
{
    public class Document
    {
        private string _fileName = "";
        private string _filePath = "";

        //private int _jobID = 0;
        //private string _username = "";
        //private DateTime _appliedDate;

        public Document(String fileName, string filepath)
        {
            _fileName = fileName;
            _filePath = filepath;
            //_jobID = jobID;
            //_appliedDate = appliedDate;
            //_username = username;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public string GetFilepath()
        {
            return _filePath;
        }
        public override string ToString()
        {
            return _fileName; 
        }

        //public DateTime GetAppliedDate()
        //{
        //    return _appliedDate;
        //}

        //public int GetJobID()
        //{
        //    return _jobID;
        //}
        //public string GetUsername()
        //{
        //    return _username;
        //}
    }
}
