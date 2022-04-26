using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPracticoUT2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            int randomNumber = 0;

            Assert.AreEqual(0, randomNumber);
        }
    }
}