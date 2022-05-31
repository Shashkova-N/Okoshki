using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Text : View
    {
        public string _text;
        public int _marginLeft;
        public int _marginTop;
        /*public Text(int x, int y, int sizex, int sizey, string text, int marginLeft, int marginTop) : base(x, y, sizex, sizey) { 
            _text = text;
            _marginLeft = marginLeft;
            _marginTop = marginTop;
        }*/
        public Text(string text, int marginLeft, int marginTop) : base(){
            _text = text;
            _marginLeft = marginLeft;
            _marginTop = marginTop;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(_x + _marginLeft, _y + 4 + _marginTop);
            Console.Write(_text);
        }
    }
}
