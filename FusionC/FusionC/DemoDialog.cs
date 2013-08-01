using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    /// <summary>Dialog that demonstrates the capabilities of the GUI library</summary>
    public partial class DemoDialog : WindowControl
    {

        /// <summary>Initializes a new GUI demonstration dialog</summary>
        public DemoDialog()
        {
            InitializeComponent();
        }

        /// <summary> 
        ///   Required method for user interface initialization -
        ///   do modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloWorldLabel = new Nuclex.UserInterface.Controls.LabelControl();
            this.okButton = new Nuclex.UserInterface.Controls.Desktop.ButtonControl();
            this.cancelButton = new Nuclex.UserInterface.Controls.Desktop.ButtonControl();
            //
            // helloWorldLabel
            //
            this.helloWorldLabel.Text = "Hello World! This is a label.";
            this.helloWorldLabel.Bounds = new UniRectangle(10.0f, 15.0f, 110.0f, 30.0f);
            //
            // okButton
            //
            this.okButton.Bounds = new UniRectangle(
              new UniScalar(1.0f, -180.0f), new UniScalar(1.0f, -40.0f), 80, 24
            );
            //
            // cancelButton
            //
            this.cancelButton.Bounds = new UniRectangle(
              new UniScalar(1.0f, -90.0f), new UniScalar(1.0f, -40.0f), 80, 24
            );
            //
            // DemoDialog
            //
            this.Bounds = new UniRectangle(100.0f, 100.0f, 512.0f, 384.0f);
            Children.Add(this.helloWorldLabel);
            Children.Add(this.okButton);
            Children.Add(this.cancelButton);
        }

        /// <summary>A label used to display a 'hello world' message</summary>
        private Nuclex.UserInterface.Controls.LabelControl helloWorldLabel;
        /// <summary>Button which exits the dialog and takes over the settings</summary>
        private Nuclex.UserInterface.Controls.Desktop.ButtonControl okButton;
        /// <summary>Button which exits the dialog and discards the settings</summary>
        private Nuclex.UserInterface.Controls.Desktop.ButtonControl cancelButton;

    }
}
