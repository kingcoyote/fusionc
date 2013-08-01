using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nuclex.Game.States;
using Nuclex.Input;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC.States
{
    class MainMenuState : DrawableGameState
    {
        private GuiManager _gui;

        public MainMenuState(IGraphicsDeviceService graphics, GraphicsDevice gd)
        {
            _gui = new GuiManager(graphics, new InputManager());

            var mainScreen = new Screen(gd.Viewport.Width, gd.Viewport.Height);

            _gui.Screen = mainScreen;

            mainScreen.Desktop.Bounds = new UniRectangle(
              new UniScalar(0.0f, 0.0f), new UniScalar(0.0f, 0.0f),
              new UniScalar(0.8f, 0.0f), new UniScalar(0.8f, 0.0f)
            );

            mainScreen.Desktop.Children.Add(new DemoDialog());
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(GameTime gameTime)
        {
            _gui.Draw(gameTime);
        }
    }
}
