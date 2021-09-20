using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Grâce à ce programme, tu vas pouvoir composer tes propres chorégraphies et même t'en souvenir !

La suite de pas est répétée autant de fois à l'écran que le nombre d'itérations entré par l'utilisateur

Critères de validation
Un lien vers ta solution sur GitHub
La solution itère autant de fois que spécifié par l'utilisateur
Chaque pas de danse est bien affiché à l'écran à chaque itération*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];
            moves[31] = "done";
            Console.Write("Entrez differents mouvements de dance");
            Console.WriteLine("(Mettre le mouvement done lorsque vous avez fini)");
            for (int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine("Nom du mouvement : ");
                moves[i] = Console.ReadLine();
                if (moves[i] == "done")
                {
                    break;
                }
            }
            Console.WriteLine("Entrez le nombre de fois que vous voulez faire le mouvement");
            int nombreIterationPasDeDance = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nombreIterationPasDeDance; i++)
            {
                foreach (string move in moves)
                {
                    if (move == "done" || move == null)
                    {
                        Console.Write("");
                    }
                    else { Console.Write(move + " | "); }
                }
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}
