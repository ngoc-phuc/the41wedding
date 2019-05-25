namespace Dtos
{
    public class JwtTokenResultDto
    {
        public int UserId { get; set; }

        public string TokenType { get; set; }

        public string AccessToken { get; set; }

        public int ExpiresInSeconds { get; set; }

        public string DisplayName { get; set; }
    }
}