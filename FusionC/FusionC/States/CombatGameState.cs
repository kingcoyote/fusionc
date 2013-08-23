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

            var graphics = (GraphicsDeviceManager) game.Services.GetService(typeof (IGraphicsDeviceManager));

            _playerShip = new PlayerShip(game.Services);
            _playerShip.Initialize();
            _playerShip.X = graphics.GraphicsDevice.Viewport.TitleSafeArea.Width/2;
            _playerShip.Y = graphics.GraphicsDevice.Viewport.TitleSafeArea.Height - 150;

            Components.Add(_playerShip);
        }

        private void InitializeComponent()
        {
            _combatPlayerDialog = new CombatPlayerDialog(this);
            _combatScoreDialog = new CombatScoreDialog(this);
            _combatWeaponDialog = new CombatWeaponDialog(this);

            _combatScoreDialog.Bounds.Location = new UniVector(0, 0);

            _combatPlayerDialog.Bounds.Location = new UniVector(
                0,
                new UniScalar(1.0F, 0 - _combatPlayerDialog.Bounds.Size.Y.Offset)
            );

            _combatWeaponDialog.Bounds.Location = new UniVector(
                new UniScalar(1.0F, 0 - _combatWeaponDialog.Bounds.Size.X.Offset), 
                0
            );

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
