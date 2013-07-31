using System;

namespace FusionC
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (FusionGame game = new FusionGame())
            {
                game.Run();
            }
        }
    }
#endif
}

