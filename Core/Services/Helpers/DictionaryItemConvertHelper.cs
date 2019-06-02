using Dtos.Shared;

using Entities.ERP;

namespace Services.Helpers
{
    public static class DictionaryItemConvertHelper
    {
        public static DictionaryItemDto ToDictionaryItemDto(this StateProvince entity)
        {
            return entity == null
                ? null
                : new DictionaryItemDto
                {
                    Key = entity.Id.ToString(),
                    Value = entity.StateProvinceNo,
                    DisplayText = entity.StateProvinceName
                };
        }

        public static DictionaryItemDto ToDictionaryItemDto(this District entity)
        {
            return entity == null
                ? null
                : new DictionaryItemDto
                {
                    Key = entity.Id.ToString(),
                    Value = entity.DistrictNo,
                    DisplayText = entity.DistrictName
                };
        }

        public static DictionaryItemDto ToDictionaryItemDto(this Cummune entity)
        {
            return entity == null
                ? null
                : new DictionaryItemDto
                {
                    Key = entity.Id.ToString(),
                    Value = entity.CummuneNo,
                    DisplayText = entity.CummuneName
                };
        }
    }
}