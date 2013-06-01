using Microsoft.Xna.Framework;

namespace GraphicsDeviceTest
{
    using System.Diagnostics;

    class MyGame : Game
    {
        public MyGame()
        {
            var graphicsDeviceManager = new GraphicsDeviceManager(this);
            graphicsDeviceManager.ApplyChanges();

            Debug.Assert(graphicsDeviceManager.GraphicsDevice != null);
        }
    }
}
