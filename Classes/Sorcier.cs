//Nom du programme : PetitJeuDeRole
//Classe : Sorcier
//Autheur : Proph
//Mise à jour le : 29/10/2020

using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeuDeRole
{
    public class Sorcier : Personnage
    {
        public Sorcier (string nom) : base(nom)
        {
            pointsDeVie = 80;
            degatsMin = 10;
            degatsMax = 25;

        }
    }
}
