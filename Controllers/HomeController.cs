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
            return new string[] { "product1", "product2" };
        }

        //Get Product By ID
        [HttpGet("{id}")]
        public string Get (int id)
        {
            return "product";
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


    


    }
}


//private readonly ILogger<HomeController> _logger;

//public HomeController(ILogger<HomeController> logger)
//{
//    _logger = logger;
//}

//public IActionResult Index()
//{
//    return View();
//}

//public IActionResult Privacy()
//{
//    return View();
//}

//[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//public IActionResult Error()
//{
//    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//}

