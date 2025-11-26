using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public abstract class BaseLevel
{
    public bool IsCompleted { get; protected set; }

    public virtual void Load(ContentManager content, GraphicsDevice graphicsDevice) { }

    public virtual void Update(GameTime gameTime) { }

    public virtual void Draw(SpriteBatch spriteBatch) { }
}
