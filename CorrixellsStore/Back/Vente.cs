using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CorrixellsStore.Back
{
    //Classe Vente
    internal class Vente
    {
        //Attributs d'une vente
        public int IdVente { get; set; }
        public int ProduitId { get; set; }
        public int QuantiteVendue { get; set; }
        public DateTime DateVente { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal MontantTotal => QuantiteVendue * PrixUnitaire;
       
    }
}
