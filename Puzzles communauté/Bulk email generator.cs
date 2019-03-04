using System;
using System.Text.RegularExpressions;

public class Solution
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] lignesTemplate = new string[N];

        for (int i = 0; i < N; i++)
        {
            lignesTemplate[i] = Console.ReadLine();
        }

        string emailTemplate = string.Join("\n", lignesTemplate);
        int choixCounter = -1;

        string email = Regex.Replace(emailTemplate, @"\([^)]*\)", (match) => 
        {
            choixCounter++;
            string[] choix = match.Value.Substring(1, match.Value.Length - 2).Split('|');
            return choix[choixCounter % choix.Length];
        });
        Console.WriteLine(email);
    }
}