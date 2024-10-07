using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AutoResetDemo
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread th = new Thread(SomeMethod);
                th.Start();
            }
            Console.ReadLine();
            autoResetEvent.Set();
            //implement Reset()
        }
        static void SomeMethod()
        {
            Console.WriteLine("Starting........");
            autoResetEvent.WaitOne();
            Console.WriteLine("Finishing..........");
            Console.ReadLine();
        }
    }
}