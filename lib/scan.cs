using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registry_app.lib
{
    internal class Scan
    {
        private readonly string _fileName = $"{Environment.CurrentDirectory}/check.csv";

        /* TODO: Spécification SCAN
             - Test si un fichier csv existe, sinon redirigé vers la génération
             - Lire le fichier csv
             - Intérogé via wmi la liste des programmes installés
             - Comparé avec les pré-requis minimum
             - Afficher un comparatif des éléments ne devant pas être installé
         */

        private void LaunchScan(string? filePath)
        {
           
        }

        public static void New(string? filePath)
        {
            Scan scan = new();
            Console.WriteLine($"Le file path est : {filePath}");
        }
    }
}
