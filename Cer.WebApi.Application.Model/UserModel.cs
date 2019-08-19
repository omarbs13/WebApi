namespace Cer.WebApi.Application.Model
{
    public class UserAddModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool Status { get; set; }

    }

    public class UserModel : UserAddModel
    {
        public RolModel Role { get; set; }
        public UserProfileModel UserProfile { get; set; }
    }

    public class UserModelToken
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Token { get; set; }
    }
}
