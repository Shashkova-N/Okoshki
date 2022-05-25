using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Container : View
    {
        public List<View> _listCont;

        public Container(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey)
        {
            _listCont = new List<View>();
        }

        public override void Draw() {
            for (int i = 0; i<_listCont.Count; i++)
            {
                if (i == 0) _listCont[i].Draw();
                else if (i != 0)
                {
                    _listCont[i]._y = _listCont[i - 1]._y + 3;
                    _listCont[i].Draw();
                }
            }
        }
        public override void Move(int x, int y)
        {
            _x = x;
            _y = y;
            foreach (View element in _listCont)
            {
               element.Move(x, y);
            }
        }
        public virtual void Pack(View element)
        {
            _listCont.Add(element);
        }

        public void Pack(params View[] _listCont)
        {
            foreach (View element in _listCont)
            {
                Pack(element);
            }
        }
    }
}