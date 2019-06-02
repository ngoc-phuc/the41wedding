using System.Linq;

using Common.Extensions;

using Dtos.Ouput;

using Entities.ERP;

namespace Services.Implementations.Helper
{
    public static class EntityToDtoCovertHelper
    {
        public static WeddingStudioGroupDto ToWeddingStudioGroupDto(this WeddingStudioGroup entity, int? stateProvinceId, int? districtId)
        {
            return entity == null
                ? null
                : new WeddingStudioGroupDto
                {
                    Id = entity.Id,
                    No = entity.WeddingStudioGroupNo,
                    Name = entity.WeddingStudioGroupName,
                    Desc = entity.WeddingStudioGroupDesc,
                    WeddingStudioCount = entity.WeddingStudios.IsNullOrEmpty()
                        ? 0
                        : stateProvinceId.HasValue && districtId.HasValue
                            ? entity.WeddingStudios
                                .Count(x => x.FK_StateProvinceID == stateProvinceId && x.FK_DistrictID == districtId)
                            : stateProvinceId.HasValue
                                ? entity.WeddingStudios
                                    .Count(x => x.FK_StateProvinceID == stateProvinceId)
                                : entity.WeddingStudios.Count
                };
        }

        public static ShortWeddingStudioDto ToWeddingStudioDto(this WeddingStudio entity)
        {
            return entity == null
                ? null
                : new ShortWeddingStudioDto
                {
                    Id = entity.Id,
                    Name = entity.WeddingStudioName,
                    Address = entity.WeddingStudioAddress,
                    Phone = entity.WeddingStudioPhone,
                    Website = entity.WeddingStudioWebsite,
                    AveragePrice = entity.WeddingStudioAveragePrice,
                    AverageReview = entity.WeddingStudioReviews.IsNullOrEmpty()
                        ? 0
                        : entity.WeddingStudioReviews.Sum(x => x.WeddingStudioReviewRating.GetValueOrDefault())
                          / entity.WeddingStudioReviews.Count,
                    ProductCount = entity.WeddingStudioProducts.IsNullOrEmpty()
                    ? 0
                    : entity.WeddingStudioProducts.Count,
                    CoverImage = entity.WeddingStudioCoverImage
                };
        }
    }
}