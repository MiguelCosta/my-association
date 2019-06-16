using System;
using System.Windows.Forms;

namespace Mpc.MyAssociation.Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Core.ApplicationContext.MainForm = this;
        }

        private void MnuMembers_Click(object sender, EventArgs e)
        {
            Core.Helpers.OpenFormsHelpers.OpenForm<FormsMembers.FrmMemberList>();
        }
    }
}
