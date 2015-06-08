using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMaster
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

            //Stream FS = File.OpenWrite("config2.sm");

            ////Серриализация
            //BinaryFormatter bf = new BinaryFormatter();

            //MessageRandomService MS = new MessageRandomService();

            //bf.Serialize(FS, MS);

            Application.Run(new Start());
        }
    }
}
