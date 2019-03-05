using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        while (true)
        {
            int max = 0;
            int reponse = 0;
            
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine());
                if (mountainH > max) 
                {
                    max = mountainH;
                    reponse = i;
                }
            }
            Console.WriteLine(reponse);
        }
    }
}