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

        public void TriggerHotbar(int i)
        {
            switch(i)
            {
                case 1:
                    // _cannonButton
                    break;
                case 2:
                    // _laserButton
                    break;
                case 3:
                    // _missileButton
                    break;
                case 4:
                    // _mgButton
                    break;
            }
        }
    }
}
