using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestRepository.Dto;
using TestRepository.Entities;
using TestRepository.Interfaces;
using TestRepository.Mappers;
using TestRepository.Reposories;
using TestRepository.Services;

namespace TestRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserService userService) : ControllerBase
    {
        private readonly UserService _db = userService;
        [HttpGet("GetUserById")]
        public async Task<User> GetUserById(long id)
        {
            return await _db.GetUserById(id);
        }
        [HttpGet("GetUserByLogin")]
        public async Task<User> GetUserByLogin(string login)
        {
            return await _db.GetUserByLogin(login);
        }
        [HttpPost("AddNewUser")]
        public async  Task CreateUser(UserDto userDto)
        {
            await _db.CreateUser(userDto);
        }
        [HttpDelete("DeleteUserByLogin")]
        public async  Task DeleteUserByLogin(string login)
        {
            await _db.DeleteUserByLogin(login);

        }
        [HttpDelete("DeleteUserById")]
        public async  Task DeleteUserByLogin(long id)
        {
            await _db.DeleteUserById(id);
        }
        
    }
}
