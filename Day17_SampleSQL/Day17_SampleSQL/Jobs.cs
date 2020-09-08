using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_SampleSQL
{
    class Jobs
    {
        public String jobName;
        public String jobDescr;

        public Jobs(String jobName, String jobDescr)
        {
            this.jobName = jobName;
            this.jobDescr = jobDescr;
        }

        public Jobs()
        {
            this.jobName = "";
            this.jobDescr = "";
        }
    }
}