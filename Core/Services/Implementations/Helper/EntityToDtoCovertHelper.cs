using Dtos.Ouput;
using Entities.ERP;

namespace Services.Implementations.Helper
{
    public static class EntityToDtoCovertHelper
    {
        public static WeddingStudioGroupDto ToWeddingStudioGroupDto(this WeddingStudioGroup entity)
        {
            return entity == null
                ? null
                : new WeddingStudioGroupDto()
                {
                    Id = entity.Id,
                    Name = entity.WeddingStudioGroupName,
                    Description = entity.WeddingStudioGroupDesc
                };
        }
    }
}