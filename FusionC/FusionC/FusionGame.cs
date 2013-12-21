using FusionC.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Nuclex.Game.States;
using Nuclex.Input;
using Nuclex.UserInterface;

namespace FusionC
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class FusionGame : Game
    {
        public GraphicsDeviceManager Graphics { get; private set; }
        SpriteBatch _spriteBatch;

        private GameStateManager _gsm;
        public readonly InputManager Input;

        public FusionGame()
        {
            Graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            Graphics.PreferredBackBufferWidth = 1024;
            Graphics.PreferredBackBufferHeight = 768;

            _gsm = new GameStateManager();

            Input = new InputManager(Services);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            _gsm.Push(new MainMenuState(this));

            _gsm.Initialize();

            Services.AddService(typeof(ContentManager), Content);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            Services.AddService(typeof(SpriteBatch), new SpriteBatch(GraphicsDevice));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            Input.Update();

            _gsm.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _gsm.Draw(gameTime);

            base.Draw(gameTime);
        }

        public void StartGame()
        {
            _gsm.Push(new CombatGameState(this));
        }

        public void EndState()
        {
            _gsm.Pop();
        }
    }
}
