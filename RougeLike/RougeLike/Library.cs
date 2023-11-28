using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeLike
{
    public static class Library
    {
        public static int bufferWidth = 1920;
        public static int bufferHeight = 1080;

        public static List<GameObject> gameObjects = new();
    }

    public enum Direction
    {
        Left,
        Right,
        Up, 
        Down
    }
}
