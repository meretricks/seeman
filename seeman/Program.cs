using System;
using System.Drawing;
using System.Windows.Forms;

namespace seeman
{
    static class Program
    {
        public static Themes.Theme Theme = new Themes.DarkTheme();
        public static NetStatus NetworkStatus = NetStatus.Local;

        public const string ThemeDirectory = @"\Themes\";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new EditorSubItem());
        }
    }

    public enum NetStatus
    {
        Online,
        Local
    }

}