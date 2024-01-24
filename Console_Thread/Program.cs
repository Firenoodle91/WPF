using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Console_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MyThreadFunction);
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                Thread.Sleep(1000);
            }
        }

        static void MyThreadFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread Thread: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
