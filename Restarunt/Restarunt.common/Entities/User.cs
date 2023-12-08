using Restarunt.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.Entities
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public Enumerations.Role Role { get; set; }
      

    }
}
