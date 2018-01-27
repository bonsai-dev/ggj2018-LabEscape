using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ggj2018
{
    public class LabEscapeGame: Game
    {

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D texture;
        Vector2 position;
        float xSpeed;
        float ySpeed;
        GameScreen menuScreen;
        GameScreen testScreen;

        public LabEscapeGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            position = new Vector2(0, 0);
            xSpeed = 128f;
            ySpeed = 128f;
            menuScreen = new MenuScreen(this);
            testScreen = new TestScreen(this);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //texture = new Texture2D(this.GraphicsDevice, 100, 100);
            //Color[] colorData = new Color[100 * 100];
            //for (int i = 0; i < 10000; i++)
            //{
            //    float ratio = i / 10000f;
            //    colorData[i] = new Color(1-ratio, ratio, ratio);
            //}
            //texture.SetData<Color>(colorData);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = this.Content.Load<Texture2D>("Player_Scientist_01_Down");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            int deltaMillis = gameTime.ElapsedGameTime.Milliseconds;
            KeyboardState kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(Keys.Escape))
                Exit();

            if(kbState.IsKeyDown(Keys.W))
            {
                position.Y -= 1 * ySpeed * deltaMillis / 1000;
            }
            if (kbState.IsKeyDown(Keys.S))
            {
                position.Y += 1 * ySpeed * deltaMillis / 1000;
            }
            if (kbState.IsKeyDown(Keys.A))
            {
                position.X -= 1 * xSpeed * deltaMillis / 1000;
            }
            if (kbState.IsKeyDown(Keys.D))
            {
                position.X += 1 * xSpeed * deltaMillis / 1000;
            }
            if (position.X > this.GraphicsDevice.Viewport.Width)
            {
                position.X = 0 - texture.Width;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
