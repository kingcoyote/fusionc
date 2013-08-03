using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
namespace FusionC.States
{
    class MainMenuState : FusionGameState
    {
        public MainMenuState(FusionGame game) : base(game)
        {
            Gui.Screen.Desktop.Children.Add(new DemoDialog());
        }
    }
}
