namespace Mpc.MyAssociation.Application.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Application.Dto;
    using Mpc.MyAssociation.Application.Services.Abstractions;
    using Mpc.MyAssociation.Application.Services.Mappings;
    using Mpc.MyAssociation.Domain.Core;

    public class QuotasService : IQuotasService
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuotasService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<QuotaDto> CreateAsync(QuotaDto quota)
        {
            var model = quota.ToModel();

            await _unitOfWork.QuotasRepository.InsertAsync(model).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return model.ToDto();
        }

        public async Task DeleteAsync(int quotaId)
        {
            await _unitOfWork.QuotasRepository.DeleteAsync(quotaId).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<QuotaDto> FindAsync(int quotaId)
        {
            var member = await _unitOfWork.QuotasRepository.FindAsync(quotaId).ConfigureAwait(false);

            return member.ToDto();
        }

        public async Task<List<QuotaDto>> SearchAsync(string text = "")
        {
            var quotasModel = await _unitOfWork.QuotasRepository.SearchAsync(text).ConfigureAwait(false);

            return quotasModel.ToDto().ToList();
        }

        public async Task<QuotaDto> UpdateAsync(QuotaDto quota)
        {
            var model = quota.ToModel();

            await _unitOfWork.QuotasRepository.UpdateAsync(model).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return model.ToDto();
        }
    }
}
