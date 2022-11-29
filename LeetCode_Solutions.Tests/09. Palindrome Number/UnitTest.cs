namespace LeetCode_Solutions.Tests._09._Palindrome_Number;

public class UnitTest
{
    [Fact]
    public Task Palindrome_Number()
    {
        // Given
        int operand = 121;

        // When
        bool actual = LeetCode_Solutions
            ._09._Palindrome_Number
            .Solution
            .IsPalindromeNumber(operand);

        // Then
        Assert.True(actual);

        return Task.CompletedTask;
    }
}