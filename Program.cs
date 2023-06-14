namespace RegistryApp
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // Request Helper script
      if (args.Length == 0 || args[0] == "-h" || args[0] == "-help")
      {
        _ = new Helper();
      }
      else
      {
        _ = new Tools(args);
      }
    }
  }
}