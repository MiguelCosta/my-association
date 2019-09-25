namespace Mpc.MyAssociation.Data.Ef
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Domain.Core;
    using Mpc.MyAssociation.Domain.Core.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private readonly Lazy<IMembersRepository> _membersRepository;
        private readonly Lazy<IQuotasRepository> _quotasRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            _membersRepository = new Lazy<IMembersRepository>(() => new Repositories.MembersRepository(_context));
            _quotasRepository = new Lazy<IQuotasRepository>(() => new Repositories.QuotasRepository(_context));
        }

        public IMembersRepository MembersRepository => _membersRepository.Value;

        public IQuotasRepository QuotasRepository => _quotasRepository.Value;

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);

            var entities = _context.ChangeTracker.Entries().ToList();

            foreach (var entry in entities)
            {
                entry.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
        }
    }
}
