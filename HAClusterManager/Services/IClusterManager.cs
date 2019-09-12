using HAClusterManager.Models;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HAClusterManager
{
    public interface IClusterManager
    {
        IEnumerable<Resource> GetResources();
        bool ResourceMove(string resourceID, string nodeName);
        bool DeleteResource(string resourceID);
        bool CreateResource(Resource resource);
        bool UpdateResource(Resource resource);

        Status GetClusterStatus();
    }
}
