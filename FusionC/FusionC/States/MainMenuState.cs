using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Nuclex.Game.States;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC.States
{
    class MainMenuState : DrawableGameState
    {
        public MainMenuState()
        {
            var button = new ButtonControl();
            button.Text = "Exit";
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(GameTime gameTime)
        {
            
        }
    }
}
