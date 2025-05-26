using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyFlow
{
    internal class JobService
    {
        private JobRepo _jobRepo= new JobRepo();

        public List<string> GetPlatformList()
        {
           List<string> platformList = _jobRepo.GetAllPlatforms();
           return platformList;
        }
    }
}
