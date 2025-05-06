using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyFlow
{
    internal class Application
    {
        private Record _record = null;
        private Job _job = null;
        private Employer _employer = null;
        private List<Document> _documents = new List<Document>();

        public Application(Record record, Job job, Employer employer, List<Document> documents)
        {
            _record = record;
            _job = job;
            _employer = employer;
            _documents = documents;
        }

        public Record GetRecord()
        {
            return _record;
        }

        public Job GetJob()
        {
            return _job;
        }

        public Employer GetEmployer()
        {
            return _employer;
        }

        public List<Document> GetDocuments()
        {
            return _documents;
        }
    }
}
