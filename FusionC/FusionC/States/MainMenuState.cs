using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nuclex.Input;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Visuals.Flat;

namespace FusionC.States
{
    class MainMenuState : FusionGameState
    {
        private SpriteBatch _spriteBatch;
        private Texture2D _menuBg;

        public MainMenuState(FusionGame game) : base(game)
        {
            var mainMenuDialog = new MainMenuDialog();
            mainMenuDialog.Bounds.Location.X = game.GraphicsDevice.Viewport.TitleSafeArea.Width - 25 - mainMenuDialog.Bounds.Size.X;
            mainMenuDialog.Bounds.Location.Y = game.GraphicsDevice.Viewport.TitleSafeArea.Height - 25 - mainMenuDialog.Bounds.Size.Y;

            Gui = new GuiManager(Game.Graphics, new InputManager())
            {
                Screen = new Screen(game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height)
            };

            Gui.Screen.Desktop.Bounds = new UniRectangle(
              new UniScalar(0.0f, 0.0f), new UniScalar(0.0f, 0.0f),
              new UniScalar(0.8f, 0.0f), new UniScalar(0.8f, 0.0f)
            );

            Gui.Initialize();

            Gui.Screen.Desktop.Children.Add(mainMenuDialog);

            Gui.Visualizer = FlatGuiVisualizer.FromFile(game.Services, "Content/menu_gui.xml");

            Game.IsMouseVisible = true;

            _spriteBatch = new SpriteBatch(game.GraphicsDevice);
            _menuBg = Game.Content.Load<Texture2D>("menu_bg");
        }

        public override void Draw(GameTime gameTime)
        {
            
            
            _spriteBatch.Begin();
            _spriteBatch.Draw(_menuBg, new Vector2(0, 0), Color.White);
            _spriteBatch.End();

            Gui.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}
