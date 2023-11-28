using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public class GameManager
    {
        public static void Int()
        {

        }

        public static void Update(GameTime gameTime)
        {
            for (int i = 0; i < Library.gameObjects.Count; i++)
            {
                Library.gameObjects[i].Update(gameTime);
            }

            for (int i = Library.gameObjects.Count - 1; i >= 0; i--)
            {
                if (Library.gameObjects[i].isRemoved)
                {
                    Library.gameObjects.RemoveAt(i);
                }
            }
        }
    }
}
