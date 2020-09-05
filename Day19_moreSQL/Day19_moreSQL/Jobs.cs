using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Day19_moreSQL
{
    class Jobs
    {
        public String jobName;
        public String jobDescr;
        public Jobs(string jobName, string jobDescr)
        {
            this.jobName = jobName;
            this.jobDescr = jobDescr;
        }
    }
}
