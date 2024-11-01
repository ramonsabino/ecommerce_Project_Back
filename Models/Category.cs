using System.ComponentModel.DataAnnotations;

namespace ecommerce_Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }

}
