using HY.Common.ReturnValues;
using HY.Data.Adapters;
using System.Collections.Generic;

namespace HY.Data.Entities
{
    public class HYEntity : HYBaseEntity
    {
        public string EntityName { get; private set; }
        public List<HYEntityRelationship> EntityRelationships { get; private set; }
        public List<HYEntityCommand> EntityCommands { get; private set; }
        public HYDataAdapter<HYEntity> Adapter { get; set; }

        public HYEntity(string entityName) : base(entityName)
        {
            EntityName = entityName;
            EntityRelationships = new List<HYEntityRelationship>();
            EntityCommands = new List<HYEntityCommand>();

            Adapter = new HYDataAdapter<HYEntity>(this);
        }

        public HYReturn Initialize()
        {
            foreach(var prop in Properties)
            {
                
            }

            return new SuccessReturn();
        }
    
        public HYReturn GenerateLogMessage()
        {
            
            return new SuccessReturn();
        }
    }
}
