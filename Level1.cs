using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public class Level1 : BaseLevel
{
    Texture2D bg;

    public override void Load(ContentManager content, GraphicsDevice graphicsDevice)
    {
        bg = content.Load<Texture2D>("level1bg");
    }

    public override void Update(GameTime gameTime)
    {
        // Example condition: finish level automatically after 5 seconds
        if (gameTime.TotalGameTime.TotalSeconds > 5)
            IsCompleted = true;
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        spriteBatch.Draw(bg, Vector2.Zero, Color.White);
        spriteBatch.End();
    }
}
