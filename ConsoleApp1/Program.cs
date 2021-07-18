using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0;
            int compteur = 0;
            int level = 0;
            int nombreJoueur = 0;
            bool Rejouer = true;

            while (Rejouer == true)
            {

                Console.WriteLine("Bienvenue dans le jeu du Plus ou Moins !");
                Console.WriteLine("Veuillez choisir le niveau désiré.");
                Console.WriteLine("Niveau 1 : compris entre 1 et 10");
                Console.WriteLine("Niveau 2 : compris entre 1 et 100");
                Console.WriteLine("Niveau 3 : compris entre 1 et 1000");
                level = Int32.Parse(Console.ReadLine());

                while ((level != 1) & (level != 2) & (level != 3))
                {
                    Console.WriteLine("Veuillez choisir un niveaux parmis les niveaux 1, 2 ou 3");
                    level = Int32.Parse(Console.ReadLine());
                }
                switch (level)
                {
                    case 1:
                        {
                            maxValue = 11;
                        }
                        break;

                    case 2:
                        {
                            maxValue = 101;
                        }
                        break;
                    case 3:
                        {
                            maxValue = 1001;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Veuillez choisir un niveaux parmis les niveaux 1, 2 ou 3");
                            level = Int32.Parse(Console.ReadLine());
                        }
                        break;
                }

                System.Random rand = new System.Random();
                int un_rand = rand.Next(maxValue);


                Console.WriteLine("veuillez entrer un nombre: ");
                nombreJoueur = Int32.Parse(Console.ReadLine());
                compteur++;

                do
                    if (level == 1 & nombreJoueur > 11)
                    {
                        Console.WriteLine("Veuillez entrer un nombre inférieur à 11");
                        nombreJoueur = Int32.Parse(Console.ReadLine());
                    }
                    else if (level == 2 & nombreJoueur > 101)
                    {
                        Console.WriteLine("Veuillez entrer un nombre inférieur à 101");
                        nombreJoueur = Int32.Parse(Console.ReadLine());
                    }
                    else if (level == 3 & nombreJoueur > 1001)
                    {
                        Console.WriteLine("Veuillez entrer un nombre inférieur à 1001");
                        nombreJoueur = Int32.Parse(Console.ReadLine());
                    }
                while ((level == 1 & nombreJoueur > 11) | (level == 2 & nombreJoueur > 101) | (level == 3 & nombreJoueur > 1001));

                while (nombreJoueur != un_rand)
                {
                    compteur++;

                    if (nombreJoueur > un_rand)
                    {
                        Console.WriteLine("C'est moins, veuillez entrer un nouveau nombre");
                        nombreJoueur = Int32.Parse(Console.ReadLine());
                    }
                    else if (nombreJoueur < un_rand)
                    {
                        Console.WriteLine("C'est plus, veuillez entrer un nouveau nombre");
                        nombreJoueur = Int32.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine($"Bravo, vous avez trouvé le nombre Mystere, en {compteur} coups ! Voulez vous refaire une partie ?");
                string RejouerString = Console.ReadLine();

                if (RejouerString.ToLower() == "oui")
                {
                    Rejouer = true;
                }
                else if (RejouerString.ToLower() == "non")
                {
                    Rejouer = false;
                }
            }
        }

    }
}
