using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tears.Components.Rendering
{
    /// <summary>
    /// Everything that is rendered to the screen inherits from IRenderable    
    /// </summary>

    public class Sprite : IRenderable
    {
        public Guid Id { get; private set; }
        public int Depth { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle Source { get; set; }
        public Rectangle Destination { get; set; }
        public Color Color { get; set; }

        public Sprite()
        {
            Id = Guid.NewGuid(); //generates a new unique ID for this sprite
        }

        public int CompareTo(IRenderable other)
        {
            return this.Depth.CompareTo(other.Depth);
        }
    }
}
