using System.Collections.Generic;
using Xunit;

namespace DuplicateNumber.Tests
{
    public class FindDuplicateTests
    {
        [Fact]
        public void ShouldFindDuplicatesInArray()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 7, 4, 2, 2 };
            List<int> expectedDuplicates = new List<int> { 2, 4, 7 };

            // Act
            FindDuplicate finder = new FindDuplicate();
            List<int> actualDuplicates = finder.FindDuplicateNumbers(numbers);

             // Assert
    foreach (int expectedDuplicate in expectedDuplicates)
    {
        Assert.Contains(expectedDuplicate, actualDuplicates);
    }
        }

        [Fact]
        public void ShouldHandleEmptyArray()
        {
            // Arrange
            int[] numbers = Array.Empty<int>();
            List<int> expectedDuplicates = new List<int>();

            // Act
            FindDuplicate finder = new FindDuplicate();
            List<int> actualDuplicates = finder.FindDuplicateNumbers(numbers);

            // Assert
            Assert.Equal(expectedDuplicates, actualDuplicates);
        }

        [Fact]
        public void ShouldHandleArrayWithNoDuplicates()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            List<int> expectedDuplicates = new List<int>();

            // Act
            FindDuplicate finder = new FindDuplicate();
            List<int> actualDuplicates = finder.FindDuplicateNumbers(numbers);

            // Assert
            Assert.Equal(expectedDuplicates, actualDuplicates);
        }

        [Fact]
        public void ShouldHandleNullInput()
        {
            // Arrange
            int[] numbers = null;

           // Act & Assert
            FindDuplicate finder = new FindDuplicate();
            ArgumentException exception = Assert.Throws<ArgumentException>(() => finder.FindDuplicateNumbers(numbers));
            Assert.Equal("nums (Parameter 'Input array cannot be null.')", exception.Message);
        }
    }
}
