class Tools
{
  public Tools(String[] args)
  {
    Console.WriteLine("args" + args[0]);
    for (int i = 0; i < args.Length; i++)
    {
      Console.WriteLine("Aguments {0} : " + args[i], i);
      switch (args[i])
      {
        case "list":
          Console.WriteLine("Coucou");
          break;

        default:
          break;
      }
    }
  }
}