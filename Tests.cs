using NUnit.Framework;
using System.Linq;

namespace InsertionSort
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 9, 7, 5, 3, 1 }, new int[] { 1, 3, 5, 7, 9 })]
        [TestCase(new int[] { 4, 3, 2, 1, 2, 3 }, new int[] { 1, 2, 2, 3, 3, 4 })]
        [TestCase(new int[] { -4, 3, -2, 1, 2, 3 }, new int[] { -4, -2, 1, 2, 3, 3 })]
        [TestCase(new int[] { 2, 4, 6, 10, 100 }, new int[] { 2, 4, 6, 10, 100 })]
        [TestCase(new int[] { int.MaxValue, int.MinValue }, new int[] { int.MinValue, int.MaxValue })]
        [TestCase(new int[] { int.MaxValue, int.MinValue, 0 }, new int[] { int.MinValue, 0, int.MaxValue })]
        public void InsertionSortWorksCorrectly(int[] array, int[] sorted)
        {
            InsertionSort.Sort(array);

            Assert.AreEqual(array.Length, sorted.Length);

            for (var i = 0; i < array.Length; i++)
                Assert.AreEqual(array[i], sorted[i]);
        }

        [Test]
        [TestCase(new string[] { "9", "7", "5", "3" }, new string[] { "3", "5", "7", "9" })]
        [TestCase(new string[] { "3", "2", "2", "4" }, new string[] { "2", "2", "3", "4" })]
        [TestCase(new string[] { "a", "b", "d", "c" }, new string[] { "a", "b", "c", "d" })]
        [TestCase(new string[] { "a", "b", "D", "c" }, new string[] { "a", "b", "c", "D"})]
        [TestCase(new string[] { "AAA", "AAa", "AAB", "BAA" }, new string[] { "AAa", "AAA", "AAB", "BAA" })]
        [TestCase(new string[] { "AAA", "BBB", "aAA", "BAa" }, new string[] { "aAA", "AAA", "BAa", "BBB" })]
        public void StringInsertionSortWorksCorrectly(string[] array, string[] sorted)
        {
            InsertionSort.SortString(array);

            Assert.AreEqual(array.Length, sorted.Length);

            for (var i = 0; i < array.Length; i++)
                Assert.AreEqual(array[i], sorted[i]);
        }


        [Test]
        [TestCase()]
        public void BigInsertionSortWorksCorrectly()
        {
            var array = Enumerable.Range(0, 10000).Reverse().ToArray();
            var sorted = Enumerable.Range(0, 10000).ToArray();
            InsertionSort.Sort(array);

            Assert.AreEqual(array.Length, sorted.Length);

            for (var i = 0; i < array.Length; i++)
                Assert.AreEqual(array[i], sorted[i]);
        }
    }
}
