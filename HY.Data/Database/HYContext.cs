﻿using HY.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HY.Data.Database
{
    public class HYContext : DbContext
    {
        public HYContext() : base()
        {
            
        }

        public DbSet<HYEntity> Entities { get; set; }
        public DbSet<HYEntityProperty> EntityProperties { get; set; }
        public DbSet<HYEntityPropertyValue> EntityPropertyValues { get; set; }
        public DbSet<HYEntityRelationship> EntityRelationships { get; set; }
        public DbSet<HYEntityCommand> EntityCommands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=HellYeah;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            HYOnModelCreating.Create(modelBuilder);
        }
    }
}
