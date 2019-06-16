using System;
using System.Windows.Forms;
using Mpc.MyAssociation.Application.Services.Abstractions;

namespace Mpc.MyAssociation.Presentation.FormsMembers
{
    public partial class FrmMemberList : Form
    {
        private IMembersService _membersService;

        public FrmMemberList(IMembersService membersService)
        {
            InitializeComponent();
            _membersService = membersService;
        }

        private async void FrmMemberList_Load(object sender, EventArgs e)
        {
            var members = await _membersService.SearchAsync().ConfigureAwait(true);

            memberDtoBindingSource.DataSource = members;
            memberDtoBindingSource.ResetBindings(false);
        }
    }
}
