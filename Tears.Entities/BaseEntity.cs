using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tears.Entities
{
    public abstract class BaseEntity
    {
        public Guid ObjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Rectangle Location { get; set; }
    }    
}
