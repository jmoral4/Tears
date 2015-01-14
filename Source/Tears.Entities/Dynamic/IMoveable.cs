using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tears.Entities.Dynamic
{
    public interface IMoveable
    {
        Vector2 Direction { get; set; }
    }
}
