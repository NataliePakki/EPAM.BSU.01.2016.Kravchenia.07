using NUnit.Framework;

namespace Task5.Tests { 
    [TestFixture]
    public class SortTests {
        private readonly int[] arrayInts = {4, 5, 6, 1, 7868, 34, 7, 34, 54};
        private readonly string[] arrayStrings = {"Lizards", "Dog", "Cat", "Mouse"};

        [Test]
        public void BubbleSortTest_Int() {
            int[] result = {1, 4, 5, 6, 7, 34, 34, 54, 7868} ;

            Sort.BubbleSort(arrayInts);

            Assert.AreEqual(result,arrayInts);
        }
        [Test]
        public void SelectionSortTest_Int() {
            int[] result = { 1, 4, 5, 6, 7, 34, 34, 54, 7868 };

            Sort.SelectionSort(arrayInts);

            Assert.AreEqual(result, arrayInts);
        }

        [Test]
        public void BubbleSortTest_String() { 
        string[] result = { "Cat", "Dog", "Lizards", "Mouse" };

            Sort.BubbleSort(arrayStrings);

            Assert.AreEqual(result, arrayStrings);
        }
        [Test]
        public void SelectionSortTest_String() {
            string[] result = { "Cat", "Dog", "Lizards", "Mouse" };

            Sort.SelectionSort(arrayStrings);

            Assert.AreEqual(result, arrayStrings);
        }
    }
}
