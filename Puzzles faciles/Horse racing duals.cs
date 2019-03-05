using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int diff = 50;
        int N = int.Parse(Console.ReadLine());
        int[] tableau = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            tableau[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(tableau);
        
        for (int i = 0; i < N-1; i++) {
            int test = tableau[i+1] - tableau[i];
            if ( test < diff) {
                diff = test;
            }
        }
        Console.WriteLine(diff);
    }
}