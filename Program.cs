using System;
using System.Windows.Forms;

namespace SmartMartBillingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SmartMartBillingSystem());
        }
    }
}
