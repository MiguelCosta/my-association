using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.MyAssociation.Application.Dto;
using Mpc.MyAssociation.Application.Services.Abstractions;
using Mpc.MyAssociation.Presentation.Core.Helpers;

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

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var dataItemSelected = dgvMembers.GetSelectedItem<MemberDto>();

            await _membersService.DeleteAsync(dataItemSelected.Id).ConfigureAwait(true);

            await FillMembers().ConfigureAwait(true);
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            await EditMember();
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenFormDialog<FrmMemberEdit>();

            await FillMembers().ConfigureAwait(true);
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            await FillMembers().ConfigureAwait(true);
        }

        private async void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await EditMember();
        }

        private async Task EditMember()
        {
            var dataItemSelected = dgvMembers.GetSelectedItem<MemberDto>();

            if (dataItemSelected != null)
            {
                var formEdit = Core.IoC.GetForm<FrmMemberEdit>();
                formEdit.MemberId = dataItemSelected.Id;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }

            await FillMembers().ConfigureAwait(true);
        }

        private async Task FillMembers()
        {
            var members = await _membersService.SearchAsync(txtSearch.Text).ConfigureAwait(true);

            memberDtoBindingSource.DataSource = members;
            memberDtoBindingSource.ResetBindings(false);
        }

        private async void FrmMemberList_Load(object sender, EventArgs e)
        {
            await FillMembers().ConfigureAwait(true);
        }
    }
}
