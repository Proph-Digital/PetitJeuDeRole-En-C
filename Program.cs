//Nom du programme : PetitJeuDeRole
//Classe : Program
//Autheur : Proph
//Mise à jour le : 29/10/2020

using System;

namespace PetitJeuDeRole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            Monstre monstre = new Monstre("Orc du Mordor");
            bool victoire = true;
            bool suivant = false;

            while (!monstre.EstMort())
            {
                //C'est au tour du monstre de nous attaquer
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }

                //À notre tour d'attaquer le monstre
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
            }

            if(victoire)
            {
                monPerso.gagnerExperience(5);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristiques());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Salle suivant ? (O/N)");
                    string saisie = Console.ReadLine().ToUpper();
                    if(saisie == "O")
                    {
                        suivant = true;
                        Jouer(monPerso);
                    }
                    else if(saisie == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("C'est perdu...");
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("===============");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PetitJeuDeRole");
            Console.WriteLine("- by Proph");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("===============");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Quel est ton pseudo ?");
            Console.ForegroundColor = ConsoleColor.White;
            string pseudo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();

            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Sorcier");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vous avez choisis d'être Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier(pseudo));
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vous avez choisis d'être Sorcier !");
                    Console.WriteLine();
                    Jouer(new Sorcier(pseudo));
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vous avez choisis d'être Archer !");
                    Console.WriteLine();
                    Jouer(new Archer(pseudo));
                    break;
                case "4":
                    break;
            }
        }
    }
}
