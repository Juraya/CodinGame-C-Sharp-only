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
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int nombreAppareils = int.Parse(inputs[0]);
        int clics = int.Parse(inputs[1]);
        int amperes = int.Parse(inputs[2]);
        int chargeMax = 0;
        int charge = 0;
        List<int> appareilsAllumes = new List<int>();
        List<int> consommation = new List<int>();
        
        // Consommation de chaque appareil
        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < nombreAppareils; i++)
        {
            consommation.Insert(i, int.Parse(inputs[i]));
        }
        
        // Séquence d'allumage et d'extinction
        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < clics; i++)
        {
            int mx = int.Parse(inputs[i]);
            if (!appareilsAllumes.Contains(mx))
            {
                // On ajoute l'appareil à la liste des appareils allumés
                appareilsAllumes.Add(mx);
                Console.Error.WriteLine("Appareil " + mx + " allumé ! Sa consommation est de : " + consommation[mx-1]);
            }
            else if (appareilsAllumes.Contains(mx))
            {
                // On retire l'appareil s'il existait déjà
                appareilsAllumes.Remove(mx);
            }
            
            // Calcul de la charge
            charge = 0;
            for (int j = 0; j < appareilsAllumes.Count; j++)
            {
                charge += consommation[appareilsAllumes[j]-1];
            }
            
            if (charge > chargeMax) chargeMax = charge;
            
            Console.Error.WriteLine("La charge actuelle est de " + charge + " ampères.");
            Console.Error.WriteLine("La charge maximale atteinte est de " + chargeMax + " ampères");
        }

        if (chargeMax > amperes) 
        {
            Console.WriteLine("Fuse was blown.");
        }
        
        else 
        {
            Console.WriteLine("Fuse was not blown."); 
            Console.WriteLine("Maximal consumed current was " + chargeMax + " A.");
        }
    }
}