using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Tears.Components.General;

namespace Tears.Components.Rendering
{
    /// <summary>
    /// The scenegraph handles sorted rendering of all objects in the scene from back-to front
    /// Each Screen may have its own scenegraph to handle ordeed rendering within its own context
    /// The Screen is responsible for calling Reset() within its Update() method (if needed)
    /// Reset is primarily used to ensure that dead objects are purged. For instance, if using 
    /// short-lifetime objects like projectiles, you want to ensure that they're removed from the screen 
    //  when their object lifetime has ended
    /// </summary>
    public class SceneGraph
    {
        //private ScreenManager ScreenManagerRef; //may not be needed
        readonly List<IRenderable> _renderableObjects;

        public SceneGraph()
        {
            _renderableObjects = new List<IRenderable>();
        }

        public void Reset()
        {
            // called on the update loop to clear all renderableObjects and insert any new living objects
            _renderableObjects.Clear();
        }

        public void AddRenderable(IRenderable renderable)
        {
            _renderableObjects.Add(renderable);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //sorted back to front using Icomparables interface
            //back depth is 0, front depth is anything greater than 0
            _renderableObjects.Sort();
            spriteBatch.Begin();
            foreach (var r in _renderableObjects)
                spriteBatch.Draw(r.Texture, r.Source, r.Destination, r.Color);
            spriteBatch.End();
        }


    }
}
