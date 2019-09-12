using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HAClusterManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace HAClusterManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly IClusterManager clusterManager;

        public ResourcesController(IClusterManager clusterManager)
        {
            this.clusterManager = clusterManager;
        }

        // GET: api/Resources
        [HttpGet]
        public IEnumerable<Resource> GetResources()
        {
            return clusterManager.GetResources();
        }

        [HttpPost("Post")]
        public IActionResult CreateResource([FromBody] Resource resource)
        {
            if (resource == null)
                return BadRequest();

            try
            {
                if (clusterManager.CreateResource(resource))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("Move")]
        public IActionResult MoveResource(string id, string node)
        {
            if(string.IsNullOrEmpty(id))
                return BadRequest();

            try
            {
                if (clusterManager.ResourceMove(id, node))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("Update")]
        public IActionResult UpdateResource([FromBody] Resource resource)
        {
            if (resource == null)
                return BadRequest();

            try
            {
                if (clusterManager.UpdateResource(resource))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteResource(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            try
            {
                if (clusterManager.DeleteResource(id))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
