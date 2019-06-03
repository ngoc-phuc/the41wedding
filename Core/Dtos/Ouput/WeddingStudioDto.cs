namespace Dtos.Ouput
{
    public class WeddingStudioDto : ShortWeddingStudioDto
    {
        public string RepresentativeName { get; set; }

        public string RepresentativePhone { get; set; }

        public string RepresentativeEmail { get; set; }

        public string Intro { get; set; }

        public string[] RepresentativeIntroImages { get; set; }

        public string StudioAvatar { get; set; }

        public ShortWeddingStudioProductDto[] Products { get; set; }
    }
}