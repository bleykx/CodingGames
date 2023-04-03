// Votre programme doit permettre à Thor de rejoindre l'éclair de puissance. L'objectif est d'obtenir 100% avec le code le plus court.

// Règles
// Thor évolue sur une carte de 40 cases de large et 18 cases de hauteur. Notez que les coordonnées (X et Y) commencent en partant du haut ! Ainsi la case la plus en haut à gauche a pour coordonnées "X=0,Y=0" et celle située le plus en bas à droite a pour coordonnées "X=39,Y=17".

// Au début du programme vous recevez :
// la variable lightX : la position X de l'éclair que Thor doit rejoindre.
// la variable lightY : la position Y de l'éclair que Thor doit rejoindre.
// la variable initialTX : la position X initiale de Thor.
// la variable initialTY : la position Y initiale de Thor.

// À la fin du tour de jeu, vous devez afficher la direction que Thor doit prendre parmi :
	
// N (Nord)
// NE (Nord-Est)
// E (Est)
// SE (Sud-Est)
// S (Sud)
// SW (Sud-Ouest)
// W (Ouest)
// NW (Nord-Ouest)

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position

        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.
            
            if(LX > TX){
                if(LY > TY){
                    Console.WriteLine("SE");
                    TY ++;
                }
                else if(LY == TY)
                    Console.WriteLine("E");
                else{
                    Console.WriteLine("NE");
                    TY --;
                }
                TX ++;
            }
            else if (LX < TX){
                if(LY > TY){
                    Console.WriteLine("SW");
                    TY ++;
                }
                else if(LY == TY){
                    Console.WriteLine("W");
                }
                else
                    Console.WriteLine("E");
                TX --;
            }   
            else
            {
                if(LY > TY){
                    Console.WriteLine("S");
                    TY ++;
                }
                else{
                    Console.WriteLine("N");
                    TY --;
                }
            }
        }
    }
}