using System.Collections.Generic;
using System.Linq;

namespace Mpc.MyAssociation.Application.Services.Mappings
{
    public static class MemberMapping
    {
        public static Dto.MemberDto ToDto(this Domain.Models.MemberModel model)
        {
            return model == null ? null : new Dto.MemberDto
            {
                AddressLine1 = model.AddressLine1,
                AddressLine2 = model.AddressLine2,
                City = model.City,
                Email = model.Email,
                Id = model.Id,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                PostalCode = model.PostalCode,
                Vat = model.Vat
            };
        }

        public static IEnumerable<Dto.MemberDto> ToDto(this IEnumerable<Domain.Models.MemberModel> models)
        {
            return models.Select(ToDto);
        }
    }
}
