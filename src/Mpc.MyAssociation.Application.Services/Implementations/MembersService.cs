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
        private readonly IUnitOfWork _unitOfWork;

        public MembersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<MemberDto> CreateAsync(MemberDto member)
        {
            var model = member.ToModel();

            await _unitOfWork.MembersRepository.InsertAsync(model).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return model.ToDto();
        }

        public async Task DeleteAsync(int memberId)
        {
            await _unitOfWork.MembersRepository.DeleteAsync(memberId).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<MemberDto> FindAsync(int memberId)
        {
            var member = await _unitOfWork.MembersRepository.FindAsync(memberId).ConfigureAwait(false);

            return member.ToDto();
        }

        public async Task<List<MemberDto>> SearchAsync(string text = "")
        {
            var membersModel = await _unitOfWork.MembersRepository.SearchAsync(text).ConfigureAwait(false);

            return membersModel.ToDto().ToList();
        }

        public async Task<MemberDto> UpdateAsync(MemberDto member)
        {
            var model = member.ToModel();

            await _unitOfWork.MembersRepository.UpdateAsync(model).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);

            return model.ToDto();
        }
    }
}
