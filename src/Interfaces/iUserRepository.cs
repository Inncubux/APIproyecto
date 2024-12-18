using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.src.DTOs;

namespace API.src.Interfaces
{
    public interface iUserRepository
    {

        Task<UserDto> CreateStudent(CreateStudentDto student);
        Task<List<UserDto>> GetStudents();
    }
}