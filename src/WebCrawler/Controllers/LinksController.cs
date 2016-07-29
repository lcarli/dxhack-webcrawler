﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebCrawler.Controllers
{
    [Route("api/[controller]")]
    public class LinksController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> l = new List<string>();
            l.Add("http://bing.com");

            return l;
        }

        // GET api/values/5
        [HttpGet("{keyw}")]
        public string Get(string keyw)
        {
            return keyw.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
     
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
