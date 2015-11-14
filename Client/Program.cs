using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            Application.Run(new Login());
        }
    }
}
