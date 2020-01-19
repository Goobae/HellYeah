using HY.Common.ReturnValues;
using HY.Data.Entities;
using HY.Data.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY.Logic.Managers
{
    public abstract class HYManager
    {
        private ILogger log = new GenericFileLogger();
        public string Name {get; private set;}
        public List<string> RequiredEntities { get; protected set; }
        public List<HYEntity> Entities { get; private set; }

        public HYManager(string name, string requiredEntities)
        {
            Name = name;

            if(!string.IsNullOrEmpty(requiredEntities))
            {
                RequiredEntities = requiredEntities.Split(',').ToList();
            }
            else
            {
                log.LogWarning($"The manager {Name} does not have any Entities Required");
                RequiredEntities = new List<string>();
            }
        }

        public HYReturn BuildEntities()
        {
            HYReturn ret = new SuccessReturn();

            foreach(var reqEntity in RequiredEntities)
            {
                var tempEntity = new HYEntity(reqEntity);
                //ret = tempEntity.Build();

                if (ret.Failure)
                {
                    return ret;
                }

                Entities.Add(tempEntity);
            }

            return new SuccessReturn();
        }
    }
}
