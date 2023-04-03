// Le mode de jeu est REVERSE : Vous n'avez pas accès à l'énoncé. Vous devez trouver quoi faire en observant les jeux de tests suivants :

// ENTREE
// lower 3

// SORTIE a b C

// ENTREE 
// 26
// uPpeR

// SORTIE 

// A B C D E F G H I J K L M N O P Q R S T U V W X Y Z

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
        string caseOrTrick = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string answer = "";

        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        if(n < 0 || n > 26){
            Console.WriteLine("ERROR");
            return;
        }
        for(int i=0; i < n; i++){
            answer += alphabet[i]+" ";
        }

        if(caseOrTrick.ToUpper() == "UPPER"){
            Console.WriteLine(answer.ToUpper().Substring(0, answer.Length - 1));
        }else if(caseOrTrick.ToLower() == "lower"){
            Console.WriteLine(answer.ToLower().Substring(0, answer.Length - 1));
        }
    }
}