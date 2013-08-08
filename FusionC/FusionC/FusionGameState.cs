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
            
        }
    }
}
