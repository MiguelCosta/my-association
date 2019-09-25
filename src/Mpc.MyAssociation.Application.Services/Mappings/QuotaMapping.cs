using System.Collections.Generic;
using System.Linq;

namespace Mpc.MyAssociation.Application.Services.Mappings
{
    public static class QuotaMapping
    {
        public static Dto.QuotaDto ToDto(this Domain.Models.QuotaModel model)
        {
            return model == null ? null : new Dto.QuotaDto
            {
                EndDate = model.EndDate,
                Id = model.Id,
                Name = model.Name,
                StartDate = model.StartDate,
                Value = model.Value
            };
        }

        public static IEnumerable<Dto.QuotaDto> ToDto(this IEnumerable<Domain.Models.QuotaModel> models)
        {
            return models.Select(ToDto);
        }

        public static Domain.Models.QuotaModel ToModel(this Dto.QuotaDto dto)
        {
            return dto == null ? null : new Domain.Models.QuotaModel
            {
                EndDate = dto.EndDate,
                Id = dto.Id,
                Name = dto.Name,
                StartDate = dto.StartDate,
                Value = dto.Value
            };
        }
    }
}
