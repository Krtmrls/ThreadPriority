using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
  
      class MyThreadClass
        {
            // Step 3: short loop, 0.5 second sleep
            public static void Thread1()
            {
                for (int loopCount = 0; loopCount < 3; loopCount++)
                {
                    Thread thread = Thread.CurrentThread;
                    Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);
                    Thread.Sleep(500);
                }
            }

            // Step 4: 6 loops, 1.5 second sleep
            public static void Thread2()
            {
                for (int loopCount = 0; loopCount < 6; loopCount++)
                {
                    Thread thread = Thread.CurrentThread;
                    Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);
                    Thread.Sleep(1500);
                }
            }
        }
    }