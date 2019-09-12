using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAClusterManager.Models
{
    public class Status
    {
        public string LastUpdate { get; set; }
        public string LastChange { get; set; }
        public int NodesCount { get; set; }
        public int ResourcesCount { get; set; }

        public Node[] Nodes { get; set; }
    }
}
