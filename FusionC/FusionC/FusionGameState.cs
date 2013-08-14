using Microsoft.Xna.Framework;
using Nuclex.Game.States;
using Nuclex.Input;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Visuals.Flat;

namespace FusionC
{
    abstract class FusionGameState : DrawableGameState
    {
        protected GuiManager Gui;
        protected FusionGame Game;

        public FusionGameState(FusionGame game)
        {
            Game = game;

            Gui = new GuiManager(Game.Graphics, Game.Input)
            {
                Screen = new Screen(game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height)
            };

            Gui.Screen.Desktop.Bounds = new UniRectangle(
              new UniScalar(0.0f, 0.0f), new UniScalar(0.0f, 0.0f),
              new UniScalar(0.8f, 0.0f), new UniScalar(0.8f, 0.0f)
            );

            Gui.Initialize();

            Gui.Visualizer = FlatGuiVisualizer.FromFile(game.Services, "Content/menu_gui.xml");
        }

        public virtual void EndState()
        {
            Game.EndState();
        }

        public override void Draw(GameTime gameTime)
        {
            Gui.Draw(gameTime);
        }

        public override void Update(GameTime gametime)
        {
            Gui.Update(gametime);
        }
    }
}
