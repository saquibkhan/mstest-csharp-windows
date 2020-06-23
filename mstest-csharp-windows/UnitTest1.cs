using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace mstest_csharp_windows
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        static public void TestClassInitializer(TestContext context)
        {
            if (context.Properties["paramName"] != null)
            {
                string testParamValue = context.Properties["paramName"].ToString();
                Logger.LogMessage(testParamValue);
                Assert.AreEqual("argwith\"aquote", testParamValue);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
