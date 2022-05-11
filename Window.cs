using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Window : View
    {
        public Header _head;
        public Container _container;
        public Window(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey)
        {
            _head = new Header(x, y, sizex, sizey, "Okno");
            _container = new Container(x, y, sizex, sizey);
        }

        public override void Draw() {
              Drawer.DrawHor(_x, _y, _sizex, _sizey);
              Drawer.DrawHor(_x, _y + _sizey, _sizex, _sizey);
              Drawer.DrawVert(_x, _y + 1, _sizex, _sizey);
              Drawer.DrawVert(_x + _sizex, _y + 1, _sizex, _sizey);
              Console.SetCursorPosition(_x + 1, _y + 1);
              for (int i = 1; i <= _sizey - 1; i++){
                  Console.SetCursorPosition(_x + 1, _y + i);
                    for (int j = 1; j < _sizex; j++)
                    {
                        Console.Write(" ");
                    }
              }
            _head.Draw();
            _container.Draw();
        }

        public override void Move(int x, int y) {
            if (x >= 0 && (x + _sizex) < Console.WindowWidth && y >= 0 && (y + _sizey) < Console.WindowHeight)
            {
                _x = x;
                _y = y;
                _head.Move(x, y);
                _container.Move(x, y);
            }
        }
    }
}
