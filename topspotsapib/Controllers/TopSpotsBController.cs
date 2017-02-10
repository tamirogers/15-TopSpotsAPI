using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using topspotsapib.Models;

namespace topspotsapib.Controllers
{
    public class TopSpotsBController : ApiController
    {
        // GET: api/TopSpotsB
        public IEnumerable<TopSpots> Get()
        {
     
            return JsonConvert.DeserializeObject<List<TopSpots>>(File.ReadAllText(@"C:\Users\tami\Desktop\devtr\topspotsapib\topspotsapib\topspots.json"));
      
        }

        // GET: api/TopSpotsB/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpotsB
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpotsB/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpotsB/5
        public void Delete(int id)
        {
        }
    }
}
