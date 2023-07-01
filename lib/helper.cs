class Helper
{
  public Helper()
  {
    Console.ForegroundColor = ConsoleColor.Green;
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
    Une colonne 'Name' est requis.
    ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("=========================================================================");
    Console.WriteLine(@"
    -h, -help                               aide
    -g, -generate                           génère un template csv
    -s, -scan                               lancer le scan
    -f, -file                               spécifié le nom du fichier csv. Par défaut, check.csv
    -la, -listApp                           liste des applications par défaut
    -l, -log                                log d'exécution
    ");
    Console.WriteLine(@"
      Exemple :
        ./registryapp -g testappli
        ./registryapp -f testappli -s
    ");
  }
}