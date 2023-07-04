using Hotel;
using log4net;
using log4net.Config;
using System.Reflection;

namespace CapaVista
{
    internal static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // Verificar si el directorio de salida existe
            string outputDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Configurar log4net
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }

    }
}