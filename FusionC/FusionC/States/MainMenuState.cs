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
            mainMenuDialog.Bounds.Location.X = Gui.Screen.Desktop.Bounds.Size.X - mainMenuDialog.Bounds.Size.X;
            mainMenuDialog.Bounds.Location.Y = Gui.Screen.Desktop.Bounds.Size.Y - mainMenuDialog.Bounds.Size.Y;
            mainMenuDialog.OnExitButtonPressed += ExitConfirmation;
            mainMenuDialog.OnStartButtonPressed += (sender, args) => game.StartGame();

            Gui.Screen.Desktop.Children.Add(mainMenuDialog);

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

            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
