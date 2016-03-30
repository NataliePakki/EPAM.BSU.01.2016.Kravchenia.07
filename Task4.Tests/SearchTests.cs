using System.Collections.Generic;
using NUnit.Framework;

namespace Task4.Tests {
    [TestFixture]
    public class SearchTests {
        private readonly int[] array = {-4, 1, 4, 7, 12, 56};
        private readonly string[] names = {"Ann", "Danill", "Melanie","Zoyee"};


        public static IEnumerable<TestCaseData> TestIntDatas {
            get {
                yield return new TestCaseData(-5).Returns(false);
                yield return new TestCaseData(100).Returns(false);
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(4).Returns(true);
                yield return new TestCaseData(56).Returns(true);
            }
        }

        public IEnumerable<TestCaseData> TestStringDatas {
            get {

                yield return new TestCaseData("Natalie").Returns(false);
                yield return new TestCaseData("Melanie").Returns(true);
                yield return new TestCaseData("Zoyee").Returns(true);
                yield return new TestCaseData("Zick").Returns(false);
            }
        }

        [Test, TestCaseSource(nameof(TestIntDatas))]
        public bool BinarySearchTest_Int(int x) {
            return Search.BinarySearch(array, x);
        }
        [Test, TestCaseSource(nameof(TestStringDatas))]
        public bool BinarySearchTest_String(string x) {
            return Search.BinarySearch(names, x);
        }

    }
}
