using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HAClusterManager.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Renci.SshNet;

namespace HAClusterManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]
        public ActionResult<string> Get()
        {
            var jsonStr = @"{
                              ""crm_mon"": {
                                            ""version"": ""1.1.18"",
                                ""summary"": {
                                                ""stack"": { ""type"": ""corosync"" },
                                  ""current_dc"": {
                                                    ""present"": ""true"",
                                    ""version"": ""1.1.18 - 11.el7_5.3 - 2b07d5c5a9"",
                                    ""name"": ""node1"",
                                    ""id"": ""1"",
                                    ""with_quorum"": ""false""
                                  },
                                  ""last_update"": { ""time"": ""Mon Mar 11 23:30:08 2019"" },
                                  ""last_change"": {
                                                    ""time"": ""Sun Feb 17 20:23:58 2019"",
                                    ""user"": ""hacluster"",
                                    ""client"": ""crmd"",
                                    ""origin"": ""node1""
                                  },
                                  ""nodes_configured"": {
                                                    ""number"": ""2"",
                                    ""expected_votes"": ""unknown""
                                  },
                                  ""resources_configured"": {
                                                    ""number"": ""0"",
                                    ""disabled"": ""0"",
                                    ""blocked"": ""0""
                                  },
                                  ""cluster_options"": {
                                                    ""stonithenabled"": ""true"",
                                    ""symmetriccluster"": ""true"",
                                    ""noquorumpolicy"": ""stop"",
                                    ""maintenancemode"": ""false""
                                  }
                                            },
                                ""nodes"": {
                                                ""node"": [
                                                  {
                                      ""name"": ""node1"",
                                                    ""id"": ""1"",
                                                    ""online"": ""true"",
                                                    ""standby"": ""false"",
                                                    ""standby_onfail"": ""false"",
                                                    ""maintenance"": ""false"",
                                                    ""pending"": ""false"",
                                                    ""unclean"": ""false"",
                                                    ""shutdown"": ""false"",
                                                    ""expected_up"": ""true"",
                                                    ""is_dc"": ""true"",
                                                    ""resources_running"": ""0"",
                                                    ""type"": ""member""
                                    },
                                    {
                                      ""name"": ""node2"",
                                      ""id"": ""2"",
                                      ""online"": ""false"",
                                      ""standby"": ""false"",
                                      ""standby_onfail"": ""false"",
                                      ""maintenance"": ""false"",
                                      ""pending"": ""false"",
                                      ""unclean"": ""true"",
                                      ""shutdown"": ""false"",
                                      ""expected_up"": ""false"",
                                      ""is_dc"": ""false"",
                                      ""resources_running"": ""0"",
                                      ""type"": ""member""
                                    }
                                  ]
                                },
                                ""node_attributes"": {
                                  ""node"": { ""name"": ""node1"" }
                                },
                                ""node_history"": {
                                  ""node"": { ""name"": ""node1"" }
                                },
                                ""tickets"": ""
                                "",
                                ""bans"": ""
                                ""
                              }
                            }
                            ";

        //    JObject obj = JObject.Parse(jsonStr);
            //var model = JsonConvert.DeserializeObject<Rootobject>(jsonStr);

            //using (var client = new SshClient("192.168.29.130", "root", "ny8yjyfe22"))
            //{
            //    //client.HostKeyReceived += (sender, e) =>
            //    //{
            //    //    //if (expectedFingerPrint.Length == e.FingerPrint.Length)
            //    //    {
            //    //        for (var i = 0; i < expectedFingerPrint.Length; i++)
            //    //        {
            //    //            if (expectedFingerPrint[i] != e.FingerPrint[i])
            //    //            {
            //    //                e.CanTrust = false;
            //    //                break;
            //    //            }
            //    //        }
            //    //    }
            //    //    else
            //    //    {
            //    //        e.CanTrust = false;
            //    //    }
            //    //};
            //    client.Connect();
            //    if(client.IsConnected)
            //    {
            //        var response = client.RunCommand("crm_mon --as-xml");
            //        response = client.RunCommand("ls -al");

            //        client.Disconnect();
            //    }
            //}

            //  return new string[] { "value1", "value2" };
            return jsonStr;
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
