using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Domain.Models
{
    public class Category : BaseModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }

    }
}
