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
            mainMenuDialog.OnExitButtonPressed += ExitConfirmation;
            mainMenuDialog.OnStartButtonPressed += (sender, args) => game.StartGame();

            Gui = new GuiManager(Game.Graphics, Input)
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

        private void ExitConfirmation(object sender, EventArgs e)
        {
            var confirmDialog = new ConfirmationDialog("Are you sure you would like to exit?");

            confirmDialog.OnConfirm += (s, a) =>
                {
                    if(confirmDialog.Confirm == false)
                    {
                        Gui.Screen.Desktop.Children.Remove(confirmDialog);
                    }
                    else
                    {
                        Game.Exit();
                    }
                };

            Gui.Screen.Desktop.Children.Add(confirmDialog);

            confirmDialog.Bounds = new UniRectangle(
                (1024 - confirmDialog.Bounds.Size.X.Offset) / 2.0F,
                (768 - confirmDialog.Bounds.Size.Y.Offset) / 2.0F,
                confirmDialog.Bounds.Size.X.Offset,
                confirmDialog.Bounds.Size.Y.Offset
            );
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_menuBg, new Vector2(0, 0), Color.White);
            _spriteBatch.End();

            Gui.Draw(gameTime);

            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
            Gui.Update(gameTime);
        }
    }
}
