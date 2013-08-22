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

        private CombatWaveDialog _combatWaveDialog;
        private CombatPlayerDialog _combatPlayerDialog;
        private CombatScoreDialog _combatScoreDialog;
        private CombatWeaponDialog _combatWeaponDialog;

        private int _countdownTimer;

        public CombatGameState(FusionGame game) : base(game)
        {
            InitializeComponent();
            
            _gameState = StateList.Countdown;
            _wave = 1;
            _playerLives = 3;
            _countdownTimer = 5000;

            _playerShip = new PlayerShip();
        }

        private void InitializeComponent()
        {
            _combatWaveDialog = new CombatWaveDialog(this);
            _combatPlayerDialog = new CombatPlayerDialog(this);
            _combatScoreDialog = new CombatScoreDialog(this);
            _combatWeaponDialog = new CombatWeaponDialog(this);

            _combatWaveDialog.Bounds.Location.X = 0;
            _combatWaveDialog.Bounds.Location.Y = 0;

            _combatPlayerDialog.Bounds.Location.X = 0;
            _combatPlayerDialog.Bounds.Location.Y = Gui.Screen.Desktop.Bounds.Size.Y - _combatPlayerDialog.Bounds.Size.Y;

            _combatScoreDialog.Bounds.Location.X = 0;
            _combatScoreDialog.Bounds.Location.Y = _combatWaveDialog.Bounds.Size.Y + 25;

            _combatWeaponDialog.Bounds.Location.X = Gui.Screen.Desktop.Bounds.Size.X - _combatWeaponDialog.Bounds.Size.X;
            _combatWeaponDialog.Bounds.Location.Y = 0;

            Gui.Screen.Desktop.Children.Add(_combatWaveDialog);
            Gui.Screen.Desktop.Children.Add(_combatPlayerDialog);
            Gui.Screen.Desktop.Children.Add(_combatScoreDialog);
            Gui.Screen.Desktop.Children.Add(_combatWeaponDialog);
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
                    _countdownTimer -= gametime.ElapsedGameTime.Milliseconds;
                    if(_countdownTimer <= 0)
                    {
                        _gameState = StateList.Action;
                    }
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
