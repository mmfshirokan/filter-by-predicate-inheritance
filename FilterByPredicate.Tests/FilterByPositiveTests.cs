using System;
using System.Linq;
using FilterByPalindromicPredicate;
using FilterByPositivePredicate;
using NUnit.Framework;

namespace FilterByPredicate.Tests
{
    [TestFixture]
    public class PositiveNumberFilterTests
    {
        [TestCase(new[] { -11, 2, -3, -4, 5, 6, 7, 8, 9 }, ExpectedResult = new[] { 2, 5, 6, 7, 8, 9 })]
        [TestCase(new[] { -717, -828, -45, -58, -881, 11711, -252 }, ExpectedResult = new[] { 11711 })]
        [TestCase(new[] { -17, -82, -45, -58, 881, 117, 25 }, ExpectedResult = new int[] { 881, 117, 25 })]
        [TestCase(new[] {-1236674, 123321, 1111111 },
            ExpectedResult = new[] { 123321, 1111111 })]
        [TestCase(new[] { -1111111112, -987654, -24, -1234654321, -32, -1005 }, ExpectedResult = new int[] { })]
        [TestCase(new[] { -27, -987656789, -7557, int.MaxValue, -7556, -7243, -7243427, int.MinValue },
            ExpectedResult = new[] { int.MaxValue })]
        public int[] Select_PalindromicVerifyTests(int[] source) => new PositiveNumberFilter().Select(source);

        [Test]
        public void Select_ArrayIsEmpty_ThrowArgumentException() => Assert.Throws<ArgumentException>(
            () => new PositiveNumberFilter().Select(Array.Empty<int>()), "Array cannot be empty.");

        [Test]
        public void Select_ArrayIsNull_ThrowArgumentNullException() => Assert.Throws<ArgumentNullException>(
            () => new PositiveNumberFilter().Select(null), "Array cannot be null.");
    }
}
