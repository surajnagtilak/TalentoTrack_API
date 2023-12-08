using Microsoft.AspNetCore.Mvc;
using Restarunt.common.DTOs.Account;
using Restarunt.common.DTOs.service;
using Restarunt.common.Entities;

namespace Restarunt.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
       

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        public AccountController(ILogger<AccountController> logger,IAccountService accountService)
         
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost(Name = "Login")]
        public async Task<LoginResponse> Login([FromBody]LoginRequest request)
        {
            var response= await _accountService.verifylogindetails(request);
            return response;
        }
    }
}
// just for practice
