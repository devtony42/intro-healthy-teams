using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealthyTeam.Api.Tests
{
    [TestClass]
    public class SimpleTest
    {
        [TestMethod]
        public void TestMethod_Pass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod_Fail()
        {
            Assert.IsFalse(false);
        }
    }
}
