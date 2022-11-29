namespace LeetCode_Solutions.Tests._09._Palindrome_Number;

public class UnitTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Should_IsPalindromeNumber(int candidate)
    {
        // Given is MemberData

        // When
        bool validation = LeetCode_Solutions
            ._09._Palindrome_Number
            .Solution
            .IsPalindromeNumber(candidate);

        // Then
        Assert.True(validation);

        return Task.CompletedTask;
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { 121 };
        yield return new object[] { 1_000_000_001 };
    }
}
