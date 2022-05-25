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
        public Text(int x, int y, int sizex, int sizey, string text) : base(x, y, sizex, sizey) { 
            _text = text;
        }

        public override void Draw() {
            int k = 1;
            Console.SetCursorPosition(_x + 1, _y + 5);
            if (_text[0] != ' ') { _text = " " + _text; }
            for (int i = 0; i < _text.Length; i++)
            {
                Console.Write(_text[i]);
                if (i % (_sizex - 1) == 0)
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(_x + 2, _y + k + 5);
                    k++;
                }
            }
        }
    }
}
