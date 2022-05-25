using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Drawer
    {
        public static void DrawHor(int x, int y, int sizex)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i <= sizex; i++) { Console.Write("_"); }
        }
        public static void DrawVert(int x, int y, int sizey)
        {
            for (int i = 0; i < sizey; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write("|");
            }
        }
    }
}
