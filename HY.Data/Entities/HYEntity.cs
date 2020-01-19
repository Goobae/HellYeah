using System.Collections.Generic;

namespace HY.Data.Entities
{
    public class HYEntity : HYBase
    {
        public string EntityName { get; private set; }
        public ICollection<HYEntityRelationship> EntityRelationships { get; private set; }
        public ICollection<HYEntityCommand> EntityCommands { get; private set; }

        public HYEntity(string entityName)
        {
            EntityName = entityName;
            EntityRelationships = new List<HYEntityRelationship>();
            EntityCommands = new List<HYEntityCommand>();
        }
    }
}
