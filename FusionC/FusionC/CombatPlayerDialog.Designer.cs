using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls;

namespace FusionC
{
    partial class CombatPlayerDialog
    {
        private ProgressControl _healthbar;

        private void InitializeComponent()
        {
            _healthbar = new ProgressControl();
            _healthbar.Bounds = new UniRectangle(
                new UniScalar(0.0F, 15),    
                new UniScalar(0.0F, 15),
                new UniScalar(1.0F, -30),
                new UniScalar(1.0F, -30)
            );
            _healthbar.Progress = 0.5F;

            Children.Add(_healthbar);

            Bounds = new UniRectangle(
                new UniScalar(0.0F, 0.0F), new UniScalar(0.0F, 0.0F), 
                new UniScalar(1.0F, 0.0F), new UniScalar(0.0F, 65.0F)
            );
            EnableDragging = false;
        }
    }
}
