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

            if (thread.Name == "Thread A")
            {
                Console.WriteLine("The thread 0x2e38 has exited with code 0 (0x0).");
            }
            else if (thread.Name == "Thread B")
            {
                Console.WriteLine("The thread 0x14a0 has exited with code 0 (0x0).");
            }
        }
    }
}