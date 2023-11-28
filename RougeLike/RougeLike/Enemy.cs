using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class Enemy : Collidable
    {
        public Enemy(Vector2 _position)
        {
            position = _position;
            color = Color.White;
            moveSpeed = 300;
            texture = TextureManager.textures[(int)Texture.enemy];
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatche)
        {
            base.Draw(spriteBatche);
        }
    }
}
