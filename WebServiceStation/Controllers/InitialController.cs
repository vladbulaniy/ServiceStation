using Business.Interfaces;
using Service_Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceStation.Controllers
{
    public class InitialController : BaseController
    {
        
        // GET: api/Initial
        public UserProfile Get()
        {
           UserProfile result = new UserProfile();

            var temp = AppServiceLocator.GetService<IRepairAttr>();



            return result;
                }

        // GET: api/Initial/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Initial
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Initial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Initial/5
        public void Delete(int id)
        {
        }
    }
}
