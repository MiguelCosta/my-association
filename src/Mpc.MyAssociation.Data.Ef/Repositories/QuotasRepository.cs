namespace Mpc.MyAssociation.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyAssociation.Domain.Core.Repositories;
    using Mpc.MyAssociation.Domain.Models;

    public class QuotasRepository : IQuotasRepository
    {
        private readonly AppDbContext _context;

        public QuotasRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> CountAsync()
        {
            return _context.Members.CountAsync();
        }

        public async Task DeleteAsync(int quotaId)
        {
            var member = await _context.Quotas.FindAsync(quotaId).ConfigureAwait(false);
            _context.Remove(member);
        }

        public Task<QuotaModel> FindAsync(int id)
        {
            return _context.Quotas
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task InsertAsync(QuotaModel quota)
        {
            return _context.Quotas.AddAsync(quota);
        }

        public Task<List<QuotaModel>> SearchAsync(string text)
        {
            var query = _context.Quotas.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(text))
            {
                query = query.Where(x => x.Name.Contains(text));
            }

            return query.ToListAsync();
        }

        public Task UpdateAsync(QuotaModel quota)
        {
            _context.Entry(quota).State = EntityState.Modified;

            return Task.CompletedTask;
        }
    }
}
