using System.Reflection;
using DuplicateNumber;
using Xunit;

public class FindDuplicateTests
{
    private readonly FindDuplicate _finder = new FindDuplicate();

    [Theory]
    [InlineData(new[] {1,3,4,2,2}, 2)]
    [InlineData(new[] {3,1,1,4,1}, 1)]
    [InlineData(new[] {1,1}, 1)]
    [InlineData(new[] {4,5,6,7,8}, -1)]
    public void TestFindDuplicate_VariousCases(int[] nums, int expectedDuplicate)
    {
        // Act
        int actualDuplicate = _finder.FindDuplicateNumber(nums);
        // Assert
        Assert.Equal(expectedDuplicate, actualDuplicate);
    }
}