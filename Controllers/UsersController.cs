using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]

        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
             return users;
        }

        [HttpGet("{Id}")]
         public async Task<ActionResult<AppUsers>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;

        }



    }

  
}
