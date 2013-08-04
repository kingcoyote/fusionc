using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

using Nuclex.UserInterface.Visuals.Flat;

namespace FusionC.States
{
    class MainMenuState : FusionGameState
    {
        public MainMenuState(FusionGame game) : base(game)
        {
            var mainMenuDialog = new MainMenuDialog();
            mainMenuDialog.Bounds.Location.X = game.GraphicsDevice.Viewport.TitleSafeArea.Width - 25 - mainMenuDialog.Bounds.Size.X;
            mainMenuDialog.Bounds.Location.Y = game.GraphicsDevice.Viewport.TitleSafeArea.Height - 25 - mainMenuDialog.Bounds.Size.Y;

            Gui.Screen.Desktop.Children.Add(mainMenuDialog);

            Gui.Visualizer = FlatGuiVisualizer.FromFile(game.Services, "Content/menu_gui.xml");

            Game.IsMouseVisible = true;
        }
    }
}
