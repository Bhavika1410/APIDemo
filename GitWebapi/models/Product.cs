using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitWebApi.Models
{
    [Table("tbc_Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
         public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}