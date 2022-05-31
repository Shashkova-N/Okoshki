using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    public delegate void Operation();

    internal class Button : View
    {
        public string _buttonname;
        public int _marginLeft;
        public int _marginTop;
        
        private Operation p;
        /*public Button(int x, int y, int sizex, int sizey, int marginLeft, int marginTop, string buttonname) : base(x, y, sizex, sizey)
        {
            _buttonname = buttonname;
            _marginLeft = marginLeft;
            _marginTop = marginTop;
        }*/
        public Button(string buttonname, int marginLeft, int marginTop) : base()
        {
            _buttonname = buttonname;
            _marginLeft = marginLeft;
            _marginTop = marginTop;
        }
        public override void Draw()
        {
            Drawer.DrawHor(_x + 1 + _marginLeft, _y + 4 + _marginTop, _buttonname.Length + 1);
            Drawer.DrawHor(_x + 1 + _marginLeft, _y + 7 + _marginTop, _buttonname.Length + 1);
            Drawer.DrawVert(_x + _marginLeft, _y + 5 + _marginTop, 3);
            Drawer.DrawVert(_x + _buttonname.Length + 3 + _marginLeft, _y + 5 + _marginTop, 3);
            Console.SetCursorPosition(_x + 2 + _marginLeft, _y + 6 + _marginTop);
            Console.WriteLine(_buttonname);
        }
        public override void OnClick()
        {
            p();
        }
        public void Click(Operation op)
        {
            p = op;
        }
    }
}
