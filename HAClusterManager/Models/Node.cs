using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAClusterManager.Models
{
    public class Node
    {
        public string Name { get; set; }
        public bool Online { get; set; }
        public bool Maintenance { get; set; }
        public bool Standby { get; set; }
        public int ResourcesCount { get; set; }
    }
}
