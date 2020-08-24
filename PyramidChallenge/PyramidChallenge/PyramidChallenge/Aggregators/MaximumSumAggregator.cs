using System;
using System.Text.RegularExpressions;

namespace PyramidChallenge
{
    /// <summary>
    /// This class implements an algorithm finding the maximum sum of a given pyramid/tree. 
    /// It is implement such that it reads from top to bottom, changes between even and odd numbers
    /// and assumes that is at least one valid path.
    /// </summary>
    public class MaximumSumAggregator
    {
        public long FindMaxValue(Node rootNode)
        {
            rootNode.MaxValue = rootNode.Value + FindMaxValue(rootNode, rootNode.Value % 2 == 0);
            return rootNode.MaxValue;
        }

        private long FindMaxValue(Node node, bool previousNodeWasEven)
        {
            if (node.Left == null)
            {
                return default;
            }
            else
            {
                var left = node.Left;
                var right = node.Right;

                if (left.MaxValue == default && IsOppositeOfPrev(left.Value, previousNodeWasEven))
                {
                    left.MaxValue = left.Value + FindMaxValue(left, !previousNodeWasEven);
                }

                if (right.MaxValue == default && IsOppositeOfPrev(right.Value, previousNodeWasEven))
                {
                    right.MaxValue = right.Value + FindMaxValue(right, !previousNodeWasEven);
                }

                return Math.Max(right.MaxValue, left.MaxValue);
            }
        }

        private bool IsOppositeOfPrev(int value, bool prev)
        {
            return (value % 2 == 0) != prev;
        }
    }
}
