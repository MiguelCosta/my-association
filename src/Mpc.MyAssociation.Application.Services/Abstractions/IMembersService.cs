namespace Mpc.MyAssociation.Application.Services.Abstractions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Application.Dto;

    public interface IMembersService
    {
        Task DeleteAsync(int memberId);

        Task<MemberDto> FindAsync(int memberId);

        Task<MemberDto> InsertAsync(MemberDto member);

        Task<List<MemberDto>> SearchAsync();

        Task<MemberDto> UpdateAsync(int memberId, MemberDto member);
    }
}
