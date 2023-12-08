using Restarunt.common.DTOs.Account;
using Restarunt.common.DTOs.Courses;
using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.Repositories
{
    public  interface ICourseRepository
    {
        Task<bool> Create(Course corse);
        Task<List<Course>> GetAll(GetAllRequest request);

    }
}
