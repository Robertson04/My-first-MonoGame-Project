using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace My_first_MonoGame_Project
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D skeletonTexture;
        Texture2D firewizardTexture;
        Texture2D icewizardTexture;
        Texture2D ewizardTexture;
        Texture2D arenaTexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "My first MonoGame Project";
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            skeletonTexture = Content.Load<Texture2D>("skeleton");
            icewizardTexture = Content.Load<Texture2D>("ice (1)");
            firewizardTexture = Content.Load<Texture2D>("fire");
            ewizardTexture = Content.Load<Texture2D>("ewizard");
            arenaTexture = Content.Load<Texture2D>("arena");


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(arenaTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(skeletonTexture, new Vector2(650, 300), Color.White);
            _spriteBatch.Draw(icewizardTexture, new Vector2(160, 10), Color.White);
            _spriteBatch.Draw(firewizardTexture, new Vector2(320, 80), Color.White);
            _spriteBatch.Draw(ewizardTexture, new Vector2(515, 100), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
