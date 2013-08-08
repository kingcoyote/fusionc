using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace FusionC
{
    class CombatGameState : FusionGameState
    {
        public CombatGameState(FusionGame game) : base(game)
        {
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gametime)
        {
            base.Update(gametime);

            if(Input.GetKeyboard().GetState().IsKeyDown(Keys.Escape))
            {
                EndState();
            }
        }
    }
}
