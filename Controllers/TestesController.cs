using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.database;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

//http://www.macoratti.net/pageview.aspx?catid=37

//https://www.youtube.com/watch?v=but7jqjopKM

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("lista")]
        public List<People> GetPeoples()
        {
            var list = _context.Peoples.ToList();
            return list;
        }

        [HttpDelete("remove/{id:int}")]
        public async Task<bool> removeItem(int id)
        {
            var people = new People { PeopleID = 1 };
            _context.Remove(people);
            await _context.SaveChangesAsync();

            return true;
        }

        [HttpPut("update/{id:int}")]
        public bool editItem(int id, People newpeople)
        {
            var p_old = _context.Peoples.SingleOrDefault(p => p.PeopleID == id);
            newpeople.PeopleID = id;
            if (p_old != null)
            {
                p_old.Nome = newpeople.Nome;
                _context.SaveChanges();
            }
            return true;
        }

        // GET: api/Testes
        [HttpPost("fogo/{id}")]
        public async Task<string> GetTestes(string id, Product p)
        {
            //http://www.macoratti.net/15/09/mvc_mdlst1.htm
            if (ModelState.IsValid)
            {

            } else
            {
                HttpContext.Response.StatusCode = 400;
            }

            
                // seeding database
                _context.Peoples.Add(new People { Nome = $"Rodolfo - {id}" });
                _context.SaveChanges();
            


            /*
            string connStr = "server=127.0.0.1;user=root;database=sequelize;port=3306;password=123456";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM People";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            */

            HttpContext.Response.StatusCode = 220;
            var a = await Task.FromResult<string>("z");
            return $"a {a} - {p.Title}";
        }


    }
}
