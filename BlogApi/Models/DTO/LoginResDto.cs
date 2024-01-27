
namespace BlogApi.Models.DTO
{
    public class LoginResDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
    }
}