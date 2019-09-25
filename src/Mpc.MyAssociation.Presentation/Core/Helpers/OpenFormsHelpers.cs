using System.Windows.Forms;

namespace Mpc.MyAssociation.Presentation.Core.Helpers
{
    public static class OpenFormsHelpers
    {
        public static void OpenForm<TFrom>() where TFrom : Form
        {
            foreach (var c in ApplicationContext.MainForm.MdiChildren)
            {
                c.Close();
            }

            var form = IoC.GetForm<TFrom>();
            form.MdiParent = ApplicationContext.MainForm;
            form.Show();
            form.WindowState = FormWindowState.Minimized;
            form.WindowState = FormWindowState.Maximized;
        }

        public static void OpenFormDialog<TFrom>() where TFrom : Form
        {
            var form = IoC.GetForm<TFrom>();
            form.ShowDialog();
        }

        public static void OpenFormDialog(Form form)
        {
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
