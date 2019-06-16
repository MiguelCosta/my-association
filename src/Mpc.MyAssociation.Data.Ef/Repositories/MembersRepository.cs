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

        public Task<MemberModel> FindAsync(int id)
        {
            return _context.Members.FindAsync(id);
        }

        public Task InsertAsync(MemberModel member)
        {
            return _context.Members.AddAsync(member);
        }

        public Task<List<MemberModel>> SearchAsync()
        {
            return _context.Members
                .AsNoTracking()
                .ToListAsync();
                //.Skip((pageNumber - 1) * pageSize)
                //.ToListAsync();
        }
    }
}
