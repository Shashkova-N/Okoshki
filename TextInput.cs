using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class TextInput : View
    {
        public string _textInputing;
        public TextInput(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey)
        {
        }
        public override void Draw()
        {
            Drawer.DrawHor(_x + 3, _y + 4, _sizex/2 - 2);
            Console.SetCursorPosition(_x + 2, _y + 5);
            Console.Write("|");
            Console.SetCursorPosition(_x + 2, _y + 6);
            Console.Write("|");
            Drawer.DrawHor(_x + 3, _y + 6, _sizex / 2 - 1);
            Console.SetCursorPosition(_x + 2 + _sizex / 2, _y + 5);
            Console.Write("|");
            Console.SetCursorPosition(_x + 2 + _sizex / 2, _y + 6);
            Console.Write("|");
        }
    }
}
