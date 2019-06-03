using Dtos.Shared;

namespace Dtos.Ouput
{
    public class ShortWeddingStudioProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public string[] Images { get; set; }

        public decimal Price { get; set; }

        public DictionaryItemDto PriceUnit { get; set; }
    }
}