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
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); 
        int LY = int.Parse(inputs[1]); 
        int TX = int.Parse(inputs[2]); 
        int TY = int.Parse(inputs[3]);

        while (true)
        {
            String r="";
            while (true) {
                
                if (TY<LY&&TX<LX)
                {
                    r="SE"; TX++;TY++;
                }
                
                else if (TY==LY&&TX<LX)
                {
                    r="E";TX++;
                }
                else if (TY==LY&&TX>LX)
                {
                    r="W";TX--;
                }
                else if (TX==LX&&TY<LY)
                {
                    r="S";TY++;
                }
                else if (TX>LX&&TY<LY)
                {
                    r="SW";TX--;TY++;
                }
                
                Console.WriteLine(r);
            }
        }
    }
}