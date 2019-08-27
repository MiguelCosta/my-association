using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.MyAssociation.Application.Dto;
using Mpc.MyAssociation.Application.Services.Abstractions;

namespace Mpc.MyAssociation.Presentation.FormsMembers
{
    public partial class FrmMemberEdit : Form
    {
        private IMembersService _membersService;

        public FrmMemberEdit(IMembersService membersService)
        {
            InitializeComponent();
            _membersService = membersService;
        }

        public int? MemberId { get; set; } = null;

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (MemberId.HasValue)
            {
                await UpdateUserAsync();
                Core.Messages.Information.ShowMessage("Sócio atualizado", "Sócio");
            }
            else
            {
                await CreateAsync();
                Core.Messages.Information.ShowMessage("Sócio criado", "Sócio");
            }
            Close();
        }

        private async Task CreateAsync()
        {
            var member = GetMember();

            await _membersService.CreateAsync(member).ConfigureAwait(true);
        }

        private void FillMember(MemberDto member)
        {
            txtAddress1.Text = member.AddressLine1;
            txtAddress2.Text = member.AddressLine2;
            txtCity.Text = member.City;
            txtEmail.Text = member.Email;
            txtId.Text = member.Id.ToString();
            txtName.Text = member.Name;
            txtPhoneNumber.Text = member.PhoneNumber;
            txtPostalCode.Text = member.PostalCode;
            txtVat.Text = member.Vat;
        }

        private async void FrmMemberEdit_Load(object sender, EventArgs e)
        {
            if (!MemberId.HasValue)
            {
                return;
            }

            var existmember = await _membersService.FindAsync(MemberId.Value).ConfigureAwait(true);

            if (existmember != null)
            {
                FillMember(existmember);
            }
        }

        private MemberDto GetMember()
        {
            var member = new MemberDto
            {
                AddressLine1 = txtAddress1.Text,
                AddressLine2 = txtAddress2.Text,
                City = txtCity.Text,
                Email = txtEmail.Text,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                PostalCode = txtPostalCode.Text,
                Vat = txtVat.Text
            };

            return member;
        }

        private async Task UpdateUserAsync()
        {
            var member = GetMember();
            member.Id = MemberId.Value;

            await _membersService.UpdateAsync(member).ConfigureAwait(true);
        }
    }
}
