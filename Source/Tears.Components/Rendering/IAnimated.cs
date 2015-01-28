﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Tears.Components.Rendering
{
    public interface IAnimated
    {
        void Update(GameTime elapsedTime);
    }
}
