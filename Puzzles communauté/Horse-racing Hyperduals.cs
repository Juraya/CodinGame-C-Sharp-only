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
        int N = int.Parse(Console.ReadLine());
        int[] vitesse = new int[N];
        int[] elegance = new int[N];
        int minimumIndex = 9999999;
        
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int V = int.Parse(inputs[0]);
            int E = int.Parse(inputs[1]);
            
            vitesse[i] = V;
            elegance[i] = E;
        }
        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (j != i)
                {
                    if ((Math.Abs(vitesse[j]-vitesse[i])+Math.Abs(elegance[j]-elegance[i])) < minimumIndex)
                    {
                        minimumIndex = Math.Abs(vitesse[j]-vitesse[i])+Math.Abs(elegance[j]-elegance[i]);
                    }
                }
            }
        }

        Console.WriteLine(minimumIndex);
    }
}