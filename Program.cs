using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;


namespace Okoshki
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int x = 10, y = 5, sizex=50, sizey = 20;
            Console.CursorVisible = false;
            
            List<Window> windows = new List<Window>();

            Window win1 = new Window(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1, "Так себе заголовок");
            Window win2 = new Window(x + 20, 1, sizex + 20, Console.WindowHeight - 3, "Заголовочек");

            //содержимое первого окна
            Text _text = new Text("Какoй-то там текст", 10, 10);
            TextInput _textInput = new TextInput(10, 2, 50, "string");
            Text _text2 = new Text("Ещё какой-то текст", 10, 10);
            Button _button = new Button("Кнопка", 50, 5);

            //содержимое второго окна
            Text _text3 = new Text("Имя:", 3, 1);
            TextInput _textInput2 = new TextInput(15, 0, 50, "string");
            Text _text4 = new Text("Пароль:", 3, 6);
            TextInput _textInput3 = new TextInput(15, 5, 50, "password");
            Text _text5 = new Text("Телефон:", 3, 11);
            TextInput _textInput4 = new TextInput(15, 10, 50, "phone");
            Text _text6 = new Text("email:", 3, 16);
            TextInput _textInput5 = new TextInput(15, 15, 50, "email");
            Button _button2 = new Button("Сохранить", 48, 19);

            _button2.Click(() =>
            {
                Text _textt = new Text($"Привет, {_textInput2._textInputing}!", 15, 20);
                win2.Pack(_textt);
            });
           
            win1.Pack(_text, _textInput, _text2, _button);
            win2.Pack(_text3, _textInput2, _text4, _textInput3, _text5, _textInput4, _text6, _textInput5, _button2);

            windows.Add(win1);
            windows.Add(win2);

            WindowWork work = new WindowWork(windows, windows.Count - 1);
            work.ActiveWin();
            while (true) {
                work.KeyListener();
            }
        }
    }
}
