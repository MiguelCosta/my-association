namespace Mpc.MyAssociation.Presentation
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Core.IoC.Init();
            var frmMain = Core.IoC.GetForm<FrmMain>();

            Application.ThreadException += Application_ThreadException;

            Application.Run(frmMain);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Core.Messages.Information.ShowMessage(e.Exception.Message, "Error");
        }
    }
}
