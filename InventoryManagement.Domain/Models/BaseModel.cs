namespace InventoryManagement.Domain.Models
{
    public class BaseModel
    {
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Update { get; set; }
        public DateTime? UpdateBy { get; set; }
    }
}
