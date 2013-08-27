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
        private TiledIconControl _playerlives;

        private void InitializeComponent()
        {
            _healthbar = new ProgressControl();
            _healthbar.Bounds = new UniRectangle(
                new UniScalar(0.0F, 15),    
                new UniScalar(0.0F, 15),
                new UniScalar(1.0F, -30),
                new UniScalar(0.0F, 30)
            );
            _healthbar.Progress = 0.5F;

            _playerlives = new TiledIconControl();
            _playerlives.Height = 1;
            _playerlives.Width = 10;
            _playerlives.Count = 3;
            _playerlives.ImageFrame = "playerlives";
            _playerlives.Bounds = new UniRectangle(50, 50, 500, 40);

            Children.Add(_healthbar);
            Children.Add(_playerlives);

            Bounds = new UniRectangle(
                new UniScalar(0.0F, 0.0F), new UniScalar(0.0F, 0.0F), 
                new UniScalar(1.0F, 0.0F), new UniScalar(0.0F, 95.0F)
            );
            EnableDragging = false;
        }
    }
}
