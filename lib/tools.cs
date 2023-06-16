using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

class Tools
{
  public Tools(string[] args)
  {
    Console.WriteLine("args" + args[0]);
    for (int i = 0; i < args.Length; i++)
    {
      Console.WriteLine("Aguments {0} : " + args[i], i);
      switch (args[i])
      {
        case "-g":
          Generate();
          break;
        case "-generate":
          Console.WriteLine("Generate");
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
  private static void Generate()
  {
    try
    {
      CreateCSV();

      OpenFileGenerate();
    }
    catch (System.Exception)
    {

      throw;
    }
  }

    /* ---------------------------------------------------------------- */
    /*                  Ouvjerture du fichier CSV generé                */
    /* ---------------------------------------------------------------- */
    private static void OpenFileGenerate()
    {

        /* ------------------------ Choice open file ----------------------- */
        string? openFile;
        Console.WriteLine("Voulez-vous l'ouvrir (Y/N)");
        openFile = Console.ReadLine();
        if (openFile == null)
        {
            return;
        }

        string v = openFile.ToLower();
        if (v == "y" || v == "yes")
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Impossible d'ouvrir Excel, erreur : {error.Message}");
                throw;
            }
        }
    }


    /* ---------------------------------------------------------------- */
    /*               Création du fichier CSV avec en-tête               */
    /* ---------------------------------------------------------------- */
    private static void CreateCSV()
  {
    if (string.IsNullOrEmpty("check.csv"))
    {

      using (StreamWriter writer = new("check.csv"))
      {
        writer.WriteLine("Name");
      }
      Console.WriteLine("Fichier Check.csv crée avec succès.");
    }
    else
    {
      Console.WriteLine("Le fichier check.csv est déja présent, voulez-vous le recrée (Y/N) ?");
      string? regenerate;
      regenerate = Console.ReadLine();

      if (regenerate != null)
      {
        string v = regenerate.ToLower();
        if (v == "y" || v == "yes")
        {
          using (StreamWriter writer = new("check.csv"))
          {
            writer.WriteLine("Name");
          }
          Console.WriteLine("Fichier Check.csv regénéré avec succès.");
        }
      }
    }
  }
}
