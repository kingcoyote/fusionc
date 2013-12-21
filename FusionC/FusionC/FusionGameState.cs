﻿using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nuclex.Game.States;
using Nuclex.Input;
using Nuclex.UserInterface;
using Nuclex.UserInterface.Controls.Desktop;
using Nuclex.UserInterface.Input;
using Nuclex.UserInterface.Visuals.Flat;

namespace FusionC
{
    abstract class FusionGameState : DrawableGameState
    {
        protected GuiManager Gui;
        protected FusionGame Game;
        protected GameComponentCollection Components;

        private IInputCapturer _capturer;
        private SpriteBatch _spriteBatch;

        protected FusionGameState(FusionGame game)
        {
            Game = game;

            _spriteBatch = (SpriteBatch) game.Services.GetService(typeof (SpriteBatch));

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
            _spriteBatch.Begin();

            foreach(var component in (from IDrawable c in Components orderby c.DrawOrder select c).ToArray())
            {
                component.Draw(gametime);
            }
            
            _spriteBatch.End();
        }

        public override void Update(GameTime gametime)
        {
            foreach(var component in (from IUpdateable c in Components orderby c.UpdateOrder select c).ToArray())
            {
                component.Update(gametime);
            }
        }

        protected override void OnPause()
        {
            Gui.Visible = false;
            _capturer = Gui.InputCapturer;
            Gui.InputCapturer = null;
        }

        protected override void OnResume()
        {
            Gui.Visible = true;
            Gui.InputCapturer = _capturer;
            _capturer = null;
        }
    }
}
