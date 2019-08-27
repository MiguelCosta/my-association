namespace Mpc.MyAssociation.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyAssociation.Domain.Core.Repositories;
    using Mpc.MyAssociation.Domain.Models;

    public class MembersRepository : IMembersRepository
    {
        private readonly AppDbContext _context;

        public MembersRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> CountAsync()
        {
            return _context.Members.CountAsync();
        }

        public async Task DeleteAsync(int memberId)
        {
            var member = await _context.Members.FindAsync(memberId).ConfigureAwait(false);
            _context.Remove(member);
        }

        public Task<MemberModel> FindAsync(int id)
        {
            return _context.Members
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task InsertAsync(MemberModel member)
        {
            return _context.Members.AddAsync(member);
        }

        public Task<List<MemberModel>> SearchAsync(string text)
        {
            var query = _context.Members.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(text))
            {
                query = query.Where(x => x.AddressLine1.Contains(text)
                    || x.AddressLine2.Contains(text)
                    || x.City.Contains(text)
                    || x.Email.Contains(text)
                    || x.Name.Contains(text)
                    || x.PhoneNumber.Contains(text)
                    || x.PostalCode.Contains(text)
                    || x.Vat.Contains(text));
            }

            return query.ToListAsync();
        }

        public Task UpdateAsync(MemberModel member)
        {
            _context.Entry(member).State = EntityState.Modified;

            return Task.CompletedTask;
        }
    }
}
