using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

class Solution
{
    static bool estDansFigure(Point[] polygon, double px, double py)
    {
        bool impact = false;
        
        for (int current = 0; current < polygon.Length; current++) 
        {
            Point vc = polygon[current];
            Point vn = polygon[(current + 1) % polygon.Length];
            
            bool btv = (vc.Y > py) != (vn.Y > py);
            bool jct = px < (vn.X - vc.X) * (py - vc.Y) / (vn.Y - vc.Y) + vc.X;
    
            if (btv && jct)
            {
                impact = !impact;
            }
        }
        return impact;
    }
    
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        Point[] coins = new Point[N];
        
        for (int i = 0; i < N; i++)
        {
            string[] coinXY = Console.ReadLine().Split(' ');
            int coinX = int.Parse(coinXY[0]);
            int coinY = int.Parse(coinXY[1]);
            
            coins[i] = new Point(coinX, coinY);
        }
        
        int M = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < M; i++)
        {
            string[] shotXY = Console.ReadLine().Split(' ');
            int shotX = int.Parse(shotXY[0]);
            int shotY = int.Parse(shotXY[1]);
            
            if (estDansFigure(coins, shotX, shotY))
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("miss");
            }
        }
    }
}