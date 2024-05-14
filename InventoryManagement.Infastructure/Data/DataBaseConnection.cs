using InventoryManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infastructure.Data
{
    public class DataBaseConnection : DbContext
    {

        public DataBaseConnection(DbContextOptions<DataBaseConnection> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } = null!;





    }
}
