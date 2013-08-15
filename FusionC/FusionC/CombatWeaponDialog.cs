using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class CombatWeaponDialog : WindowControl
    {
        private CombatGameState _gameState;

        public CombatWeaponDialog(CombatGameState gameState)
        {
            InitializeComponent();

            _gameState = gameState;
        }
    }
}
