using System.Security.Principal;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace DungeonSlime;

//C3 Pop back into reasoning of Core
public class Game1 : Core
{
    // The GDM initializes and manages the connection to the graphics hardware.
    private GraphicsDeviceManager _graphics;
    // Helper class for drawing text strings and sprites in one or more optimized batches.
    private SpriteBatch _spriteBatch;

    private Texture2D _logo;
    private TextureRegion _slime;
    private TextureRegion _bat;
    
    
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
        TextureAtlas atlas = TextureAtlas.FromFile(Content, "images/atlas-definition.xml");

        _slime = atlas.GetRegion("slime");
        _bat = atlas.GetRegion("bat");
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
        // Clear the back buffer.
        GraphicsDevice.Clear(Color.WhiteSmoke);

        SpriteBatch.Begin(samplerState: SamplerState.PointClamp);
        
        _slime.Draw(SpriteBatch, Vector2.Zero, Color.White, 0.0f, Vector2.One, 4.0f, SpriteEffects.None, 0.0f);
        _bat.Draw(SpriteBatch, new Vector2(_slime.Width * 4.0f + 10, 0), Color.White, 0.0f, Vector2.One, 4.0f, SpriteEffects.None, 1.0f);
        
        SpriteBatch.End();
        base.Draw(gameTime);
    }
}
