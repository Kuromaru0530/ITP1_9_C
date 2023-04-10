using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int Cards = int.Parse(Console.ReadLine());
        int T = 0;
        int H = 0;
        for (int i = 0; i < Cards; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            if (info[0].CompareTo(info[1]) > 0)
            {
                T += 3;
            }
            else if (info[0].CompareTo(info[1]) == 0)
            {
                T += 1;
                H += 1;
            }
            else H += 3;
        }
        Console.WriteLine("{0} {1}", T, H);      
    }
}