using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PyramidChallenge.Test
{
    [TestClass]
    public class MaximumSumAlgorithmTest
    {
        [TestMethod]
        public void GivenGraph_OnGetMaxSum_ValidateSumisMax()
        {
            var reader = new Reader();
            var triangle = reader.ReadInput(@"C:\Users\Bibi\Desktop\Git\PyramidChallenge\PyramidChallenge\PyramidChallenge\PyramidChallenge.Test\TestInput.txt");

            var algo = new MaximumSumAlgorithm();
            var res = algo.GetMaximumSum(triangle);

            Assert.AreEqual(22, res);

        }
    }
}
