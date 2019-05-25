using Common.Extensions;

namespace Services.Helpers
{
    public class CommonHelper
    {
        public static string ToFullName(string firstName, string lastName)
        {
            return new[]
            {
                firstName,
                lastName
            }.JoinNotEmpty(" ");
        }
    }
}