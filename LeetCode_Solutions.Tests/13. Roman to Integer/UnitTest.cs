namespace LeetCode_Solutions.Tests._13._Roman_to_Integer;

public class UnitTest
{
    [Fact]
    public Task Roman_To_Integer()
    {
        // Given
        string roman = "MCMLXXXIV";
        int expected = 1984;

        // When
        int actual = LeetCode_Solutions
            ._13._Roman_to_Integer
            .Solution
            .GetIntegerFromRoman(roman);

        // Then
        Assert.Equal(expected, actual);

        return Task.CompletedTask;
    }
}
