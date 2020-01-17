using HY.Common.ReturnValues;
using HY.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HY.Data.Builders
{
    public class HYBaseBuilder
    {
        public HYReturn Build()
        {
            HYReturn ret = new SuccessReturn();

            ret = GetEntityRelationships();
            if(ret.Failure)
            {
                return ret;
            }

            ret = GetEntityCommands();
            if (ret.Failure)
            {
                return ret;
            }

            return ret;
        }

        private static HYReturn GetEntityRelationships()
        {
            HYReturn ret = new SuccessReturn();

            
            return ret;
        }

        private static HYReturn GetEntityCommands()
        {
            HYReturn ret = new SuccessReturn();
            return ret;
        }
    }
}
