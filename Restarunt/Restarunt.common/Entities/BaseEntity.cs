using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restarunt.common.Entities
{
    public class BaseEntity
    {
        public int id { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public int CreatedById { get; set; }

        public int? UpdatedById { get; set; }

    }
}
