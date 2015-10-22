using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TRex.Metadata;

namespace HTTP_ASE_API.Controllers
{
    public class HTTPController : ApiController
    {
        [Metadata("GET", "HTTP GET")]
        [HttpGet, Route("api/http")]
        public async System.Threading.Tasks.Task<HttpResponseMessage> Get(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetAsync(url);
            }
        }

        [Metadata("POST", "HTTP POST")]
        [HttpPost, Route("api/http")]
        public async System.Threading.Tasks.Task<HttpResponseMessage> Post(string url, string body, string contenttype)
        {
            using (var client = new HttpClient())
            {
                return await client.PostAsync(url, new StringContent(body, System.Text.Encoding.UTF8, contenttype));
            }
        }

        [Metadata("PUT", "HTTP PUT")]
        [HttpPut, Route("api/http")]
        public async System.Threading.Tasks.Task<HttpResponseMessage> Get(string url, string body, string contenttype)
        {
            using (var client = new HttpClient())
            {
                return await client.PutAsync(url, new StringContent(body, System.Text.Encoding.UTF8, contenttype));
            }
        }

      
    
    }
}
