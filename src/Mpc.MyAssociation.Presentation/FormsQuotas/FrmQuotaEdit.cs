using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.MyAssociation.Application.Dto;
using Mpc.MyAssociation.Application.Services.Abstractions;

namespace Mpc.MyAssociation.Presentation.FormsQuotas
{
    public partial class FrmQuotaEdit : Form
    {
        private IQuotasService _quotasService;

        public FrmQuotaEdit(IQuotasService quotasService)
        {
            InitializeComponent();
            _quotasService = quotasService;
        }

        public int? QuotaId { get; set; } = null;

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (QuotaId.HasValue)
            {
                await UpdateQuota();
                Core.Messages.Information.ShowMessage("Quota atualizada", "Quota");
            }
            else
            {
                await CreateAsync();
                Core.Messages.Information.ShowMessage("Quota criada", "Quota");
            }
            Close();
        }

        private async Task CreateAsync()
        {
            var quota = GetQuota();

            await _quotasService.CreateAsync(quota).ConfigureAwait(true);
        }

        private void FillQuota(QuotaDto quota)
        {
            txtId.Text = quota.Id.ToString();
            txtName.Text = quota.Name;
            txtValue.Text = quota.Value.ToString();
            dtpEndDate.Value = quota.EndDate;
            dtpStartDate.Value = quota.StartDate;
        }

        private async void FrmQuotaEdit_Load(object sender, EventArgs e)
        {
            if (!QuotaId.HasValue)
            {
                return;
            }

            var existmember = await _quotasService.FindAsync(QuotaId.Value).ConfigureAwait(true);

            if (existmember != null)
            {
                FillQuota(existmember);
            }
        }

        private QuotaDto GetQuota()
        {
            var quota = new QuotaDto
            {
                EndDate = dtpEndDate.Value,
                Name = txtName.Text,
                StartDate = dtpStartDate.Value
            };

            if (decimal.TryParse(txtValue.Text, out var value))
            {
                quota.Value = value;
            }
            else
            {
                throw new InvalidOperationException("Valor inválido");
            }

            return quota;
        }

        private async Task UpdateQuota()
        {
            var quota = GetQuota();
            quota.Id = QuotaId.Value;

            await _quotasService.UpdateAsync(quota).ConfigureAwait(true);
        }
    }
}
