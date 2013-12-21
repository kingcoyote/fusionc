using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class CombatPlayerDialog : WindowControl
    {
        private CombatGameState _gameState;

        public CombatPlayerDialog(CombatGameState gameState)
        {
            InitializeComponent();

            _gameState = gameState;
        }

        public void SetPlayerLives(int lives)
        {
            _playerlives.Count = lives;
        }
    }
}
