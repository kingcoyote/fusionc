﻿using System.Linq;
using Microsoft.Xna.Framework;
using Nuclex.Game.States;
using Nuclex.Input;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;
using Nuclex.UserInterface.Visuals.Flat;

namespace FusionC
{
    abstract class FusionGameState : DrawableGameState
    {
        protected GuiManager Gui;
        protected FusionGame Game;
        protected GameComponentCollection Components;

        protected FusionGameState(FusionGame game)
        {
            Game = game;

            Gui = new GuiManager(Game.Graphics, Game.Input)
            {
                Screen = new Screen(game.GraphicsDevice.Viewport.Width, game.GraphicsDevice.Viewport.Height)
            };

            Gui.Screen.Desktop.Bounds = new UniRectangle(
              new UniScalar(0.0F, 25.0F), new UniScalar(0.0F, 25.0F),
              new UniScalar(1.0f, -50.0F), new UniScalar(1.0f, -50.0F)
            );

            Gui.Initialize();

            Gui.Visualizer = FlatGuiVisualizer.FromFile(game.Services, "Content/menu_gui.xml");
            ((FlatGuiVisualizer)Gui.Visualizer).RendererRepository.AddAssembly(typeof(FlatImageButtonControlRenderer).Assembly);
            ((FlatGuiVisualizer)Gui.Visualizer).RendererRepository.AddAssembly(typeof(FlatTiledIconControlRenderer).Assembly);

            Gui.UpdateOrder = 1000;

            Components = new GameComponentCollection { Gui };
        }

        public virtual void EndState()
        {
            Game.EndState();
        }

        public override void Draw(GameTime gametime)
        {
            foreach(var component in (from IDrawable c in Components orderby c.DrawOrder select c).ToArray())
            {
                component.Draw(gametime);
            }
        }

        public override void Update(GameTime gametime)
        {
            foreach(var component in (from IUpdateable c in Components orderby c.UpdateOrder select c).ToArray())
            {
                component.Update(gametime);
            }
        }
    }
}
