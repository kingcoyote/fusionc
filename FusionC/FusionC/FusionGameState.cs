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
        protected GameComponentCollection Components;

        public FusionGameState(FusionGame game)
        {
            Game = game;
            Components = new GameComponentCollection();
        }

        public override void Draw(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gametime)
        {
            
        }
    }
}
