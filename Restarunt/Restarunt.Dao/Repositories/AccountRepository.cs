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

namespace Restarunt.Dao.Repositories
{
    public class AccountRepository:IAccountRepository
    {
        public Restarunt_DbContext _dbContext;
        public AccountRepository(Restarunt_DbContext dbContext) {
        _dbContext=dbContext;
        }
        public async Task<LoginDetails> getlogindetails(string Username, string Password)
        {
            var dbRecord = await _dbContext.tbl_Login_Details.Where(p => (p.UserName != null && p.UserName.Equals(Username)) && (p.Password != null && p.Password.Equals(Password))).FirstOrDefaultAsync();
            
            return dbRecord!;
        }
    }
}
