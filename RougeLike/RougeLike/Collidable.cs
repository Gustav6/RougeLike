using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class Collidable : Movable
    {
        protected Rectangle hitbox;

        public override void Update(GameTime gameTime)
        {
            SetHitbox();
            base.Update(gameTime);
        }

        public void SetHitbox()
        {
            hitbox.Location = position.ToPoint();
        }
    }
}
