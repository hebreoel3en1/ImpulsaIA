using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ImpulsaStore {
    static class Program {
        [STAThread]
        static void Main() {
            try {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string htmlPath = Path.Combine(baseDir, "index.html");

                if (!File.Exists(htmlPath)) {
                    MessageBox.Show(
                        "No se encontró el archivo 'index.html' en la carpeta:\n" + baseDir +
                        "\n\nAsegúrate de descomprimir todo el contenido del archivo ZIP.",
                        "Impulsa Store Manizales — Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Intentar abrir con Microsoft Edge en modo aplicación de escritorio (--app)
                string[] edgePaths = new string[] {
                    @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
                    @"C:\Program Files\Microsoft\Edge\Application\msedge.exe",
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Microsoft\Edge\Application\msedge.exe")
                };

                string edgeExe = null;
                foreach (string p in edgePaths) {
                    if (File.Exists(p)) {
                        edgeExe = p;
                        break;
                    }
                }

                if (edgeExe != null) {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = edgeExe;
                    psi.Arguments = string.Format("--app=\"{0}\" --window-size=1400,900", htmlPath);
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                } else {
                    // Fallback al navegador predeterminado del sistema
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = htmlPath;
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
            } catch (Exception ex) {
                MessageBox.Show(
                    "Ocurrió un error al iniciar Impulsa Store:\n" + ex.Message,
                    "Impulsa Store Manizales",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
