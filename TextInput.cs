using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Okoshki
{
    internal class TextInput : View
    {
        public string _textInputing = "";
        public int _len;
        public int _marginLeft;
        public int _marginTop;
        public string _type;
        /*public TextInput(int x, int y, int sizex, int sizey, int marginLeft, int marginTop, int len) : base(x, y, sizex, sizey)
        {
            _marginLeft = marginLeft;
            _marginTop = marginTop;
            _len = len;
        }*/
        public TextInput(int marginLeft, int marginTop, int len, string type) : base()
        {
            _marginLeft = marginLeft;
            _marginTop = marginTop;
            _len = len;
            _type = type;
        }
        public override void Draw()
        {
            ClearInput();
            Drawer.DrawHor(_x + 1 + _marginLeft, _y + 4  + _marginTop, _len - 2);
            Console.SetCursorPosition(_x + _marginLeft, _y + 5 + _marginTop);
            Console.Write("|");
            Console.SetCursorPosition(_x + _marginLeft, _y + 6 + _marginTop);
            Console.Write("|");
            Drawer.DrawHor(_x + 1 + _marginLeft, _y + 6 + _marginTop, _len - 1);
            Console.SetCursorPosition(_x + _len + _marginLeft, _y + 5 + _marginTop);
            Console.Write("|");
            Console.SetCursorPosition(_x + _len + _marginLeft, _y + 6 + _marginTop);
            Console.Write("|");
            Console.SetCursorPosition(_x + _marginLeft + 1, _y + 5 + _marginTop);
            
            if (_type == "password")
            {
                for (int i = 0; i < _textInputing.Length; ++i)
                {
                    Console.Write("*");
                }
            }
            else Console.Write(_textInputing);
        }
        public override void OnClick()
        {
            _textInputing = "";
            Console.ForegroundColor = ConsoleColor.Green;
            Draw();
            Console.ResetColor();
            Console.SetCursorPosition(_x + _marginLeft + 1, _y + 5 + _marginTop);
            Console.CursorVisible = true;
            if (_type == "password") { PassInput(); }
            else
            {
                _textInputing = Console.ReadLine();
            }

            if (_type == "email")
            {
                Console.SetCursorPosition(_x + _marginLeft + 1, _y + 7 + _marginTop);
                if (IsValidEmail(_textInputing))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("email введён корректно!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный email!");
                    Console.ResetColor();
                }
            }

            if (_type == "phone")
            {
                IsValidPhone();
            }
                Console.CursorVisible = false;
        }
        public void PassInput()
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter)
                {
                    _textInputing += key.KeyChar;
                    Console.Write("*");
                }
                else break;
            }
        }
        private static bool IsValidEmail(string textInputing)
        {
            try
            {
                MailAddress mail = new MailAddress(textInputing);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void IsValidPhone()
        {
            string pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";

            Console.SetCursorPosition(_x + _marginLeft + 1, _y + 7 + _marginTop);
            if (Regex.IsMatch(_textInputing, pattern, RegexOptions.IgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Телефон введён верно!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный номер телефона");
                Console.ResetColor();
            }
        }
        private void ClearInput()
        {
            Console.SetCursorPosition(_x + 1 + _marginLeft, _y + 5 + _marginTop);
            for (int i = 0; i < _len - 1; ++i)
            {
                Console.Write(" ");
            }
        }
    }
}
