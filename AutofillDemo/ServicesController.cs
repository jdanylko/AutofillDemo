using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, 
// visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutofillDemo
{
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public List<string> Get(string id)
        {
            var partialCompanyName = id;

            // Create a repository to access your database here.
            // For now, we'll create a small list 
            //   of companies for demonstration purposes.
            var list = new List<string>
            {
                "Apple",
                "Microsoft",
                "Google",
                "MicroCenter",
                "Microtek",
                "MicroSystems"
            };

            var company = list.OrderBy(e => e).FirstOrDefault(e => 
                e.StartsWith(partialCompanyName));

            // if company is null, use an empty string.
            // Else, use the company. :-)
            return new List<string> { company ?? "" };
        }
    }
}
