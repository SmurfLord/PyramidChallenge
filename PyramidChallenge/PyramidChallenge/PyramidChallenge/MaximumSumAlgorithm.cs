using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PyramidChallenge
{
    public class MaximumSumAlgorithm
    {
        public int GetMaximumSum(int[,] graph)
        {
            var rowLenght = graph.GetLength(0);
            var columnLenght = graph.GetLength(1);
            var possibleSolutions = Math.Pow(2, rowLenght-1);
            int tempSum = 0;

            for (int i = 0; i < rowLenght; i++)
            {
                int rowMax = 0;
                for (int j = 0; j < columnLenght - 1; j++)
                {
                    var number = graph[i, j];
                    if (number > rowMax)
                        rowMax = number;
                }
                tempSum += rowMax;
            }

            return tempSum;
        }
    }
}
