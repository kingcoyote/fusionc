using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class DemoDialog
    {
        /// <summary> 
        ///   Required method for user interface initialization -
        ///   do modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _helloWorldLabel = new LabelControl();
            _okButton = new ButtonControl();
            _cancelButton = new ButtonControl();
            //
            // helloWorldLabel
            //
            _helloWorldLabel.Text = "Hello World! This is a label.";
            _helloWorldLabel.Bounds = new UniRectangle(10.0f, 15.0f, 110.0f, 30.0f);
            //
            // okButton
            //
            _okButton.Bounds = new UniRectangle(
              new UniScalar(1.0f, -180.0f), new UniScalar(1.0f, -40.0f), 80, 24
            );
            //
            // cancelButton
            //
            _cancelButton.Bounds = new UniRectangle(
              new UniScalar(1.0f, -90.0f), new UniScalar(1.0f, -40.0f), 80, 24
            );
            //
            // DemoDialog
            //
            Bounds = new UniRectangle(0.0f, 0.0f, 250.0f, 125.0f);
            Children.Add(_helloWorldLabel);
            Children.Add(_okButton);
            Children.Add(_cancelButton);
        }

        /// <summary>A label used to display a 'hello world' message</summary>
        private LabelControl _helloWorldLabel;
        /// <summary>Button which exits the dialog and takes over the settings</summary>
        private ButtonControl _okButton;
        /// <summary>Button which exits the dialog and discards the settings</summary>
        private ButtonControl _cancelButton;
    }
}
