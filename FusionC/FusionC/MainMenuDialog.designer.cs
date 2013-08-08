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

            Children.Add(_startButton);
            Children.Add(_helpButton);
            Children.Add(_highscoresButton);
            Children.Add(_exitButton);

            // 
            // _startButton
            //
            _startButton.Bounds = new UniRectangle(25, 25, 150, 40);
            _startButton.Text = "Start";

            //
            // _helpButton
            //
            _helpButton.Bounds = new UniRectangle(25, 70, 150, 40);
            _helpButton.Text = "Help";

            //
            // _highscoresButton
            //
            _highscoresButton.Bounds = new UniRectangle(25, 115, 150, 40);
            _highscoresButton.Text = "High Scores";

            //
            // _exitButton
            //
            _exitButton.Bounds = new UniRectangle(25, 335, 150, 40);
            _exitButton.Text = "Exit";

            Bounds = new UniRectangle(0, 0, 200, 400);
            EnableDragging = false;
        }

        private ButtonControl _startButton;
        private ButtonControl _helpButton;
        private ButtonControl _highscoresButton;
        private ButtonControl _exitButton;
    }
}
