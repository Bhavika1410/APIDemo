using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitWebApi.Models
{
    [Table("tbc_User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}