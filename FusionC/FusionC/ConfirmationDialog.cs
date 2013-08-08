using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class ConfirmationDialog : WindowControl
    {
        public EventHandler OnConfirm;
        public bool Confirm;

        public ConfirmationDialog(string text)
        {
            InitializeComponent();

            _label.Text = text;

            _yesButton.Pressed += (sender, args) =>
                {
                    Confirm = true;
                    OnConfirm.Invoke(sender, args);
                };
            _noButton.Pressed += (sender, args) =>
                {
                    Confirm = false;
                    OnConfirm.Invoke(sender, args);
                };

            EnableDragging = false;
        }
    }
}
