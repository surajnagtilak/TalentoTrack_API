using Microsoft.Identity.Client;
using Restarunt.common.DTOs.Account;
using Restarunt.common.DTOs.service;
using Restarunt.common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Restarunt.Services
{
    public class AccountService : IAccountService
    {
        public readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<LoginResponse>verifylogindetails(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {
               var dbuser= await _accountRepository.getlogindetails(request.UserName!, request.Password!);
                if(dbuser == null)
                {
                    response.Success = false;
                    response.Error = "Invalid";
                }
                else
                {
                    response.Success = true;
                }
                return response;
            }
            catch(Exception exp) 
            {
                throw;
            }


        }
        
    }


}
