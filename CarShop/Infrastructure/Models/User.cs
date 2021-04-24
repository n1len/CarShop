using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CarShop.Infrastructure.Models
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        public string Login { get; set; }
    }
}
