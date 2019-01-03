using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public static long[] GetlongArray(long num)
    {
    List<long> listOflongs = new List<long>();
    while(num > 0)
    {
        listOflongs.Add(num % 10);
        num = num / 10;
    }
    listOflongs.Reverse();
    return listOflongs.ToArray();
    }
    
    public static long AppliquerSuite(long nombre) {
        long nombreSuivant = nombre;
        long[] tableauSplit = GetlongArray(nombre);
        foreach (long element in tableauSplit) {
            nombre = nombre + element;
        }
        return nombre;
    }
    
    static void Main(string[] args)
    {
        long r1 = long.Parse(Console.ReadLine());
        long r2 = long.Parse(Console.ReadLine());

    while (true)
        {
            if (r1 == r2)
            {
                Console.WriteLine(r1);
                break;
            }
            if (r1 < r2)
            {
                r1 = AppliquerSuite(r1);
            }
            else
            {
                r2 = AppliquerSuite(r2);
            }
        }
    }
}