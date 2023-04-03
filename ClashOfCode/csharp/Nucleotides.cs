// Le programme :
// Les nucléotides dans une séquence d'ADN peuvent être représentés par les caractères A, C, G et T. Voici un exemple d'échantillon d'une séquence d'ADN : "ATGCTTCAGAAAAGGTCAGCG".

// L'objectif ici est de compter combien de fois les symboles A, C, G et T apparaissent dans la chaine s.

// ENTRÉE :
// Une chaîne composée de 'A', 'C', 'G',' T'.

// SORTIE :
// Le nombre de 'A' 'C' 'G' 'T' présents dans s, séparés par un espace.

// CONTRAINTES :
// 0 < len(s) < 1000

// EXEMPLE :
// Entrée
// AACT
// Sortie
// 2 1 0 1


// DUREE
// 00:06:40

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
        string s = Console.ReadLine();

        Dictionary<string, int> count = new Dictionary<string, int>();
        count.Add("A",0);
        count.Add("C",0);
        count.Add("G",0);
        count.Add("T",0);

        foreach(char c in s){
            count[c.ToString()] = count[c.ToString()]+= 1;
        }
        Console.WriteLine(count["A"] + " " + count["C"] + " " + count["G"] + " "+ count["T"]);
    }
}
