using System;
using System.Collections.Generic;

namespace ApplyFlow
{
    public class Record
    {
        private string _status = "";
        private DateTime? _appliedDate;
        private int _jobID = 0;

        public Record(string status, DateTime? appliedDate, int jobID)
        {
            _status = status;
            _appliedDate = appliedDate;
            _jobID = jobID;
        }

        public string GetStatus()
        {
            return _status; 
        }

        public DateTime? GetAppliedDate()
        {
            return _appliedDate;
        }

        public int GetJobID() { 
            return _jobID;
        }

    }
}
