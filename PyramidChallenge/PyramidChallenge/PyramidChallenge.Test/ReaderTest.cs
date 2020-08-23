using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace PyramidChallenge.Test
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod]
        public void GivenInputTriangle_OnGetTriangle_ValidateInputIsFiltered()
        {

            var reader = new Reader();
            var tree = reader.ReadInput(@"./TestInput.txt");

            AssertNodeValue(tree, 8, 9);
            AssertNodeValue(tree.Left, 1, 5);
            AssertNodeValue(tree.Left.Left, 4, 5);
            AssertNodeValue(tree.Left.Right, 5, 2);

            tree.Left.Left.Left.Left.Should().BeNull();
        }

        public void AssertNodeValue(Node node, int left, int right)
        {
            node.Left.Value.Should().Be(left);
            node.Right.Value.Should().Be(right);
        }
    }
}
