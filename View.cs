using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class View
    {
        public int _x, _y, _sizex, _sizey;
        public View(int x, int y, int sizex, int sizey)
        {
            _x = x;
            _y = y;
            _sizex = sizex;
            _sizey = sizey;
        }

        public virtual void Draw() {}
        public virtual void Move(int x, int y) {
            _x = x;
            _y = y;
        }
    }
}
