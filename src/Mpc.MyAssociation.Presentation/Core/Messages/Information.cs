using System.Windows.Forms;

namespace Mpc.MyAssociation.Presentation.Core.Messages
{
    public static class Information
    {
        public static void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
