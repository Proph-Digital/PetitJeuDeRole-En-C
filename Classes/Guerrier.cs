//Nom du programme : PetitJeuDeRole
//Classe : Guerrier
//Autheur : Proph
//Mise à jour le : 29/10/2020

using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeuDeRole
{
    public class Guerrier : Personnage
    {
        public Guerrier(string nom) : base(nom)
        {
            pointsDeVie = 120;
            degatsMin = 10;
            degatsMax = 15;

        }
    }
}
