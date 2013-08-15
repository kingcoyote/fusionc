using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    class CombatGameState : FusionGameState
    {
        private StateList _gameState;
        private PlayerShip _playerShip;

        private int _wave;
        private int _playerLives;

        public CombatGameState(FusionGame game) : base(game)
        {
            _gameState = StateList.Countdown;
            _wave = 1;
            _playerLives = 3;

            _playerShip = new PlayerShip();

            WindowControl dialog;

            const int dialogPadding = 25;

            dialog = new CombatWaveDialog(this);
            dialog.Bounds.Location.X = dialogPadding;
            dialog.Bounds.Location.Y = dialogPadding;
            Gui.Screen.Desktop.Children.Add(dialog);

            dialog = new CombatPlayerDialog(this);
            dialog.Bounds.Location.X = dialogPadding;
            dialog.Bounds.Location.Y = Gui.Screen.Height - dialog.Bounds.Size.Y - dialogPadding;
            Gui.Screen.Desktop.Children.Add(dialog);

            dialog = new CombatScoreDialog(this);
            dialog.Bounds.Location.X = Gui.Screen.Width - dialog.Bounds.Size.X - dialogPadding;
            dialog.Bounds.Location.Y = Gui.Screen.Height - dialog.Bounds.Size.Y - dialogPadding;
            Gui.Screen.Desktop.Children.Add(dialog);

            dialog = new CombatWeaponDialog(this);
            dialog.Bounds.Location.X = Gui.Screen.Width - dialog.Bounds.Size.X - dialogPadding;
            dialog.Bounds.Location.Y = dialogPadding;
            Gui.Screen.Desktop.Children.Add(dialog);
        }

        public override void Update(GameTime gametime)
        {
            base.Update(gametime);

            UpdateGameState(gametime);
        }

        private void UpdateGameState(GameTime gametime)
        {
            switch(_gameState)
            {
                case StateList.Countdown:
                    break;
                case StateList.Action:
                    break;
                case StateList.Shop:
                    break;
                case StateList.Pause:
                    break;
            }
        }

        enum StateList
        {
            Countdown,
            Action,
            Shop,
            Pause
        }
    }
}
