namespace Mpc.MyAssociation.Application.Services.Abstractions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Application.Dto;

    public interface IMembersService
    {
        Task DeleteAsync(int memberId);

        Task<MemberDto> FindAsync(int memberId);

        Task<MemberDto> CreateAsync(MemberDto member);

        Task<List<MemberDto>> SearchAsync(string text = "");

        Task<MemberDto> UpdateAsync(MemberDto member);
    }
}
