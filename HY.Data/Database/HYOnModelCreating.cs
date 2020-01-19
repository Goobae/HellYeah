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

            modelBuilder.Entity<HYEntity>().HasData(new HYEntity("Task") { Id = 1 });

            modelBuilder.Entity<HYEntityProperty>(entity =>
            {
                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityProperties)
                    .HasForeignKey("EntityId");

                entity.HasMany(a => a.Children);
                entity.HasMany(a => a.Values);
            });

            modelBuilder.Entity<HYEntityPropertyValue>(entity =>
            {
                entity.HasOne(a => a.EntityProperty).WithMany(b => b.Values).HasForeignKey("EntityPropertyId");
            });

            modelBuilder.Entity<HYEntityProperty>().HasData(
                new HYEntityProperty()
                {
                    EntityId = 1,
                    PropertyName = "Description",
                    PropretyTypeId = PropertyType.String,
                    Values = new List<HYEntityPropertyValue>()
                    {
                        new HYEntityPropertyValue()
                        {
                            Value = "Test"
                        }
                    }
                },
                new HYEntityProperty()
                {
                    EntityId = 1,
                    PropertyName = "DateCreated",
                    PropretyTypeId = PropertyType.Date,
                    Values = new List<HYEntityPropertyValue>()
                    {
                        new HYEntityPropertyValue()
                        {
                            Value = DateTime.Now.ToString()
                        }
                    }
                },
                new HYEntityProperty()
                {
                    EntityId = 1,
                    PropertyName = "DateCreated",
                    PropretyTypeId = PropertyType.Date,
                    Values = new List<HYEntityPropertyValue>()
                    {
                        new HYEntityPropertyValue()
                        {
                            Value = DateTime.Now.ToString()
                        }
                    }
                },
                new HYEntityProperty()
                {
                    EntityId = 1,
                    PropertyName = "TaskList",
                    PropretyTypeId = PropertyType.List,
                    Children = new List<HYEntityProperty>()
                    {
                        new HYEntityProperty()
                        {
                            EntityId = 1,
                            PropertyName = "TaskListItem",
                            PropretyTypeId = PropertyType.ListItem,
                            Children = new List<HYEntityProperty>()
                            {
                                new HYEntityProperty()
                                {
                                    EntityId = 1,
                                    PropertyName = "Description",
                                    PropretyTypeId = PropertyType.String,
                                    Values = new List<HYEntityPropertyValue>()
                                    {
                                        new HYEntityPropertyValue()
                                        {
                                            Value = "Read Book"
                                        }
                                    }
                                },
                                new HYEntityProperty()
                                {
                                    EntityId = 1,
                                    PropertyName = "Completed",
                                    PropretyTypeId = PropertyType.Bit,
                                    Values = new List<HYEntityPropertyValue>()
                                    {
                                        new HYEntityPropertyValue()
                                        {
                                            Value = "False"
                                        }
                                    }
                                }
                            }
                        },
                        new HYEntityProperty()
                        {
                            EntityId = 1,
                            PropertyName = "TaskListItem",
                            PropretyTypeId = PropertyType.ListItem,
                            Children = new List<HYEntityProperty>()
                            {
                                new HYEntityProperty()
                                {
                                    EntityId = 1,
                                    PropertyName = "Description",
                                    PropretyTypeId = PropertyType.String,
                                    Values = new List<HYEntityPropertyValue>()
                                    {
                                        new HYEntityPropertyValue()
                                        {
                                            Value = "Run 5 miles"
                                        }
                                    }
                                },
                                new HYEntityProperty()
                                {
                                    EntityId = 1,
                                    PropertyName = "Completed",
                                    PropretyTypeId = PropertyType.Bit,
                                    Values = new List<HYEntityPropertyValue>()
                                    {
                                        new HYEntityPropertyValue()
                                        {
                                            Value = "False"
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
        }
    }
}
