using System;
using System.Collections.Generic;
using System.Text;

namespace HY.Data.Entities
{
    public enum HYBasePropertyType
    {
        Command,
        Relationship,
        Value
    }

    public class HYBaseProperty
    {
        public HYBasePropertyType PropertyType { get; protected set; }

    }
}
