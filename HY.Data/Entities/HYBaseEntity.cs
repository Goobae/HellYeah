using HY.Common.ReturnValues;
using System;
using System.Collections.Generic;
using System.Text;

namespace HY.Data.Entities
{
    public abstract class HYBaseEntity
    {
        string Name;
        protected List<HYBaseProperty> Properties;

        public HYBaseEntity(string name)
        {
            Name = name;
            Properties = new List<HYBaseProperty>();
        }

        protected HYReturn GetBaseProperties()
        {
            //we will need a configuration table to find out if these entities/bases have properties and which tables to read from

            //we wil need to know property types as well and create concrete functions for them

            return new SuccessReturn();
        }
        
        //crud functions here
    }
}
