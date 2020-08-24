using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PyramidChallenge.Test
{
    [TestClass]
    public class MaximumSumAggregatorTest
    {
        [TestMethod]
        public void GivenExerciseSample_OnFindMaxValue_ValidateReturnValueIsMax()
        {
            // Arrange
            var reader = new NodeReader();
            var rootNode = reader.ReadInput(@"./Data/ExerciseExample.txt");
            var aggregator = new MaximumSumAggregator();

            //Act
            var res = aggregator.FindMaxValue(rootNode);

            //Assert
            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void GivenMadeUpSample_OnFindMaxValue_ValidateReturnValueIsMax()
        {
            // Arrange
            var reader = new NodeReader();
            var rootNode = reader.ReadInput(@"./Data/MadeUpExample.txt");
            var aggregator = new MaximumSumAggregator();

            //Act
            var res = aggregator.FindMaxValue(rootNode);

            //Assert
            Assert.AreEqual(18, res);
        }

        [TestMethod]
        public void GivenPyramidChallenge_OnFindMaxValue_ValidateReturnValueIsMax()
        {
            // Arrange
            var reader = new NodeReader();
            var rootNode = reader.ReadInput(@"./Data/PyramidChallenge.txt");
            var aggregator = new MaximumSumAggregator();

            //Act
            var res = aggregator.FindMaxValue(rootNode);

            //Assert
            Assert.AreEqual(8186, res);
        }
    }
}
