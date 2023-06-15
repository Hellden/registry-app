using System;
using System.IO;

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

      /* ------------------------- Generate CSV ------------------------- */
      CreateCSV();

      /* ------------------------ Choice open file ----------------------- */
      string? openFile;
      Console.WriteLine("Voulez-vous l'ouvrir (Y/N)");
      openFile = Console.ReadLine();
      if (openFile != null)
      {
        string v = openFile.ToLower();
        if (v == "y" || v == "yes")
        {

        }
      }
    }
    catch (System.Exception)
    {

      throw;
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
