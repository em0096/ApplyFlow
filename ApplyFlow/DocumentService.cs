using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyFlow
{
    internal class DocumentService
    {
        private DocumentRepo documentRepo = new DocumentRepo();

        public List<Document> GetUserDocuments()
        {
            List<Document> docList = documentRepo.GetUserDocuments();
            return docList;
        }
    }
}
