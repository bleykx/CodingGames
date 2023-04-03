// Giving an integer n, you will be given n lines with n numbers.

// For each line, you will need to output the sum of the numbers in the line that are divisible by n.

// Entrée

// Line 1 An integer n.
// Next n lines Each line contains n space-separated positive integers.

// Sortie
// n lines The sum of the numbers in the line that are divisible by n.

// Contraintes
// 0<n<100

//DUREE
//00:02:50

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
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int result = 0;
            
            string[] inputs = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                int integer = int.Parse(inputs[j]);
                if (integer%n == 0){
                    result += integer;
                }
            }
            Console.WriteLine(result);
        }
    }
}