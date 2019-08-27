namespace Mpc.MyAssociation.Domain.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Domain.Models;

    public interface IMembersRepository
    {
        Task<int> CountAsync();

        Task DeleteAsync(int memberId);

        Task<MemberModel> FindAsync(int id);

        Task InsertAsync(MemberModel member);

        Task<List<MemberModel>> SearchAsync(string text);

        Task UpdateAsync(MemberModel member);
    }
}
