using System.ComponentModel.DataAnnotations;
/// <summary>
/// Author: Ceron
/// Date: Ago-2019
/// </summary>
namespace Cer.WebApi.Domain.Entity
{
    public class User : BaseEntity
    {
        //   public int RolId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }


        // public virtual UserProfile UserProfile { get; set; }

        // public virtual Rol Role { get; set; }
    }
}
