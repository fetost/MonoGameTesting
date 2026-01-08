using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DungeonSlime;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics; // manages connection to the graphics hardware. 
    private SpriteBatch _spriteBatch; // optimizes 2D rendering 

    // The constructor will run first and will handle basic, general and more core system setup. 
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this); // for interacting with GPU
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    // Place for additional config and initializations. More game-specific. 
    // Initialize() is a virtual method that is overridden, and one should not call overridable mthods from within a constructor. 
    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize(); // should never be removed. 
    }

    // Load textures here, sound effects, music and game assets. 
    // Initialize() calls LoadContent() last, so if any initializations have dependency on assets, it has to done AFTER base.Initialize. 
    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    // Update() and Draw() is called over and over again until the game is told to quit. The loop is ran 60 times per second. 
    // Update() checks for controller or keyboard input to determine if the game should quit or not 
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.MonoGameOrange); // GraphicsDevice object is a direct interface between the game and what is rendered. 
        // Clear has to be called, otherwise every draw call would draw the new frame render on top of the last render. 

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}