﻿using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.Repositories
{
    public  interface IAccountRepository
    {
        Task<LoginDetails> getlogindetails(string Username, string Password);

    }
}
