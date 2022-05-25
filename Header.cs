using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Header : View
    {
        public string _title;
        public Header(int x, int y, int sizex, int sizey, string title) : base(x, y, sizex, sizey)
        {
            _title = title;
        }

        public void DrawButtonX()
        {
            Console.SetCursorPosition(_x + _sizex - 3, _y);
            Console.WriteLine("___");
            Console.SetCursorPosition(_x + _sizex - 4, _y + 1);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(_x + _sizex - 4, _y + 2);
            Console.WriteLine("| X |");
            Console.SetCursorPosition(_x + _sizex - 4, _y + 3);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(_x + _sizex - 3, _y + 3);
            Console.WriteLine("___");
            Console.SetCursorPosition(_x + _sizex, _y + 2);
        }

        public void DrawButtonO()
        {
            Console.SetCursorPosition(_x + _sizex - 7, _y);
            Console.WriteLine("___");
            Console.SetCursorPosition(_x + _sizex - 8, _y + 1);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(_x + _sizex - 8, _y + 2);
            Console.WriteLine("| O |");
            Console.SetCursorPosition(_x + _sizex - 8, _y + 3);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(_x + _sizex - 7, _y + 3);
            Console.WriteLine("___");
        }
        public void DrawButtonM()
        {
            Console.SetCursorPosition(_x + _sizex - 11, _y);
            Console.WriteLine("___");
            Console.SetCursorPosition(_x + _sizex - 12, _y + 2);
            Console.WriteLine("| - |");
            Console.SetCursorPosition(_x + _sizex - 12, _y + 1);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(_x + _sizex - 12, _y + 3);
            Console.WriteLine("|   |");
            Console.SetCursorPosition(_x + _sizex - 11, _y + 3);
            Console.WriteLine("___");
        }
        public override void Draw() {
            Drawer.DrawHor(_x + 1, _y, _sizex - 2);
            Console.SetCursorPosition(_x + 1, _y + 1);
            for (int i = 1; i <= 3 - 1; i++)
            {
                Console.SetCursorPosition(_x + 1, _y + i);
                for (int j = 1; j < _sizex; j++)
                {
                    Console.Write(" ");
                }
            }
            Drawer.DrawHor(_x + 1, _y + 3, _sizex - 2);
            Console.SetCursorPosition(_x+2, _y+2);
            Console.WriteLine(_title);
            DrawButtonX();
            DrawButtonO();
            DrawButtonM();
        }
    }
}
