using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PivotalCF.Models
{
    public class Limits
    {
        public int disk { get; set; }
        public int fds { get; set; }
        public int mem { get; set; }
    }

    public class RootObject
    {
        public string application_id { get; set; }
        public string application_name { get; set; }
        public string instance_id { get; set; }
        public string instance_index { get; set; }
        public string PORT { get; set; }
        public string start { get; set; }
        public List<string> application_uris { get; set; }
        public string application_version { get; set; }
        public Limits limits { get; set; }
        public string name { get; set; }
        public string space_id { get; set; }
        public string space_name { get; set; }
        public List<string> uris { get; set; }
        public object users { get; set; }
        public string version { get; set; }
    }
}
