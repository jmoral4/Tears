using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tears.Entities
{
    abstract class BaseEntity
    {
        public Guid ObjectId { get; set; }
        public string Name { get; set; }

    }
}
