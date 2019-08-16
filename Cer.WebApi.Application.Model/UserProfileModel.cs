namespace Cer.WebApi.Application.Model
{
   public class UserProfileModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
