using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace CorrixellsStore.Enregistrement
{
    internal class ExportCSV
    {
        public static void ExporterListeCSV<T>(List<T> liste, string nomFichier)
        {
            using (StreamWriter sw = new StreamWriter(nomFichier, false, Encoding.UTF8))
            {
                // Récupère les propriétés publiques de la classe
                PropertyInfo[] props = typeof(T).GetProperties();

                // Ligne des titres (noms des propriétés)
                sw.WriteLine(string.Join(";", props.Select(p => p.Name)));

                // Lignes de données
                foreach (var item in liste)
                {
                    var valeurs = props.Select(p => p.GetValue(item, null)?.ToString() ?? "");
                    sw.WriteLine(string.Join(";", valeurs));
                }
            }
        }
    }
}
