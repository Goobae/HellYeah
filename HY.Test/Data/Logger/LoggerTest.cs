using HY.Data.Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HY.Test.Data.Logger
{
    [TestClass]
    public class LoggerTest
    {
        ILogger logger;

        public LoggerTest()
        {
            logger = new GenericFileLogger();
        }

        [TestMethod]
        public void TestWarning()
        {
            var ret = logger.LogWarning("TestWarning, Isaac is a warning.");
            Assert.IsTrue(ret.Success);
        }

        [TestMethod]
        public void TestError()
        {
            var ret = logger.LogError("TestError, Marco is an error.");
            Assert.IsTrue(ret.Success);
        }

        [TestMethod]
        public void TestInfo()
        {
            var ret = logger.LogInformation("TestInfo, Kaisa is an info.");
            Assert.IsTrue(ret.Success);
        }

        [TestMethod]
        public void TestMessage()
        {
            var ret = logger.LogMessage("TestMessage, Mike is a message?");
            Assert.IsTrue(ret.Success);
        }
    }
}
