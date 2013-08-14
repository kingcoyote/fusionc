using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class CombatWaveDialog : WindowControl
    {
        private CombatGameState _gameState;

        public CombatWaveDialog(CombatGameState gameState)
        {
            InitializeComponent();

            _gameState = gameState;
        }
    }
}
