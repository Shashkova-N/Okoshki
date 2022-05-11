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

            Window win1 = new Window(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1);
            Window win2 = new Window(x, y, sizex + 20, sizey);
            Window win3 = new Window(x + 6, y + 6, sizex + 20, sizey);

            windows.Add(win1);
            windows.Add(win2);
            windows.Add(win3);

            WindowWork work = new WindowWork(windows, 0);
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            work.DrowAllWin();
           
            while (true) {
                keyinfo = Console.ReadKey(true);
                work.ChangeActiveWin(keyinfo);
                work.AddWin(keyinfo);
                work.Move(keyinfo);
                work.ChangeBtn(keyinfo);
            }
        }
    }
}
