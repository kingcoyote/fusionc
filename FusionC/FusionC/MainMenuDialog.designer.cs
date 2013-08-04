using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    public partial class MainMenuDialog
    {
        private void InitializeComponent()
        {
            _startButton = new ButtonControl();
            _helpButton = new ButtonControl();
            _highscoresButton = new ButtonControl();
            _exitButton = new ButtonControl();

            //Children.Add(_startButton);
            //Children.Add(_helpButton);
            //Children.Add(_highscoresButton);
            //Children.Add(_exitButton);

            // 
            // _startButton
            //

            //
            // _helpButton
            //

            //
            // _highscoresButton
            //

            //
            // _exitButton
            //

            Bounds = new UniRectangle(0, 0, 200, 400);
        }

        private ButtonControl _startButton;
        private ButtonControl _helpButton;
        private ButtonControl _highscoresButton;
        private ButtonControl _exitButton;
    }
}
