using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using HAClusterManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Renci.SshNet;

namespace HAClusterManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NodesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        //GET : /api/Cluster
        public async Task<IEnumerable<crm_monNode>> GetClusterStatus()
        {
            //string userId = User.Claims.First(c => c.Type == "UserID").Value;

            //if(userId == "789234")
            //{
            //}
            crm_mon status = null;
            try
            { 
                using (var client = new SshClient("192.168.29.130", "root", "ny8yjyfe22"))
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        var response = client.RunCommand("crm_mon --as-xml");

                        XmlSerializer serializer = new XmlSerializer(typeof(crm_mon));

                        using (TextReader reader = new StringReader(response.Result))
                        {
                            status = (crm_mon)serializer.Deserialize(reader);
                        }

                        //using (XmlReader reader = XmlReader.Create(response.Result))
                        //{
                        //    status = (crm_mon)serializer.Deserialize(reader);
                        //}



                        client.Disconnect();
                    }
                }
            }
            catch(Exception ex)
            {

            }


            return status.nodes.ToList();
        }
    }
}