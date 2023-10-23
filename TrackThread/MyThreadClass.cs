using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrackThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + i);
                Thread.Sleep(400);
            }
        }
        public static void Thread2() 
        {
            for (int j = 0; j <= 5; j++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + j);
                Thread.Sleep(1500);
            }
        }
    }
}
