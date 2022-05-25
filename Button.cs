using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Button : View
    {
        public string _buttonname;
        public int _margin;
        public Button(int x, int y, int sizex, int sizey, int margin, string buttonname) : base(x, y, sizex, sizey)
        {
            _buttonname = buttonname;
            _margin = margin;
        }
        public override void Draw()
        {
            Drawer.DrawHor(_x + 4 + _margin, _y + 4, _buttonname.Length + 1);
            Drawer.DrawHor(_x + 4 + _margin, _y + 7, _buttonname.Length + 1);
            Drawer.DrawVert(_x + 3 + _margin, _y + 5, 3);
            Drawer.DrawVert(_x + _buttonname.Length + 6 + _margin, _y + 5, 3);
            Console.SetCursorPosition(_x + 5 + _margin, _y + 6);
            Console.WriteLine(_buttonname);
        }
    }
}
