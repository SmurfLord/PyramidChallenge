using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PyramidChallenge.Test
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod]
        public void GivenSmallTestFile_OnReadInput_ValidateNodesInserted()
        {

            var reader = new Reader();
            var tree = reader.ReadInput(@"./TestInput.txt");

            AssertNodeValue(tree, 8, 9);
            AssertNodeValue(tree.Left, 1, 5);
            AssertNodeValue(tree.Left.Left, 4, 5);
            AssertNodeValue(tree.Left.Right, 5, 2);

            tree.Left.Left.Left.Left.Should().BeNull();
        }

        [TestMethod]
        public void GivenTestFile_OnReadInput_ValidateNodesInserted()
        {

            var reader = new Reader();
            var tree = reader.ReadInput(@"./TestPyramid.txt");

            AssertNodeValue(tree, 192, 124);
            AssertNodeValue(tree.Left, 117, 269);
            AssertNodeValue(tree.Left.Left, 218, 836);
            AssertNodeValue(tree.Left.Right, 836, 347);
        }

        public void AssertNodeValue(Node node, int left, int right)
        {
            node.Left.Value.Should().Be(left);
            node.Right.Value.Should().Be(right);
        }
    }
}
