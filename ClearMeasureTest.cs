using System.Diagnostics;
using System;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ulong three = 1;
        ulong five = 1;
        string s = "";
        while (three <= 333333)
        {
            ulong top = 333333;
            if (three + 500 < 333333)
                top = three + 500;
            s = "";
            while (three < top){
                if (three*3 == five*5) {
                    //Console.WriteLine(three*3 + ": BIZZ BUZZ");
                    s += three * 3 + ": BIZZ BUZZ\n";
                    three++;
                    five++;
                    continue;
                }
                if (five*5 < three*3) {
                    //Console.WriteLine(five*5 + ": BUZZ");
                    s += five * 5 + ": BUZZ\n";
                    five++;
                }
                //Console.WriteLine(three*3 + ": BIZZ");
                s += three * 3 + ": BIZZ\n";
                three++;
            }
            Console.Write(s);
	    }
	    stopwatch.Stop();
	    Console.WriteLine("Time elapsed: {0}",
	    stopwatch.Elapsed);
    }
}
