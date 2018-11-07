using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dazed.Media.DuplicateEncode.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
        }
    }
}
