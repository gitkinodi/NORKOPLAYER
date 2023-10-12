using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NORKOPLAYER
{
    internal static class Program
    {
        [STAThread]

        private static void Main()
        {
            if (AntiDuplApp())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);
                Application.Run(new MainForm());
            }
        }


        private static bool AntiDuplApp()
        {
            Process MyProcess = Process.GetCurrentProcess();

            foreach (Process process in Process.GetProcessesByName(MyProcess.ProcessName))
            {
                if (process.Id != MyProcess.Id)
                {
                    if (Application.ExecutablePath == MyProcess.MainModule.FileName)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
