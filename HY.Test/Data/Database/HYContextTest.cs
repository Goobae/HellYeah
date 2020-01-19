using HY.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HY.Data.Entities;
using System;
using HY.Data.Logger;

namespace HY.Test.Data.Database
{
    [TestClass]
    public class HYContextTest
    {
        ILogger log;
        public HYContextTest()
        {
            log = new GenericFileLogger();
        }

        [TestMethod]
        public  void DBEntityTest()
        {
            HYContext db;
            HYEntity ent = new HYEntity("TEST1");
            HYEntity ent2 = null;
            try
            {
                using(db = new HYContext())
                {
                    var res = db.Entities.Add(ent);
                    db.SaveChanges();
                    
                    ent2 = db.Entities.FirstOrDefaultAsync(a => a.Id == ent.Id).Result;
                }
              
            }
            catch (Exception e)
            {
                ent = null;
                _ = log.LogError(e);
            }
          
            Assert.IsNotNull(ent2);            
        }
    }
}
