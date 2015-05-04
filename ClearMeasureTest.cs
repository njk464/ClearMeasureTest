using System.IO;
using System;

class Program
{
    static void Main()
    {
        for (ulong i = 1; i < 10; i++)
		{
		    if ( i % 3 == 0 && i % 5 == 0)
		        Console.WriteLine(i + ": BIZZ BUZZ");
			if ( i % 3 == 0 )
				Console.WriteLine(i + ": BIZZ");
			if (i % 5 == 0) 
				Console.WriteLine(i + ": BUZZ");
			//Console.Write("\n");
		}
    }
}
