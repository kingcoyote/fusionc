using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class ConfirmationDialog
    {
        private LabelControl _label;
        private ButtonControl _yesButton;
        private ButtonControl _noButton;

        private void InitializeComponent()
        {
            _label = new LabelControl();
            _yesButton = new ButtonControl();
            _noButton = new ButtonControl();

            Children.Add(_label);
            Children.Add(_yesButton);
            Children.Add(_noButton);

            //
            // label
            //
            _label.Bounds = new UniRectangle(25, 25, 500, 75);
            _label.Text = "";

            //
            // yesButton
            //
            _yesButton.Bounds = new UniRectangle(new UniScalar(1.0F, -85), new UniScalar(1.0F, -45), 70, 30);
            _yesButton.Text = "Yes";

            //
            // noButton
            //
            _noButton.Bounds = new UniRectangle(new UniScalar(1.0F, -160), new UniScalar(1.0F, -45), 70, 30);
            _noButton.Text = "No";

            Bounds = new UniRectangle(0, 0, 550, 150);
        }
    }
}
