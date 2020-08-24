using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PyramidChallenge.Test
{
    [TestClass]
    public class NodeReaderTest
    {
        [TestMethod]
        public void GivenExerciseExampleInput_OnReadInput_ValidateNodesInserted()
        {
            //Arrange
            var reader = new NodeReader();

            //Act
            var rootNode = reader.ReadInput(@"./Data/ExerciseExample.txt");

            //Assert
            AssertNodeValue(rootNode, 8, 9);
            AssertNodeValue(rootNode.Left, 1, 5);
            AssertNodeValue(rootNode.Left.Left, 4, 5);
            AssertNodeValue(rootNode.Left.Right, 5, 2);

            rootNode.Left.Left.Left.Left.Should().BeNull();
        }

        [TestMethod]
        public void GivenMadeUpExampleInput_OnReadInput_ValidateNodesInserted()
        {
            //Arrange
            var reader = new NodeReader();

            //Act
            var rootNode = reader.ReadInput(@"./Data/MadeUpExample.txt");

            //Assert
            AssertNodeValue(rootNode, 8, 2);
            AssertNodeValue(rootNode.Left, 1, 1);
            AssertNodeValue(rootNode.Right.Left, 1, 1);
            AssertNodeValue(rootNode.Right.Right, 1, 8);

            rootNode.Left.Left.Left.Left.Should().BeNull();
        }

        [TestMethod]
        public void GivenInvalidInput_OnReadInput_ValidateArgumentExceptionThrown()
        {
            //Arrange
            var reader = new NodeReader();

            //Act, Assert 
            Assert.ThrowsException<ArgumentException>(() => reader.ReadInput(@"./Data/InvalidExample.txt"));
        }

        [TestMethod]
        public void GivenEmptyInput_OnReadInput_ValidateArgumentExceptionThrown()
        {
            //Arrange
            var reader = new NodeReader();

            //Act, Assert 
            Assert.ThrowsException<ArgumentNullException>(() => reader.ReadInput(@"./Data/EmptyExample.txt"));
        }


        [TestMethod]
        public void GivenPyramidChallengeInput_OnReadInput_ValidateNodesInserted()
        {
            //Arrange
            var reader = new NodeReader();

            //Act
            var rootNode = reader.ReadInput(@"./Data/PyramidChallenge.txt");

            //Assert
            AssertNodeValue(rootNode, 192, 124);
            AssertNodeValue(rootNode.Left, 117, 269);
            AssertNodeValue(rootNode.Left.Left, 218, 836);
            AssertNodeValue(rootNode.Left.Right, 836, 347);
        }

        private void AssertNodeValue(Node node, int left, int right)
        {
            node.Left.Value.Should().Be(left);
            node.Right.Value.Should().Be(right);
        }
    }
}
