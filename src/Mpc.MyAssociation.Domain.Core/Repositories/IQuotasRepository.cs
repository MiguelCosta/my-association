namespace Mpc.MyAssociation.Domain.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Domain.Models;

    public interface IQuotasRepository
    {
        Task<int> CountAsync();

        Task DeleteAsync(int quotaId);

        Task<QuotaModel> FindAsync(int id);

        Task InsertAsync(QuotaModel quota);

        Task<List<QuotaModel>> SearchAsync(string text);

        Task UpdateAsync(QuotaModel quota);
    }
}
