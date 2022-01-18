using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Контекст данных для системы дистанционного обучения
        /// </summary>
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}