//Nom du programme : PetitJeuDeRole
//Classe : Monstre
//Autheur : Proph
//Mise à jour le : 29/10/2020

using System;
using System.Collections.Generic;
using System.Text;

namespace PetitJeuDeRole
{
    public class Monstre : Entite
    {
        public Monstre(string nom) : base(nom)
        {
            this.nom = nom;
            this.pointsDeVie = 60;
            this.degatsMin = 5;
            this.degatsMax = 10;
        }
    }
}
