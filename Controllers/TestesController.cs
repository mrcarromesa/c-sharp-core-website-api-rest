using System;
using System.Net.Http;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;

//http://www.macoratti.net/pageview.aspx?catid=37

//https://www.youtube.com/watch?v=but7jqjopKM

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestesController : ControllerBase
    {
        // GET: api/Testes
        [HttpPost("fogo/{id}")]
        public async Task<string> GetTestes(Product p)
        {
            //http://www.macoratti.net/15/09/mvc_mdlst1.htm
            if (ModelState.IsValid)
            {

            } else
            {
                HttpContext.Response.StatusCode = 400;
            }


            HttpContext.Response.StatusCode = 220;
            var a = await Task.FromResult<string>("z");
            return $"a {a} - {p.Title}";
        }


    }
}
