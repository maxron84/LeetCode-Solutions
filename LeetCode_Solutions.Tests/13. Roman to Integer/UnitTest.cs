namespace LeetCode_Solutions.Tests._13._Roman_to_Integer;

public class UnitTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Roman_To_Integer(string roman, int expected)
    {
        // Given is MemberData

        // When
        int actual = LeetCode_Solutions
            ._13._Roman_to_Integer
            .Solution
            .GetIntegerFromRoman(roman);

        // Then
        Assert.Equal(expected, actual);

        return Task.CompletedTask;
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { "MCMLXXXIV", 1984 };
        yield return new object[] { "I", 1 };
        yield return new object[] { "MMMCMXCIX", 3999 };
    }
}
