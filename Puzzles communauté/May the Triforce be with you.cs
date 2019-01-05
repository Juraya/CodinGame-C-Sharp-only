using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    int N = int.Parse(System.Console.ReadLine());
        var cout = new System.Text.StringBuilder(N * 4 * N * 2);
        for(int i = 0; i < N; i++)
            cout.Append(' ', N * 2 - i - 1)
                .Append('*', i * 2 + 1)
                .Append('\n');
        for(int i = 0; i < N; i++)
            cout.Append(' ', N - i - 1)
                .Append('*', i * 2 + 1)
                .Append(' ', (N - i) * 2 - 1)
                .Append('*', i * 2 + 1)
                .Append('\n');
        System.Console.Write('.' + cout.ToString(1, cout.Length - 2));
}