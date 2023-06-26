using registry_app.lib;

namespace RegistryApp
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Log.New("Démarrage du programme.");

      // Request Helper script
      if (args.Length == 0 || args[0] == "-h" || args[0] == "-help")
      {
        _ = new Helper();
      }
      else
      {
        Tools.New(args);
      }
    }
  }
}