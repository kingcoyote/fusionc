using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.Input;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    public partial class MainMenuDialog : WindowControl
    {
        public EventHandler OnStartButtonPressed;
        public EventHandler OnHelpButtonPressed;
        public EventHandler OnHighScoresButtonPressed;
        public EventHandler OnExitButtonPressed;
        
        public MainMenuDialog()
        {
            InitializeComponent();

            _startButton.Pressed += (sender, args) => OnStartButtonPressed.Invoke(sender, args);
            _exitButton.Pressed += (sender, args) => OnExitButtonPressed.Invoke(sender, args);
        }
    }
}
