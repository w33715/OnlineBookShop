using System.Data.Entity;

namespace ORMLesson1
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DbConnection")
        {
        }
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
