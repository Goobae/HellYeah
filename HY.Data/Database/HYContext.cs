using HY.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace HY.Data.Database
{
    public class HYContext : DbContext
    {
        public HYContext() : base()
        {

        }

        public DbSet<HYEntityModel> Entities { get; set; }
        public DbSet<HYPropertyModel> Properties { get; set; }
        public DbSet<HYEntityRelationshipModel> Relationships { get; set; }
    }
}
