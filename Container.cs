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
        public Text _text;
        public Button _button;
        public TextInput _textInput;

        public Container(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey)
        {
            _listCont = new List<View>();
            _text = new Text(x, y, sizex, sizey, " ");
            _button = new Button(x, y, sizex, sizey);
            _textInput = new TextInput(x, y, sizex, sizey);
            _listCont.Add(_text);
            _listCont.Add(_textInput);
            _listCont.Add(_button);
        }

        public override void Draw() {
            _listCont[0].Draw();
            for (int i = 1; i<_listCont.Count; i++)
            {
                _listCont[i]._y = _listCont[i-1]._y + 3;
                _listCont[i].Draw();
            }
        }
        public override void Move(int x, int y)
        {
            _x = x;
            _y = y;
            _text.Move(x, y);
            _button.Move(x, y);
            _textInput.Move(x, y);
        }
    }
}
