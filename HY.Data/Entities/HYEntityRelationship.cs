using System;
using System.Collections.Generic;
using System.Text;

namespace HY.Data.Entities
{
    public class HYEntityRelationship
    {
        public string RelationshipType { get; private set; }
        public HYEntity RelationshipEntity { get; private set; }

        public HYEntityRelationship(string relationshipType)
        {
            RelationshipType = relationshipType;
            //need to init relationship entity 

        }

        
    }
}
