using KMD.TerningApp.Kerne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KMD.TerningApp.UnitTest
{
    [TestClass]
    public class TerningTest
    {
        [TestMethod]
        public void TestV�rdi()
        {
            Terning t = new Terning();
            Assert.IsTrue(t.V�rdi >= 1 && t.V�rdi <= 6);
        }

        

    }
}
