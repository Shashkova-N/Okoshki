using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okoshki
{
    internal class WindowWork
    {

        public List<Window> _ViewList;
        public int _active;
        public WindowWork(List<Window> viewList, int active)
        {
            _ViewList = viewList;
            _active = active;
        }
        public void DrowAllWin()
        {
            foreach (Window view in _ViewList)
            {
                view.Draw();
            }
        }
        public void AddWin()
        {
            //Header head1 = new Header(40, 10, 20, 10,"New win");
            _ViewList.Add(new Window(40, 10, 20, 10, "New win"));
            _active = _ViewList.Count - 1;
            ActiveWin();
        }
        public void ActiveWin()
        {
            Console.Clear();
            for (int i = 0; i < _ViewList.Count; i++)
            {
                if (i != _active) { _ViewList[i].Draw(); }
            }

            _ViewList[_active].Draw();
            Console.BackgroundColor = ConsoleColor.Green;
            _ViewList[_active]._head.Draw();
            Console.ResetColor();
        }

        public void ChangeActiveWin()
        {
            if (_active < _ViewList.Count - 1)
            {
                ++_active;
                ActiveWin();
            }
            else if (_active == _ViewList.Count - 1)
            {
                _active = 0;
                ActiveWin();
            }
        }

        public void Move(ConsoleKeyInfo keyinfo) {
            switch (keyinfo.Key) {
                case ConsoleKey.RightArrow:
                    _ViewList[_active].Move(_ViewList[_active]._x + 1, _ViewList[_active]._y);
                    break;
                case ConsoleKey.LeftArrow:
                    _ViewList[_active].Move(_ViewList[_active]._x - 1, _ViewList[_active]._y);
                    break;
                case ConsoleKey.UpArrow:
                    _ViewList[_active].Move(_ViewList[_active]._x, _ViewList[_active]._y - 1);
                    break;
                case ConsoleKey.DownArrow:
                    _ViewList[_active].Move(_ViewList[_active]._x, _ViewList[_active]._y + 1);
                    break;
            }
            ActiveWin();
        }
        public void KeyListener()
        {
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            keyinfo = Console.ReadKey(true);

            if (keyinfo.Key == ConsoleKey.Tab)
            {
                ChangeActiveWin();
            }
            if ((keyinfo.Modifiers & ConsoleModifiers.Alt) != 0)
            {
                if (keyinfo.Key == ConsoleKey.V)
                {
                    AddWin();
                }
            }
            if (keyinfo.Key == ConsoleKey.LeftArrow || keyinfo.Key == ConsoleKey.RightArrow || keyinfo.Key == ConsoleKey.UpArrow || keyinfo.Key == ConsoleKey.DownArrow)
            {
                Move(keyinfo);
            }
            if (keyinfo.Key == ConsoleKey.F1 || keyinfo.Key == ConsoleKey.F2 || keyinfo.Key == ConsoleKey.F3)
            {
                ChangeBtn(keyinfo);
            }
        }

        public void Pack(params View[] _listCont)
        {
            _ViewList[_active].Pack();
            ActiveWin();
        }

        public void ChangeBtn(ConsoleKeyInfo keyinfo) {
            if (keyinfo.Key == ConsoleKey.F3) {
                _ViewList[_active].Draw();
                Console.BackgroundColor = ConsoleColor.Green;
                _ViewList[_active]._head.Draw();
                Console.BackgroundColor = ConsoleColor.Cyan;
                _ViewList[_active]._head.DrawButtonX();
                Console.ResetColor();
                ConsoleKeyInfo keyinfo2 = new ConsoleKeyInfo();
                keyinfo2 = Console.ReadKey(true);
                if (keyinfo2.Key == ConsoleKey.Spacebar) {
                    _ViewList.Remove(_ViewList[_active]);
                    _active = 0;
                    Console.Clear();
                    DrowAllWin();
                }
            }
            else if (keyinfo.Key == ConsoleKey.F2)
            {
                _ViewList[_active].Draw();
                Console.BackgroundColor = ConsoleColor.Green;
                _ViewList[_active]._head.Draw();
                Console.BackgroundColor = ConsoleColor.Cyan;
                _ViewList[_active]._head.DrawButtonO();
                Console.ResetColor();
                ConsoleKeyInfo keyinfo3 = new ConsoleKeyInfo();
                keyinfo3 = Console.ReadKey(true);
                if (keyinfo3.Key == ConsoleKey.Spacebar)
                {
                    if (_ViewList[_active]._sizex == Console.WindowWidth - 1 && _ViewList[_active]._sizey == Console.WindowHeight - 1) {
                        _ViewList[_active]._sizex = 60;
                        _ViewList[_active]._sizey = 20;
                        ActiveWin();
                    }
                    else { 
                        _ViewList[_active]._x = 0;
                        _ViewList[_active]._y = 0;
                        _ViewList[_active]._sizex = Console.WindowWidth - 1;
                        _ViewList[_active]._sizey = Console.WindowHeight - 1;
                        _ViewList[_active].Draw();
                    }
                }
            }
            else if (keyinfo.Key == ConsoleKey.F1)
            {
                _ViewList[_active].Draw();
                Console.BackgroundColor = ConsoleColor.Green;
                _ViewList[_active]._head.Draw();
                Console.BackgroundColor = ConsoleColor.Cyan;
                _ViewList[_active]._head.DrawButtonM();
                Console.ResetColor();
            }
        }
    }
}
