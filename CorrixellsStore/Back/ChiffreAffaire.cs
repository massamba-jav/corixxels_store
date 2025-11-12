using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CorrixellsStore.Back
{
    internal class ChiffreAffaire
    {

        public static decimal chiffreAffaireactuel =0;
        public static void calculerChiffreAffairre()
        {
            // Récupération de la liste des ventes actuelles
            List<Vente> listeventes = FichierJson.recupererlistevente();
            DateTime date = DateTime.Now ;

            foreach(Vente vente in listeventes)
            {
                date = vente.DateVente;
                ChiffreAffaire.chiffreAffaireactuel +=  vente.MontantTotal;
            }
            if(ChiffreAffaire.chiffreAffaireactuel!= 0) Console.WriteLine($"Voici le chiffre d'affaire actuel est : {ChiffreAffaire.chiffreAffaireactuel} F CFA  depuis la vente effectuée le {date}");
            else Console.WriteLine($"Chiffre d'affaire actuellement nulle aucune vente effectuée ! ");


        }
    }
}
