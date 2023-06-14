class Helper
{
  public Helper()
  {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@"
              .-""""-.
             /        \
            /_        _\
           // \      / \\
           |\__\    /__/|
            \    ||    /
             \        /
              \  __  /  \  /          ________________________________
               '.__.'    \/          /                                 \
                |  |     /\         |    Dev : Hellden                  |
                |  |    O  O        |    Project : Registry APP         |
                ----    //         O \_________________________________/
               (    )  //        O
              (\\     //       o
             (  \\    )      o
             (   \\   )   /\
   ___[\______/^^^^^^^\__/) o-)__
  |\__[=======______//________)__\
  \|_______________//____________|
      |||      || //||     |||
      |||      ||  .||     |||
       ||      \/  .\/      ||
                  . .
                 '.'.`
");
    Console.WriteLine(@"
    Bienvenue sur l'outil de contrôle des serveurs !
    Un fichier csv est nécessaire pour lister les programmes autorisés.
    Une colonne Name est requis.
    ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine(@"
    -h, -help                               aide
    -g, -generate-csv                       génére un template de csv
    ");
  }
}