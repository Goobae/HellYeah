using HY.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HY.Data.Database
{
    public static class HYOnModelCreating
    {
        public static void Create(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HYEntity>(entity =>
            {
                entity.HasIndex(a => a.EntityName).IsUnique();
            });

            modelBuilder.Entity<HYEntityProperty>(entity =>
            {
                entity.HasIndex(a => a.Id).IsUnique();
                entity.Property(b => b.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityProperties)
                    .HasForeignKey(a=> a.EntityId);

                entity.HasMany(a => a.Children)
                    .WithOne(b => b.Parent).OnDelete(DeleteBehavior.NoAction);

                entity.HasMany(a => a.Values)
                    .WithOne(b=> b.EntityProperty)
                    .HasForeignKey(a => a.EntityPropertyId);
            });

            modelBuilder.Entity<HYEntityPropertyValue>(entity =>
            {
                entity.Property(b => b.Id).ValueGeneratedOnAdd();
                entity.HasKey(b => b.Id);
                entity.HasOne(a => a.EntityProperty)
                    .WithMany(b => b.Values)
                    .HasForeignKey(a => a.EntityPropertyId);
            });

            modelBuilder.Entity<HYEntity>().HasData(new HYEntity("Task") { Id = 1 });

            modelBuilder.Entity<HYEntityProperty>().HasData(
                new HYEntityProperty()
                {
                    Id = 1,
                    EntityId = 1,
                    PropertyName = "Description"
                },
                new HYEntityProperty()
                {
                    Id = 2,
                    EntityId = 1,
                    PropertyName = "DateCreated",
                    PropretyTypeId = PropertyType.Date
                },
                new HYEntityProperty()
                {
                    Id = 3,
                    EntityId = 1,
                    PropertyName = "DateCreated",
                    PropretyTypeId = PropertyType.Date
                },
                new HYEntityProperty()
                {
                    Id = 4,
                    EntityId = 1,
                    PropertyName = "TaskList",
                    PropretyTypeId = PropertyType.List
                },
                new HYEntityProperty()
                {
                    Id = 5,
                    EntityId = 1,
                    PropertyName = "TaskListItem",
                    ParentId = 4,
                    PropretyTypeId = PropertyType.ListItem
                },
                new HYEntityProperty()
                {
                    Id = 6,
                    EntityId = 1,
                    ParentId = 5,
                    PropertyName = "Description",
                    PropretyTypeId = PropertyType.String
                },
                new HYEntityProperty()
                {
                    Id = 7,
                    EntityId = 1,
                    ParentId = 5,
                    PropertyName = "Completed",
                    PropretyTypeId = PropertyType.Bit
                },
                new HYEntityProperty()
                {
                    Id = 8,
                    EntityId = 1,
                    ParentId = 4,
                    PropertyName = "TaskListItem",
                    PropretyTypeId = PropertyType.ListItem
                },
                new HYEntityProperty()
                {
                    Id = 9,
                    EntityId = 1,
                    ParentId = 8,
                    PropertyName = "Description",
                    PropretyTypeId = PropertyType.String
                },
                new HYEntityProperty()
                {
                    Id = 10,
                    EntityId = 1,
                    ParentId = 8,
                    PropertyName = "Completed",
                    PropretyTypeId = PropertyType.Bit
                });

            modelBuilder.Entity<HYEntityPropertyValue>().HasData(
               new HYEntityPropertyValue()
               {
                   Id = 1,
                   EntityPropertyId = 1,
                   Value = "Test"
               },
               new HYEntityPropertyValue()
               {
                   Id = 2,
                   EntityPropertyId = 2,
                   Value = DateTime.Now.ToString()
               },
               new HYEntityPropertyValue()
               {
                   Id = 3,
                   EntityPropertyId = 3,
                   Value = DateTime.Now.ToString()
               },
               new HYEntityPropertyValue()
               {
                   Id = 4,
                   EntityPropertyId = 6,
                   Value = "Read Book"
               },
               new HYEntityPropertyValue()
               {
                   Id = 5,
                   EntityPropertyId = 7,
                   Value = "False"
               },
               new HYEntityPropertyValue()
               {
                   Id = 6,
                   EntityPropertyId = 9,
                   Value = "Run 5 miles"
               },
               new HYEntityPropertyValue()
               {
                   Id = 7,
                   EntityPropertyId = 10,
                   Value = "False"
               }
           );
        }
    }
}
