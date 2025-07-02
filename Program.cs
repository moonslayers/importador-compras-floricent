using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportadorRemisiones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                        var importador = new Importador();
            var webServer = new WebServer("http://localhost:5000/", async (json) =>
            {
                await importador.ProcesarFacturaDesdeApi(json);
            });
            webServer.Start();

            Application.Run(importador);

            webServer.Stop();
        }
    }
}
