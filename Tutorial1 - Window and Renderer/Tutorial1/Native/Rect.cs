using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Native
{
    // S9.- Since we are going to need to specify the position and size of
    // the thing we are drawing we will need a Rect
    // If we use this implementation it will correspond directly to SDL's
    // and we won't have to make castings and transformations between them
    public struct Rect
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;

        // Also I added a nice constructor for user experience
        public Rect(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
