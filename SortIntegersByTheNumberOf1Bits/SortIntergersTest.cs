using NUnit.Framework;
using Solution;

namespace Tests{
    public class SortIntergersTests {
        [Test]
        public void TestSortByBits(){
            SortIntergers solution = new SortIntergers();
            int[] input = {5,2,3,9,14};
            int[] expectedOutput = {2,3,5,9,14};
            int[] actualOutput = solution.SortByBits(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}