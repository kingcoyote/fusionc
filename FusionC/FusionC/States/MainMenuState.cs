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
        private FusionGame _game;

        public MainMenuState(FusionGame game)
        {
            _game = game;

            _gui = new GuiManager(_game.Graphics, new InputManager())
                {
                    Screen = new Screen(game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height)
                };

            _gui.Screen.Desktop.Bounds = new UniRectangle(
              new UniScalar(0.0f, 0.0f), new UniScalar(0.0f, 0.0f),
              new UniScalar(0.8f, 0.0f), new UniScalar(0.8f, 0.0f)
            );

            _gui.Screen.Desktop.Children.Add(new DemoDialog());

            _gui.Initialize();
        }

        protected override void OnResume()
        {
            _game.IsMouseVisible = true;
        }

        protected override void OnPause()
        {
            _game.IsMouseVisible = false;
        }

        public override void Update(GameTime gameTime)
        {
            _gui.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            _gui.Draw(gameTime);
        }
    }
}
