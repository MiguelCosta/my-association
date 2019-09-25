namespace Mpc.MyAssociation.Application.Services.Abstractions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Application.Dto;

    public interface IQuotasService
    {
        Task<QuotaDto> CreateAsync(QuotaDto quota);

        Task DeleteAsync(int quotaId);

        Task<QuotaDto> FindAsync(int quotaId);

        Task<List<QuotaDto>> SearchAsync(string text = "");

        Task<QuotaDto> UpdateAsync(QuotaDto quota);
    }
}
