using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    public partial class MainMenuDialog : WindowControl
    {
        public MainMenuDialog()
        {
            InitializeComponent();

            _startButton.Pressed += StartGame;
        }

        private void StartGame(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
