using System;
using System.Collections.Generic;

namespace registry_app.lib
{
    internal class Log
    {
        private readonly string _logName = $"{Environment.CurrentDirectory}/event.log";

        private void WriteLog(string? message)
        {
            // Create fileLog
            using StreamWriter writer = new(_logName, true);

            if (new FileInfo(_logName).Length == 0)
            {
                writer.WriteLine($"[{DateTime.Now}] | [INFO] : Création du fichier de log");
            }
            writer.WriteLine($"[{DateTime.Now}] | [INFO] : {message}");
        }

        /* ---------------------------------------------------------------- */
        /*                          CREATE ERROR LOG                        */
        /* ---------------------------------------------------------------- */
        private void ErrorLog(string? message)
        {
            // Create fileLog
            using StreamWriter writer = new(_logName, true);

            if (new FileInfo(_logName).Length == 0)
            {
                writer.WriteLine($"[{DateTime.Now}] | [INFO] :   Création du fichier de log");
            }
            writer.WriteLine($"⚠️ [{DateTime.Now}] | [ERROR] : {message}");
        }

        public static void New(string? message = null)
        {
            Log createLog = new();
            createLog.WriteLog(message);
        }

        public static void Error(string? message = null)
        {
            Log createLog = new();
            createLog.ErrorLog(message);
        }
    }
}
