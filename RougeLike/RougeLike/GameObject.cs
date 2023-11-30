using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class GameObject
    {
        public Texture2D texture;
        public Vector2 position;
        public Vector2 origin;
        public Vector2 scale;
        public Color color;
        public float rotation;
        public Rectangle sourceRectangle;

        public bool isRemoved;

        public virtual void Update(GameTime gameTime)
        {

        }

        public void SetSourceRectangle(Texture2D _texture)
        {
            sourceRectangle = new Rectangle(0, 0, _texture.Width, _texture.Height);
        }

        public void SetOrigin(Texture2D _texture)
        {
            origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
        }

        public void Destroy(GameObject @object)
        {
            @object.isRemoved = true;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, color, rotation, origin, scale, SpriteEffects.None, 0);
        }
    }
}
