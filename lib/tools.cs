using System.Diagnostics;
using System.Text.RegularExpressions;

namespace registry_app.lib
{
    internal class Tools
    {
        public string Filename { get; set; } = "check.csv";

        public static void New(string[] args)
        {
            new Tools().Main(args);
        }

        private void Main(string[] args)
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
                        if (rg.IsMatch(args[i] + 1))
                        {
                            Console.WriteLine(Filename);
                            Filename = args[i] + 1;
                        }

                        Generate();
                        break;
                    case "-generate":
                        if (rg.IsMatch(args[i] + 1))
                        {
                            Filename = args[i] + 1;
                        }
                        Generate();
                        break;
                    case "-s":
                        if (rg.IsMatch(args[i + 1]))
                        {
                            Console.WriteLine("Argument valide");
                            Scan.New(args[i + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Non valide");
                        }
                        break;
                    case "-scan":
                        Scan.New(args[i + 1]);
                        break;
                    case "-la":
                        _ = new ListDefaultApp();
                        break;
                    case "-listApp":
                        _ = new ListDefaultApp();
                        break;
                    case "-l":
                        break;
                    case "-log":
                        break;

                    default:
                        _ = new Helper();
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

        public static void NewGenerate()
        {
            new Tools().Generate();
        }
        /* ---------------------------------------------------------------- */
        /*               Création du fichier CSV avec en-tête               */
        /* ---------------------------------------------------------------- */
        private void CreateCSV()
        {
            if (File.Exists(Filename))
            {
                try
                {
                    Console.WriteLine($"Le fichier {Filename} est déjà présent. Date de création du document : {File.GetCreationTime(Filename)}, voulez-vous le recréer (Y/N) ?");
                    string? regenerate;
                    regenerate = Console.ReadLine();

                    if (regenerate != null)
                    {
                        string v = regenerate.ToLower();
                        if (v == "y" || v == "yes")
                        {
                            using (StreamWriter writer = new(Filename))
                            {
                                writer.WriteLine("Name");
                            }
                            Console.WriteLine($"Fichier Check.csv regénéré avec succès à la date du : {File.GetCreationTime(Filename)}.");
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
                    using (StreamWriter writer = new(Filename))
                    {
                        writer.WriteLine("Name");

                        // Add list default app
                        var app = ListDefaultApp.PopultationCSV();
                        Array.Sort(app);
                        foreach (var item in app)
                        {
                            writer.WriteLine(item);
                        }
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
                        Arguments = Filename
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
}
