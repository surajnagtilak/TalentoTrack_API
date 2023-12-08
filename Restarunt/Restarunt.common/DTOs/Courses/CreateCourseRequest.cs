using Restarunt.common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.DTOs.Courses
{
    public class CreateCourseRequest:BaseEntity
    {
        public string Name { get; set; }
        public double TotalFees { get; set; }

        public int DurationInDays { get; set; }
    }
}
