using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAClusterManager.Models
{
    public class Resource
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Location { get; set; }

        public string Class { get; set; }
        public string Provider { get; set; }
        public string Type { get; set; }
        public string ResType { get; set; }

        public Operation[] Operations { get; set; }
        public Attribute[] Attributes { get; set; }
        public string Parameters { get; set; }
    }

    public class Operation
    {
        public string Name { get; set; }
        public string Timeout { get; set; }
        public string Interval { get; set; }
    }

    public class Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
