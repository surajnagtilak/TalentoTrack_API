using Microsoft.EntityFrameworkCore;
using Restarunt.common.DTOs.Account;
using Restarunt.Dao.DB;
using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restarunt.common.Repositories;
using Azure.Core;
using Restarunt.common.DTOs.Courses;

namespace Restarunt.Dao.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Restarunt_DbContext _dbContext;
        public CourseRepository(Restarunt_DbContext dbContext) {
        _dbContext=dbContext;
        }
        public async Task<bool> Create(Course corse)
        {
            _dbContext.tbl_Courses.Add(corse);
            bool result=await  _dbContext.SaveChangesAsync()>0;
            
            return result;
        }

        public async Task<List<Course>> GetAll(GetAllRequest request)
        {
           var result = await _dbContext.tbl_Courses.ToListAsync();

            return result;
        }
    }
}
