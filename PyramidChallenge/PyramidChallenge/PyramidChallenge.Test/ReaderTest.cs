using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PyramidChallenge.Test
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod]
        public void GivenInputTriangle_OnGetTriangle_ValidateInputIsFiltered()
        {
            var reader = new Reader();
            var res = reader.ReadInput(@"C:\Users\Bibi\Desktop\Git\PyramidChallenge\PyramidChallenge\PyramidChallenge\PyramidChallenge.Test\TestInput.txt");
            Assert.AreEqual(4, res.GetLength(0));
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(8, res[1, 0]);
            Assert.AreEqual(1, res[2, 0]);
            Assert.AreEqual(5, res[2, 1]);
            Assert.AreEqual(9, res[2, 2]);
            Assert.AreEqual(4, res[3, 0]);
            Assert.AreEqual(2, res[3, 1]);

        }
    }
}
