//using System.Diagnostics;
using System;

class Program
{
    static void Main()
    {
        //Stopwatch stopwatch = new Stopwatch();
        //stopwatch.Start();
        ulong size = 100000;
        ulong i = 3;
        string s2 = "";
        // loop runs in a time of O(n/15) which is slightly better 
        // than O(n).
        // since every 15 numbers just repeats a pattern I was able
        // to utilize that to make the code a little faster.
        //  3,  5,  6,  9, 10, 12, 15
        // 18, 20, 21, 24, 25, 27, 30
        while (i <= size - 15)
        {
            s2 += i + ": BIZZ\n";
            i += 2;
            s2 += i + ": BUZZ\n";
            i++;
            s2 += i + ": BIZZ\n";
            i += 3;
            s2 += i + ": BIZZ\n";
            i++;
            s2 += i + ": BUZZ\n";
            i += 2;
            s2 += i + ": BIZZ\n";
            i += 3;
            s2 += i + ": BIZZ BUZZ\n";
            i += 3;
            Console.Write(s2);
            s2 = "";
        }
        // since the loop was broken up some of the final computation 
        // has to be done at the end.
        while (i <= size)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                s2 += i + ": BIZZ BUZZ\n";
                i += 3;
                continue;
            }
            if (i % 3 == 0)
            {
                s2 += i + ": BIZZ\n";
                i++;
                continue;
            }
            if (i % 5 == 0)
            {
                s2 += i + ": BUZZ\n";
                i++;
                continue;
            }
            i++;
        }
        Console.Write(s2);
        //stopwatch.Stop();
        //Console.WriteLine("Time elapsed: {0}",
        //stopwatch.Elapsed);

    }
}
