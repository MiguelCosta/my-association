namespace Mpc.MyAssociation.Domain.Core
{
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Domain.Core.Repositories;

    public interface IUnitOfWork
    {
        IMembersRepository MembersRepository { get; }

        Task SaveChangesAsync();
    }
}
