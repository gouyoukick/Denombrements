using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    /**
    * titre: denombrement
    * description: outil mathématiques
    * auteur: BTSSIO
    * date création: 2021
    * date dernière modification: 09/10/2021
    */
    class Program
    {
        /// <summary>
        /// Multiplication d'une suite d'entiers d'une valeur à une autre
        /// </summary>
        /// <param name="n">petite valeur</param>
        /// <param name="t">grande valeur</param>
        /// <returns>résultat</returns>
        static long Multi(int n, int t)
        {
            long result = 1;
            for (int k = (t - n + 1); k <= t; k++)
                result *= k;
            return result;
        }

        /// <summary>
        /// Demande de saisie avec controle et retour de réponse
        /// </summary>
        /// <param name="message">demande</param>
        /// <returns>réspone</returns>
        static int Saisie(string message)
        {
            int rep=0;
            bool correct;
            do
            {
                try
                {
                    Console.Write(message);
                    rep = int.Parse(Console.ReadLine());
                    correct = true;

                }
                catch
                {
                    correct = false;
                }
            } while (correct == false);
            return rep;
        }

        /// <summary>
        /// Outil Mathématique pour obtenir Permutation, Arrangement et Combinaison
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //choix de l'operation mathématiques
            int choix = 1, n, t;
            long r1, r2;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                //Control de saisie du choix
                try
                {
                    choix = int.Parse(Console.ReadLine());
                }
                catch
                {
                    choix = 4;
                }
                switch (choix)
                {
                    //Operation Sortie du programme
                    case 0:
                        Environment.Exit(0);
                        break;
                    //Opération Permutation
                    case 1:
                        n = Saisie("nombre total d'éléments à gérer = ");
                        long r = Multi(n, n);
                        Console.WriteLine(n + "! = " + r);
                        break;
                    //Opération Arrangement
                    case 2:
                        t = Saisie("nombre total d'éléments à gérer = ");
                        n = Saisie("nombre d'éléments dans le sous ensemble = ");
                        r1 = Multi(n, t);
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r1);
                        break;
                    //Opération Combinaison
                    case 3:
                        t = Saisie("nombre total d'éléments à gérer = ");
                        n = Saisie("nombre d'éléments dans le sous ensemble = ");
                        r1 = Multi(n, t);
                        r2 = Multi(n, n);
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
