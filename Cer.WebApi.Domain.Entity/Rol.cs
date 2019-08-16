using System.ComponentModel.DataAnnotations;

namespace Cer.WebApi.Domain.Entity
{
    public class Rol : BaseEntity
    {
        [Required]
        public string RolName { get; set; }
    }
}
