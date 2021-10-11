using System;

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
            int n = 0, t = 0;
            string choix = "1";
            long r1, r2;
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();
                //Saisie nombre total d'éléments à gérer
                if (choix == "1" || choix == "2" || choix == "3")
                t = Saisie("nombre total d'éléments à gérer = ");
                {
                    switch (choix)
                    {
                        //Opération Permutation
                        case "1":
                            long r = Multi(t, t);
                            Console.WriteLine(t + "! = " + r);
                            break;
                        //Opération Arrangement
                        case "2":
                            n = Saisie("nombre d'éléments dans le sous ensemble = ");
                            r1 = Multi(n, t);
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r1);
                            break;
                        //Opération Combinaison
                        case "3":
                            n = Saisie("nombre d'éléments dans le sous ensemble = ");
                            r1 = Multi(n, t);
                            r2 = Multi(n, n);
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                            break;
                    }
                }
                
            }
        }
    }
}
