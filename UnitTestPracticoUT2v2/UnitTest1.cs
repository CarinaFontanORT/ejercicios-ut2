using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPracticoUT2v2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int randomNumber = 0;

            Assert.AreEqual(0, randomNumber);
        }
    }
}
