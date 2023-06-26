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
            //Test check.csv
            TestCsv();
        }

        private void TestCsv()
        {
            try
            {
                if (File.Exists(_fileName)) { return; }
                Tools.NewGenerate();
            }
            catch (Exception err)
            {
                Log.Error(err.Message);
                Console.WriteLine(err.Message);
                throw;
            }
        }

        public static void New(string? filePath)
        {
            new Scan().LaunchScan(filePath);
            Console.WriteLine($"Le file path est : {filePath}");
        }
    }
}
