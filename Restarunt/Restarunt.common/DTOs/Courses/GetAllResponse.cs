using Restarunt.common.DTOs.Account;
using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.DTOs.Courses
{
    public class GetAllResponse : BaseResponse
    {
        public List<Course> Data { set; get; }
    }
}
