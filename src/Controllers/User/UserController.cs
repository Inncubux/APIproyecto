using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.src.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.src.Controllers.User
{
    public class UserController(iUserRepository userRepository): BaseApiController
    {
        private readonly iUserRepository _userRepository = userRepository;

        [HttpGet("getStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _userRepository.GetStudents();
            return Ok(students);
        }
        
    }
}