// Here we have two lists of integers. that we would like to compute the sum of the power of elements of list L1 using elements of list L2 (the exponents).

// Entrée
// Line1: An integer N for the number of elements in each list
// Line 2: The elements of the 1st list L1
// Line 3: The elements of the 2nd list L2

// Sortie
// Line 1: sum the elements of the power of L1

// Entrée
// 5
// 2 4 6 8 10
// 1 2 3 4 5

// Sortie 
// 104330


// DUREE
// 00:06:40

//TAILLE
//620 CHAR

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
        int nCount = int.Parse(Console.ReadLine());
        double result = 0;
        string[] inputsX = Console.ReadLine().Split(' ');
        string[] inputsY = Console.ReadLine().Split(' ');
        for (int i = 0; i < nCount; i++)
        {
            int x = int.Parse(inputsX[i]);
            int y = int.Parse(inputsY[i]);

            result += Math.Pow(x,y);
        }
        
        Console.WriteLine(result);
    }
}