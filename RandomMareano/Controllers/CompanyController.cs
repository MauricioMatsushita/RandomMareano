using Microsoft.AspNetCore.Mvc;
using RandomMareanoLibrary.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RandomMareano.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class CompanyController : ControllerBase
   {
      // GET: api/<CompanyController>
      [HttpGet]
      public RamdomCompany Get()
      {
         return new RamdomCompany();
      }

      

   }
}
