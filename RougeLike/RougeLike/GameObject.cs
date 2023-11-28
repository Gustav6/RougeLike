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
        public Color color;
        public bool isRemoved;

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatche)
        {
            spriteBatche.Draw(texture, position, color); 
        }
    }
}
