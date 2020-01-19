using System.Collections.Generic;

namespace HY.Data.Entities
{
    public enum PropertyType
    { 
        Bit,
        Number,
        Decimal,
        String,
        Date,
        Time,
        List,
        ListItem
    }

    public class HYEntityProperty : HYBase
    {
        public PropertyType PropretyTypeId { get; set; }
        public List<HYEntityPropertyValue> Values { get; set; }
        public List<HYEntityProperty> Children { get; set; }
        public int EntityId { get; set; }
        public string PropertyName { get; set; }
        public HYEntityProperty Parent { get; set; }
        public int ParentId { get; set; }
        public HYEntity Entity { get; set; }
    }
}
