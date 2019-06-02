using Dtos.Shared;

namespace Dtos.Ouput
{
    public class ShortWeddingStudioDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public string CoverImage { get; set; }

        public decimal? AveragePrice { get; set; }

        public decimal AverageReview { get; set; }

        public int ProductCount { get; set; }
    }
}