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
        int nbMois = 0;
        int nbAnnees = 0;
        string BEGIN = Console.ReadLine();
        string END = Console.ReadLine();
        
        string[] splitDebut = BEGIN.Split('.');
        string[] splitFin = END.Split('.');
        
        int jourDeb = int.Parse(splitDebut[0]); 
        int moisDeb = int.Parse(splitDebut[1]); 
        int anneeDeb = int.Parse(splitDebut[2]);
        DateTime debut = new DateTime(anneeDeb, moisDeb, jourDeb);
        
        int jourFin = int.Parse(splitFin[0]);
        int moisFin = int.Parse(splitFin[1]);
        int anneeFin = int.Parse(splitFin[2]);
        DateTime fin = new DateTime(anneeFin, moisFin, jourFin);
        
        int jours = (int)(fin - debut).TotalDays;
        int joursT = jours;
        
        Console.Error.WriteLine("Jours en tout : " + jours);

        if (jours >= 365)
        {
            nbAnnees = jours / 365;
            jours -= nbAnnees * 365;
        }
        
        if (jours > 30)
        {
            nbMois = jours / 30;
            jours -= nbMois * 30;
        }
        
        Console.Error.WriteLine("Années : " + nbAnnees);
        Console.Error.WriteLine("Mois : " + nbMois);
        
        // Une année et un mois
        if ((nbAnnees == 1) && (nbMois == 1))
        {
            Console.WriteLine(nbAnnees + " year, " + nbMois + " month, total " + joursT + " days");
        }
        if (joursT == 31)
        {
            Console.WriteLine(nbMois + " month, total " + joursT + " days");
        }
        // Une année et plusieurs mois
        else if ((nbAnnees == 1) && (nbMois > 1))
        {
            Console.WriteLine(nbAnnees + " year, " + nbMois + " months, total " + joursT + " days");
        }
        // Plusieurs années et plusieurs mois
        else if ((nbAnnees > 1) && (nbMois > 1))
        {
            Console.WriteLine(nbAnnees + " years, " + nbMois + " months, total " + joursT + " days");
        }
        // Une année pile
        else if ((nbAnnees == 1) && (nbMois < 1))
        {
            Console.WriteLine(nbAnnees + " year, total " + joursT + " days");
        }
        // Plusieurs années pile
        else if ((nbAnnees > 1) && (nbMois < 1))
        {
            Console.WriteLine(nbAnnees + " years, total " + joursT + " days");
        }
        else if ((nbAnnees < 1) && (nbMois > 1))
        {
            Console.WriteLine(nbMois + " months, total " + joursT + " days");
        }
        else if ((nbAnnees < 1) && (nbMois < 1))
        {
            Console.WriteLine("total " + joursT + " days");
        }
        else if ((nbAnnees > 1) && (nbMois == 1))
        {
            Console.WriteLine(nbAnnees + " years, " + nbMois + " month, total " + joursT + " days");
        }
    }
}