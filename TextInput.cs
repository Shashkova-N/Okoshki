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
        public int _len;
        public int _margin;
        public TextInput(int x, int y, int sizex, int sizey, int margin, int len) : base(x, y, sizex, sizey)
        {
            _margin = margin;
            _len = len;
        }
        public override void Draw()
        {
            Drawer.DrawHor(_x + 3 + _margin, _y + 4, _len - 2);
            Console.SetCursorPosition(_x + 2 + _margin, _y + 5);
            Console.Write("|");
            Console.SetCursorPosition(_x + 2 + _margin, _y + 6);
            Console.Write("|");
            Drawer.DrawHor(_x + 3 + _margin, _y + 6, _len - 1);
            Console.SetCursorPosition(_x + 2 + _len + _margin, _y + 5);
            Console.Write("|");
            Console.SetCursorPosition(_x + 2 + _len + _margin, _y + 6);
            Console.Write("|");
        }
    }
}
