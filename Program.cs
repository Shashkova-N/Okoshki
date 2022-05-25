using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int x = 10, y = 5, sizex=50, sizey = 15;
            
            List<Window> windows = new List<Window>();

            Window win1 = new Window(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1, "Так себе заголовок");
            Window win2 = new Window(x + 20, y, sizex + 20, sizey, "Заголовочек");
            Window win3 = new Window(x + 6, y + 6, sizex + 20, sizey, "Энифинг элс");

            Text _text = new Text(win1._x, win1._y, win1._sizex, win1._sizey, 10,"Какoй-то там текст");
            Button _button = new Button(win1._x, win1._y, win1._sizex, win1._sizey, 10, "Кнопка");
            TextInput _textInput = new TextInput(win1._x, win1._y, win1._sizex, win1._sizey, 10, 50);
            Text _text2 = new Text(win1._x, win1._y, win1._sizex, win1._sizey, 10, "Ещё какой-то текст");
            Text _text3 = new Text(win2._x, win2._y, win2._sizex, win2._sizey, 12, "Какoй-то там текст");

            win1.Pack(_text, _text2, _textInput, _button);
            win2.Pack(_text3);

            windows.Add(win1);
            windows.Add(win2);
            //windows.Add(win3);

            WindowWork work = new WindowWork(windows, 0);
            work.DrowAllWin();
            while (true) {
                work.KeyListener();
            }
        }
    }
}
