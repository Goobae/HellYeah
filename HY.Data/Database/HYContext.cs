using HY.Data.Entities;
using HY.Data.Entities.EFHelpers;
using Microsoft.EntityFrameworkCore;

namespace HY.Data.Database
{
    public class HYContext : DbContext
    {
        public HYContext()
        {
            
        }

        public DbSet<HYEntity> Entities { get; set; }
        public DbSet<HYEntityProperty> EntityProperties { get; set; }
        public DbSet<HYEntityPropertyValue> EntityPropertyValues { get; set; }
        public DbSet<HYManyToMany<HYEntityProperty, HYEntityProperty>> EntityPropertiesToEntityProperties { get; set; }
        public DbSet<HYEntityRelationship> EntityRelationships { get; set; }
        public DbSet<HYEntityCommand> EntityCommands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            HYOnConfiguring.Configure(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            HYOnModelCreating.Create(modelBuilder);
        }
    }
}
