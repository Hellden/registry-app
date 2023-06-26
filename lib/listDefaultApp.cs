
namespace registry_app.lib
{
  internal class ListDefaultApp
  {
    public ListDefaultApp()
    {
      Log.New("Demande listing application par défaut déclaré");

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"\n********************* Liste des applications par défaut : {PopultationCSV().Length}  *********************\n");
      Console.ForegroundColor = ConsoleColor.White;
      // Tri alphabétique
      var app = PopultationCSV();
      Array.Sort(app);
      foreach (var item in app)
      {
        Console.WriteLine(item);
      }
    }


    /* ---------------------------------------------------------------- */
    /*                           Populace CSV                           */
    /* ---------------------------------------------------------------- */
    public static string[] PopultationCSV()
    {
      string[] populace = new string[] {
                "Microsoft Visual C++ 2012 x86 Minimum Runtime",
                "Microsoft Visual C++ 2012 x64 Minimum Runtime",
                "Google Chrome",
                "VMware Tools",
                "Fortinet SSO Collector Agent",
                "Microsoft Visual C++ 2012 x86 Additional Runtime",
                "Microsoft Visual C++ 2012 x64 Additional Runtime",
                "WithSecure™ Elements Agent",
                "Microsoft Visual C++ 2019 X64 Additional Runtime",
                "Microsoft Visual C++ 2019 X64 Minimum Runtime",
                "Microsoft Visual C++ 2019 X86 Additional Runtime",
                "Microsoft Visual C++ 2019 X86 Minimum Runtime",
                "SQL Server 2016 Client Tools",
                "Microsoft SQL Server",
                "Microsoft ODBC Driver 13 for SQL Server",
                "Microsoft SQL Server 2012 Native Client",
                "SQL Server 2016 Database Engine Shared",
                "Module linguistique de Microsoft Help Viewer",
                "SQL Server 2016 Shared Management Objects",
                "Fournisseur OLE DB Microsoft Analysis Services",
                "SQL Server Management Studio for Reporting Services",
                "SSMS Post Install Tasks",
                "Microsoft SQL Server 2016 T - SQL Language Service",
                "Microsoft Visual C++ 2019 X86 Minimum Runtime",
                "SQL Server 2016 Connection Info",
                "Microsoft SQL Server 2016 RsFx Driver",
                "Microsoft SQL Server Data - Tier Application Framework(x86) - fr - FR",
                "Microsoft OLE DB Driver pour SQL Server",
                "Module linguistique Shell isolé Visual Studio 2017 pour SSMS - Français",
                "SQL Server 2016 DMF",
                "SQL Server 2016 Client Tools Extensions",
                "SQL Server Management Studio for Analysis Services Localization",
                "Browser pour SQL Server 2016",
                "Enregistreur VSS Microsoft pour SQL Server 2016",
                "Sql Server Customer Experience Improvement Program",
                "SQL Server 2016 Common Files",
                "Microsoft SQL Server 2016 T - SQL ScriptDom",
                "Visual Studio 2017 Isolated Shell for SSMS",
                "SQL Server Management Studio",
                "Fichiers de support d'installation de Microsoft SQL Server 2008",
                "Integration Services",
                "SQL Server 2016 Batch Parser",
                "SQL Server 2016 Shared Management Objects Extensions",
                "SQL Server Management Studio for Reporting Services Localization",
                "Configuration Manager Client",
                "SQL Server 2016 RS_SharePoint_SharedService",
                "Microsoft Visual Studio Tools for Applications 2017 x64 Hosting Support",
                "Microsoft ODBC Driver 17 for SQL Server",
                "SQL Server 2016 Database Engine Services",
                "Microsoft SQL Server 2016 Setup(English)",
                "SQL Server 2016 SQL Diagnostics",
                "Microsoft Visual Studio Tools for Applications 2017 x86 Hosting Support",
                "SQL Server 2016 XEvent"
             };
      return populace;
    }
  }
}
