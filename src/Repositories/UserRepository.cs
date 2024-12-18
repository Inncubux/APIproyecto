using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.src.Data;
using API.src.DTOs;
using API.src.Interfaces;

namespace API.src.Repositories
{
    public class UserRepository(ApplicationDBContext dBContext) : iUserRepository
    {
        public Task<UserDto> CreateStudent(CreateStudentDto student)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}