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
        string[] inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        
        // Stockage du tableau
        string[,] diagramme = new string[W,H];

        for (int i = 0; i < H; i++)
        {
            string line = Console.ReadLine();
            Console.Error.WriteLine(line);
            for (int j = 0; j < W; j++)
            {
              diagramme[j,i] = line[j].ToString();
            }
        }
        
        // Affichage du tableau (TEST)
        /*
        for (int i = 0; i < W; i++)
        {
            //Console.Error.Write(diagramme[i,0]);
            for (int j = 0; j < H; j++) 
            {
                Console.Error.Write(diagramme[j,i]);
            }
            Console.Error.Write(Environment.NewLine);
        }
        */

        // Tableau des "étiquettes" en haut du diagramme
        List<String> labels = new List<String>();
        
        
        for (int i = 0; i < W; i++) 
        {
            //Console.Error.WriteLine(diagramme[i,0]);
            labels.Add(diagramme[i,0]);
            i = i+2;
        }

        int ab = 0;
        string ord;

        foreach (string label in labels) 
        {
            // Validé
            for (int j = 0; j < W; j++)
            {
                if (diagramme[j,0] == label)
                {
                ab = j;
                Console.Error.WriteLine("Label " + label + " trouvé ! Index : " + ab);
                }
            }
            
            int compteur = 0;
            
            while(true)
            {
                // Validé
                if (compteur == H)
                {
                    Console.Error.WriteLine("Abscisse : " + ab + " et compteur : " + compteur);
                    ord = diagramme[ab,compteur-1];
                    Console.WriteLine(label + ord);
                    break;
                }
                
                Console.Error.WriteLine("Le curseur est en ligne " + compteur + " et à l'indice : " + ab);
                
                if (ab == 0)
                {
                    if (diagramme[ab+1,compteur] != "-")
                    {
                        Console.Error.WriteLine("Aucun chemin secondaire !");
                        compteur++;
                        continue;
                    }
                    else if (diagramme[ab+1,compteur] == "-")
                    {
                        Console.Error.WriteLine("Chemin trouvé !");
                        ab = ab +3;
                        compteur++;
                        continue;
                    }
                    else if (compteur == H)
                    {
                        ord = diagramme[ab,compteur];
                        Console.WriteLine(label + ord);
                        break;
                    }
                }
                
                else if (ab == W-1)
                {
                    if (diagramme[ab-1,compteur] != "-")
                    {
                        compteur++;
                        continue;
                    }
                    else if (diagramme[ab-1,compteur] == "-")
                    {
                        ab = ab -3;
                        compteur++;
                        continue;
                    }
                    else if (compteur == H)
                    {
                        ord = diagramme[ab,compteur];
                        Console.WriteLine(label + ord);
                        break;
                    }
                }
                
                else if ((diagramme[ab+1,compteur] != "-") && (diagramme[ab-1,compteur] != "-"))
                {
                    Console.Error.WriteLine("On continue.");
                    compteur++;
                    continue;
                }
                else if (diagramme[ab+1,compteur] == "-")
                {
                    Console.Error.WriteLine("Chemin trouvé !");
                    ab = ab +3;
                    compteur++;
                    continue;
                }
                else if (diagramme[ab-1,compteur] == "-")
                {
                    ab = ab -3;
                    compteur++;
                    continue;
                }
                Console.Error.WriteLine("Rien.");
            }
        }
    }
}