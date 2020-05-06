using Control.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public static class Program
    {
        public static readonly Conexion conex = new Conexion();
        public static readonly Color colorTeal = Color.FromArgb(0, 121, 107);
        public static readonly Color colorRed = Color.FromArgb(211, 47, 47);
        public static readonly Color colorIndigo = Color.FromArgb(48, 63, 159);
        public static readonly Color colorBlueGray = Color.FromArgb(69, 90, 100);
        public static readonly Color colorGray = Color.FromArgb(97, 97, 97);
        public static readonly Color colorPink = Color.FromArgb(194, 24, 91);
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
