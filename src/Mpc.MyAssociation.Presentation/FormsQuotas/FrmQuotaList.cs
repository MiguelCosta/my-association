using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpc.MyAssociation.Application.Dto;
using Mpc.MyAssociation.Application.Services.Abstractions;
using Mpc.MyAssociation.Presentation.Core.Helpers;

namespace Mpc.MyAssociation.Presentation.FormsQuotas
{
    public partial class FrmQuotaList : Form
    {
        private IQuotasService _quotasService;

        public FrmQuotaList(IQuotasService quotasService)
        {
            InitializeComponent();
            _quotasService = quotasService;
        }

        private async void FrmQuotaList_Load(object sender, EventArgs e)
        {
            await FillQuotas().ConfigureAwait(true);
        }

        private async Task FillQuotas()
        {
            var members = await _quotasService.SearchAsync(txtSearch.Text).ConfigureAwait(true);

            quotaDtoBindingSource.DataSource = members;
            quotaDtoBindingSource.ResetBindings(false);
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            OpenFormsHelpers.OpenFormDialog<FrmQuotaEdit>();

            await FillQuotas();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            await EditQuota();
        }

        private async Task EditQuota()
        {
            var dataItemSelected = dgvQuotas.GetSelectedItem<QuotaDto>();

            if (dataItemSelected != null)
            {
                var formEdit = Core.IoC.GetForm<FrmQuotaEdit>();
                formEdit.QuotaId = dataItemSelected.Id;
                OpenFormsHelpers.OpenFormDialog(formEdit);
            }

            await FillQuotas();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var dataItemSelected = dgvQuotas.GetSelectedItem<QuotaDto>();

            await _quotasService.DeleteAsync(dataItemSelected.Id);

            await FillQuotas();
        }

        private async void dgvQuotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await EditQuota();
        }
    }
}
