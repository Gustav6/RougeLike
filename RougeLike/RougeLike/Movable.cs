using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class Movable : GameObject
    {
        public Vector2 velocity;
        public float moveSpeed;

        public override void Update(GameTime gameTime)
        {
            Move(gameTime);
            base.Update(gameTime);
        }

        public void Move(GameTime gameTime)
        {
            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }

            position += velocity * moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds; 
        }
    }
}
