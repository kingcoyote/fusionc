using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Nuclex.Game;

namespace FusionC
{
    class PlayerShip : GraphicsDeviceDrawableComponent
    {
        private readonly Texture2D _ship;
        public float X;
        public float Y;

        private SpriteBatch _spriteBatch;

        public PlayerShip(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            var content = (ContentManager)serviceProvider.GetService(typeof(ContentManager));
            _ship = content.Load<Texture2D>("HammerFrames");
            _spriteBatch = (SpriteBatch) serviceProvider.GetService(typeof (SpriteBatch));
        }
        public PlayerShip(IGraphicsDeviceService graphicsDeviceService) : base(graphicsDeviceService) { }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Draw(
                _ship, 
                new Vector2(X - 50, Y - 40),
                new Rectangle(300, 0, 100, 80),
                Color.White
            );
        }
    }
}
