using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JujubaControle_API.Data;
using JujubaControle_API.Models.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JujubaControle_API.Controllers
{
[Route("api/[controller]")]
[ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext Context;
        public UsersController(DataContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await Context.User.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
                return Context.User.FirstOrDefault(x => x.Id == id);
        }


    }
}