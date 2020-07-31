using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreWithSwag.Models;

namespace CoreWithSwag.Controllers
{

    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        //GET ALL PRODUCTS
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Regular Broadband", "Fibre Broadband", "Broadband & TV", "Broadband, TV and Calls" };
        }

        //Get Product By ID
        [HttpGet("{id}")]
        public string Get (int id)
        {
            return "You have selected this Talk-Talk product, enjoy!";
        }

        //POST PRODUCT
        [HttpPost]
        public void Post([FromBody]string product)
        {

        }

        //UPDATEPRODUCT LIST
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string product)
        {

        }

        //DELETE PRODUCT FROM LIST
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

        //----------------------------------------------------------

        




    }

    

}


