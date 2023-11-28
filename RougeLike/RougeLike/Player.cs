using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class Player : Collidable
    {
        public Player(Vector2 _position)
        {
            position = _position;
            color = Color.White;
            moveSpeed = 300;
            texture = TextureManager.textures[(int)Texture.player];
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }


        public void Controls()
        {
            velocity = Vector2.Zero;

            if (InputManager.IsPressed(Keys.Up))
            {
                velocity.Y++;
            }

            if (InputManager.IsPressed(Keys.Down))
            {
                velocity.Y--;
            }

            if (InputManager.IsPressed(Keys.Right))
            {
                velocity.X++;
            }

            if (InputManager.IsPressed(Keys.Left))
            {
                velocity.X--;
            }
        }

        public override void Draw(SpriteBatch spriteBatche)
        {
            base.Draw(spriteBatche);
        }
    }
}
