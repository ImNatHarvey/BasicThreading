using System;
using System.Threading;

namespace BasicThreading
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(1500);
                // 1.5 seconds
            }
        }
    }
}