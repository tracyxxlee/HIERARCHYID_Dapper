using System.Data.Entity;

namespace EntityFramworkLibrary
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base()
        {
            this.Database.Connection.ConnectionString = "Data Source=C01007555\\SQLEXPRESS;Database=Demo;Trusted_Connection=True;MultipleActiveResultSets=true;";
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<DepSale> DepSales { get; set; }
        public DbSet<DepUser> DepUsers { get; set; }
    }
}
