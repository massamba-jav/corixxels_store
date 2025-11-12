using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CorrixellsStore.Back
{
    //Classe Produit
    internal class Produit
    {
        //Attributs d'un produit
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }

        //Méthode pour calculer la valeur du stock actuel
        public decimal ValeurStock() => Quantite * PrixUnitaire;

        //Redéfinition de la méthode d'affichage 
        public override string ToString() =>$"ID Produit:{Id,-3} Nom :{Nom,-5}  Quantité :{Quantite} u. Prix Unitaire :{PrixUnitaire,8} F CFA Valeur stock : {this.ValeurStock()}";


    
    }
}
