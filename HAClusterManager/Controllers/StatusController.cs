using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HAClusterManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HAClusterManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IClusterManager clusterManager;

        public StatusController(IClusterManager clusterManager)
        {
            this.clusterManager = clusterManager;
        }

        // GET: api/Status
        [HttpGet]
        public Status GetResources()
        {
           return clusterManager.GetClusterStatus();
        }
    }
}