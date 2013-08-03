using Microsoft.Xna.Framework;
using Nuclex.Game.States;
using Nuclex.Input;
using Nuclex.UserInterface;

namespace FusionC
{
    abstract class FusionGameState : DrawableGameState
    {
        protected GuiManager Gui;
        protected FusionGame Game;

        public FusionGameState(FusionGame game)
        {
            Game = game;

            Gui = new GuiManager(Game.Graphics, new InputManager())
                {
                    Screen = new Screen(game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height)
                };

            Gui.Screen.Desktop.Bounds = new UniRectangle(
              new UniScalar(0.0f, 0.0f), new UniScalar(0.0f, 0.0f),
              new UniScalar(0.8f, 0.0f), new UniScalar(0.8f, 0.0f)
            );

            Gui.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            Gui.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Gui.Draw(gameTime);
        }
    }
}
