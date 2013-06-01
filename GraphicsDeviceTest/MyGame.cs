using Microsoft.Xna.Framework;

namespace GraphicsDeviceTest
{
    using System.Diagnostics;

    class MyGame : Game
    {
        GraphicsDeviceManager graphicsDevice;
        public MyGame()
        {
            graphicsDevice = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {

            graphicsDevice.ApplyChanges();

            Debug.Assert(graphicsDevice.GraphicsDevice != null);
            base.Initialize();
        }
    }
}
