namespace GraphicsDeviceTest
{
    class Program
    {
        static void Main()
        {
            using (var myGame = new MyGame())
            {
                myGame.Run();
            }
        }
    }
}
