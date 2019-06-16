namespace Mpc.MyAssociation.Application.Services.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.MyAssociation.Application.Dto;
    using Mpc.MyAssociation.Application.Services.Abstractions;
    using Mpc.MyAssociation.Application.Services.Mappings;
    using Mpc.MyAssociation.Domain.Core;

    public class MembersService : IMembersService
    {
        private IUnitOfWork _unitOfWork;

        public MembersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task DeleteAsync(int memberId)
        {
            throw new System.NotImplementedException();
        }

        public Task<MemberDto> FindAsync(int memberId)
        {
            throw new System.NotImplementedException();
        }

        public Task<MemberDto> InsertAsync(MemberDto member)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<MemberDto>> SearchAsync()
        {
            var membersModel = await _unitOfWork.MembersRepository.SearchAsync().ConfigureAwait(false);

            return membersModel.ToDto().ToList();
        }

        public Task<MemberDto> UpdateAsync(int memberId, MemberDto member)
        {
            throw new System.NotImplementedException();
        }
    }
}
