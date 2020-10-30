//Nom du programme : PetitJeuDeRole
//Classe : Archer
//Autheur : Proph
//Mise à jour le : 29/10/2020

using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeuDeRole
{
    public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 100;
            degatsMin = 15;
            degatsMax = 20;

        }
    }
}
