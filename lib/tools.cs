using registry_app.lib;
using System.Diagnostics;
using System.Text.RegularExpressions;

class Tools
{
    private readonly string _fileName = "check.csv";


    public Tools(string[] args)
    {
        /*
            ^ : Correspond au début de la chaîne.
            [^-]* : Représente une séquence de zéro ou plusieurs caractères qui ne sont pas "-".
            $ : Correspond à la fin de la chaîne.
        */
        string pattern = @"^[^-]*$";
        Regex rg = new(pattern);

        //Read arguments
        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "-g":
                    Generate();
                    break;
                case "-generate":
                    Generate();
                    break;
                case "-s":
                    string argRegex = args[i + 1];

                    if (rg.IsMatch(args[i + 1]))
                    {
                        Console.WriteLine("Argument valide");
                    }
                    else
                    {
                        Console.WriteLine("Non valide");
                    }
                    break;
                case "-scan":
                    Scan.New(args[i + 1]);
                    break;
                default:
                    break;
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
    }


    /* ---------------------------------------------------------------- */
    /*                       Generate template csv                      */
    /* ---------------------------------------------------------------- */
    private void Generate()
    {
        try
        {
            CreateCSV();

            OpenFileGenerate();
        }
        catch (Exception err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err.Message);
            Log.Error(err.Message);
            throw;
        }
    }


    /* ---------------------------------------------------------------- */
    /*               Création du fichier CSV avec en-tête               */
    /* ---------------------------------------------------------------- */

    // TODO: Ajouter dans le template, la liste des programmes par défaut windows et plus
    private void CreateCSV()
    {
        if (File.Exists(_fileName))
        {
            try
            {
                Console.WriteLine($"Le fichier {_fileName} est déjà présent. Date de création du document : {File.GetCreationTime(_fileName)}, voulez-vous le recréer (Y/N) ?");
                string? regenerate;
                regenerate = Console.ReadLine();

                if (regenerate != null)
                {
                    string v = regenerate.ToLower();
                    if (v == "y" || v == "yes")
                    {
                        using (StreamWriter writer = new(_fileName))
                        {
                            writer.WriteLine("Name");
                        }
                        Console.WriteLine($"Fichier Check.csv regénéré avec succès à la date du : {File.GetCreationTime(_fileName)}.");
                        Log.New("Génération du fichier csv");
                    }
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(err.Message);
                Log.Error(err.Message);
                throw;
            }

        }
        else
        {
            try
            {
                using (StreamWriter writer = new(_fileName))
                {
                    writer.WriteLine("Name");
                }
                Console.WriteLine("Fichier Check.csv crée avec succès.");
                Log.New("Génération du fichier csv");

            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(err.Message);
                Log.Error(err.Message);
                throw;
            }

        }
    }


    /* ---------------------------------------------------------------- */
    /*                  Ouverture du fichier CSV généré                */
    /* ---------------------------------------------------------------- */
    private void OpenFileGenerate()
    {
        /* ------------------------ Choice open file ----------------------- */
        string? openFile;
        Console.WriteLine("Voulez-vous l'ouvrir (Y/N)");
        openFile = Console.ReadLine();
        if (openFile == null || openFile.ToLower() == "n")
        {
            return;
        }

        string v = openFile.ToLower();
        if (v == "y" || v == "yes")
        {
            try
            {
                //Création du process
                ProcessStartInfo startInfo = new()
                {
                    FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE",
                    Arguments = _fileName
                };

                //Exécution du process
                using Process process = Process.Start(startInfo);
                Log.New("Ouverture du template csv");
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Impossible d'ouvrir Excel, erreur : {err.Message}");
                Log.Error(err.Message);
                throw;
            }
        }
        else
        {
            return;
        }
    }
}
