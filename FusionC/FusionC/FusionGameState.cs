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
        protected InputManager Input;

        public FusionGameState(FusionGame game)
        {
            Game = game;
            Input = new InputManager(game.Services);
        }

        public virtual void EndState()
        {
            Game.EndState();
        }

        public override void Draw(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gametime)
        {
            Input.Update();
        }
    }
}
