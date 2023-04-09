// Dans cet exercice, vous devez analyser un relevé de températures pour trouver quelle température se rapproche le plus de zéro.

// Écrivez un programme qui affiche la température la plus proche de 0 parmi les données d'entrée. Si deux nombres sont aussi
// proches de zéro, alors l'entier positif sera considéré comme étant le plus proche de zéro 
// (par exemple, si les températures sont -5 et 5, alors afficher 5).

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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        List<int> temperatures = new List<int>();
        if(inputs[0] == ""){
            Console.WriteLine(0);
            return;
        }
        else{
            temperatures = inputs.Select(input => Int32.Parse(input)).ToList();
        }
        temperatures.Add(0);
        temperatures.Sort();
        if(temperatures.Count == 1){
            Console.WriteLine(0);
            return;
        }
        int zeroIndex = temperatures.IndexOf(0);

        if(zeroIndex == temperatures.Count-1)
        {
            Console.WriteLine(temperatures[zeroIndex-1]);
            return;
        }
        else if(zeroIndex == 0)
        {
            Console.WriteLine(temperatures[1]);
            return;
        }

        else{
            int A = temperatures[zeroIndex-1];
            int B = temperatures[zeroIndex+1];

            if(Math.Min(Math.Abs(A),Math.Abs(B))==A)
                Console.WriteLine(A);
            else
                Console.WriteLine(B);
        }
    }
}