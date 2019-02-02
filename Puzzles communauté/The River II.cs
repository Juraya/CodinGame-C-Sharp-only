using System;

class Solution
{
    static long SommeChiffres(long n)
    {
        long somme = 0;
        while (n > 0)
        {
            somme += n % 10;
            n /= 10;
        }
        return somme;
    }

    static void Main(string[] args)
    {
        long r1 = long.Parse(Console.ReadLine());

        for (long r2 = r1-1; r2 > 0; --r2)
        {
            long next = r2 + SommeChiffres(r2);
            if (next == r1)
            {
                Console.WriteLine("YES");
                return;
            }
        }
        Console.WriteLine("NO");
    }
}