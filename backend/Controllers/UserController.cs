using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UsersAPIDbContext DbCtx;
        public UserController(UsersAPIDbContext dbCtx)
        {
            this.DbCtx = dbCtx;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers() 
        {
            return  Ok(await DbCtx.Users.ToListAsync());
        }



        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserRequest request)
        {
            var User = new User()
            {
                username = request.username,
                password = request.password,
                fullName = request.fullName,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            };
            await DbCtx.Users.AddAsync(User);
            await DbCtx.SaveChangesAsync();
            return Ok(User);
        }
    }
}
