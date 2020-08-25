using KMD.TerningApp.Kerne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KMD.TerningApp.UnitTest
{
    [TestClass]
    public class TerningTest
    {
        [TestMethod]
        public void TestVærdi()
        {
            Terning t = new Terning();
            Assert.IsTrue(t.Værdi >= 1 && t.Værdi <= 6);
        }

        

    }
}
