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
        private void InitializeComponent()
        {
            Bounds = new UniRectangle(0, 0, 275, 80);
            EnableDragging = false;

            // create row of hotbar icons for the 4 weapon types:
            //   cannon
            //   laser
            //   missile
            //   machinegun

            ImageButtonControl hotkey;

            // cannon
            hotkey = new ImageButtonControl();
            hotkey.Bounds = new UniRectangle(
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50), 
                new UniScalar(0.0F, 50)
            );
            hotkey.Text = "CAN";
            Children.Add(hotkey);

            // laser
            hotkey = new ImageButtonControl();
            hotkey.Bounds = new UniRectangle(
                new UniScalar(0.0F, 80),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50),
                new UniScalar(0.0F, 50)
            );
            hotkey.Text = "LAS";
            Children.Add(hotkey);

            // missile
            hotkey = new ImageButtonControl();
            hotkey.Bounds = new UniRectangle(
                new UniScalar(0.0F, 145),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50),
                new UniScalar(0.0F, 50)
            );
            hotkey.Text = "MIS";
            Children.Add(hotkey);

            // machine gun
            hotkey = new ImageButtonControl();
            hotkey.Bounds = new UniRectangle(
                new UniScalar(0.0F, 210),
                new UniScalar(0.0F, 15),
                new UniScalar(0.0F, 50),
                new UniScalar(0.0F, 50)
            );
            hotkey.Text = "MG";
            Children.Add(hotkey);
        }
    }
}
