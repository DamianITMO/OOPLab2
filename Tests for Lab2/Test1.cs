using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests_for_Lab2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var gopuk = new Potion("Arman", "Green");
            var goluk = new Potion("Arman", "blue");

            itog = Program(gopuk, goluk, 4);
            Assert.Equal(itog.givename(), "Arman Arman");
        }
    }
}
