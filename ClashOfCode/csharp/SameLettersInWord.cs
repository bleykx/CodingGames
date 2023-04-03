// Le programme :
// Votre programme doit trouver le nombre de mots contenant au moins deux lettres identiques à la suite.

// La casse des lettres n'est pas importante, ainsi A == a.

// ENTRÉE :
// Une chaîne de caractères S, Les mots sont séparés par des espaces.

// SORTIE :
// Le nombre de mots avec au moins 2 lettres successives en double.

// CONTRAINTES :
// S ne contient que des lettres latines et des espaces.

// 00:05:58
// DUREE


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
        string S = Console.ReadLine();
        S = S.ToLower();
        string[] SString = S.Split(" ");
        int count = 0;
        char lastChar = '\n';
        foreach(string s in SString){
            foreach(char c in s){
                if (c == lastChar){
                    count ++;
                    break;
                }
                lastChar = c;
            }
        }
        Console.WriteLine(count);
    }
}