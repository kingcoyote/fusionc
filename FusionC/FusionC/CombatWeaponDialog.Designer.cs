using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;

namespace FusionC
{
    partial class CombatWeaponDialog
    {
        private ImageButtonControl _cannonButton;
        private ImageButtonControl _missileButton;
        private ImageButtonControl _laserButton;
        private ImageButtonControl _mgButton;

        private void InitializeComponent()
        {
            _cannonButton = new ImageButtonControl();
            _laserButton = new ImageButtonControl();
            _missileButton = new ImageButtonControl();
            _mgButton = new ImageButtonControl();

            // cannon
            _cannonButton = new ImageButtonControl();
            _cannonButton.Bounds = new UniRectangle(
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50), 
                new UniScalar(0.0F, 50)
            );
            _cannonButton.ImageFrame = "hotbar.cannon";

            // laser
            _laserButton = new ImageButtonControl();
            _laserButton.Bounds = new UniRectangle(
                new UniScalar(0.0F, 80),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50),
                new UniScalar(0.0F, 50)
            );
            _laserButton.ImageFrame = "hotbar.laser";

            // missile
            _missileButton = new ImageButtonControl();
            _missileButton.Bounds = new UniRectangle(
                new UniScalar(0.0F, 145),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50),
                new UniScalar(0.0F, 50)
            );
            _missileButton.ImageFrame = "hotbar.missile";

            // machine gun
            _mgButton = new ImageButtonControl();
            _mgButton.Bounds = new UniRectangle(
                new UniScalar(0.0F, 210),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50),
                new UniScalar(0.0F, 50)
            );
            _mgButton.ImageFrame = "hotbar.mg";

            Children.Add(_cannonButton);
            Children.Add(_laserButton);
            Children.Add(_missileButton);
            Children.Add(_mgButton);

            Bounds = new UniRectangle(
                new UniScalar(0.0F, 0.0F), new UniScalar(0.0F, 0.0F),
                new UniScalar(0.0F, 275.0F), new UniScalar(0.0F, 80F)
            );
            EnableDragging = false;
        }
    }
}
