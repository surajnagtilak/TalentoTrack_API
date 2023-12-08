using Microsoft.EntityFrameworkCore;
using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.Dao.DB
{
    public class Restarunt_DbContext:DbContext
    {
        public DbSet<User> tbl_User { get; set; }

        public DbSet<LoginDetails> tbl_Login_Details { get; set; }

        public DbSet<Course> tbl_Courses { get; set; }

        public Restarunt_DbContext(DbContextOptions<Restarunt_DbContext> options) : base(options) { 
        
        }
    }
}
