namespace Mpc.MyAssociation.Domain.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Domain.Models;

    public interface IMembersRepository
    {
        Task<int> CountAsync();

        Task<MemberModel> FindAsync(int id);

        Task InsertAsync(MemberModel member);

        Task<List<MemberModel>> SearchAsync();
    }
}
