using System;
using System.IO;
using System.Text;

namespace MyTransactionCode
{
    public class MyLogSystem
    {
        public static void Log(string message)
        {
            string name = "Log.txt";
            string Address = Directory.GetCurrentDirectory(); ;
            StringBuilder data = new StringBuilder();
            data.Append(Environment.NewLine + DateTime.Now + ": " + message);

            System.IO.StreamWriter file = new System.IO.StreamWriter(Address + name, true);
            file.WriteLine(data);
            file.Close();
        }
    }
}
