
namespace Cer.WebApi.Domain.Entity
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
