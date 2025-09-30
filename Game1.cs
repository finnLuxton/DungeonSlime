using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace DungeonSlime;

//C3 Pop back into reasoning of Core
public class Game1 : Core
{
    
    // The GDM initializes and manages the connection to the graphics hardware.
    private GraphicsDeviceManager _graphics;
    // Helper class for drawing text strings and sprites in one or more optimized batches.
    private SpriteBatch _spriteBatch;

    // TODO - Look at updating template name to something more accurate once development is further along.
    
    // The separation of Game1() and Initialize() splits core systems and game specific initializations.
    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();

        // TODO: use this.Content to load your game content here
    }

    // Documentation says that this functions get called 60 times per second by default.
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Silver);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
