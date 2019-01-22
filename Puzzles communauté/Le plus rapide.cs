using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string min = "23:59:59";
        for (int i = 0; i < N; i++)
        {
            string t = Console.ReadLine();
            if (DateTime.ParseExact(t, "HH:mm:ss", CultureInfo.InvariantCulture) < DateTime.ParseExact(min, "HH:mm:ss", CultureInfo.InvariantCulture))
            {
                min = t;
            }
        }
        Console.WriteLine(min);
    }
}