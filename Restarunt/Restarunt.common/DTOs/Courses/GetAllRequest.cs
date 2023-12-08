using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.DTOs.Courses
{
    public class GetAllRequest
    {
        public int pageIndex { get; set; }

        public int pageSize { get; set; }
    }
}
