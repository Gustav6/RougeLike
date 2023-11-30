using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class TextureManager
    {
        public static Texture2D[] textures;

        public static void Load(ContentManager content)
        {
            textures = new Texture2D[Enum.GetNames<Texture>().Length];

            textures[(int)Texture.player] = content.Load<Texture2D>("Player/PlayerTexture");
            //textures[(int)Texture.enemy] = content.Load<Texture2D>("enemy");
        }
    }

    public enum Texture
    {
        player,
        enemy,
    }
}
