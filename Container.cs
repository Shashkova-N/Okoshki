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
        public int _act;

        public Container(int x, int y, int sizex, int sizey, int act) : base(x, y, sizex, sizey)
        {
            _listCont = new List<View>();
            _act = act;
        }
        public override void Draw() {

            for (int i = 0; i<_listCont.Count; i++)
            {
                _listCont[i].Draw();
            }
        }
        public override void Move(int x, int y)
        {
            foreach (View element in _listCont)
            {
                element.Move(x, y);
                _x = x;
                _y = y;
            }
        }
        public void Pack(View element )
        {
            element._x = _x;
            element._y = _y;
            _listCont.Add(element);
            element.Draw();
        }
        public void ChangeElem()
        {
            _act = _act < _listCont.Count - 1 ? ++_act : 0;
            /*if (_act < _listCont.Count - 1)
            {
                ++_act;
            }
            else if (_act == _listCont.Count - 1)
            {
                _act = 0;
            }*/
            if (_listCont[_act].GetType() == typeof(Text))
            {
                if (_act == _listCont.Count - 1)
                {
                    _act = 0;
                }
                ++_act;
            }
            Draw();
            Console.ForegroundColor = ConsoleColor.Green;
            _listCont[_act].Draw();
            Console.ResetColor();
        }
        public override void OnClick()
        {
            _listCont[_act].OnClick();
        }
    }
}