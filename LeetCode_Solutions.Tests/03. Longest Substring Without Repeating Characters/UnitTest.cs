namespace LeetCode_Solutions.Tests._03._Longest_Substring_Without_Repeating_Characters;

public class UnitTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Should_GetLengthOfLongestSubstring(string superString)
    {
        // Given is MemberData

        // When        

        // Then

        return Task.CompletedTask;
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { "abcabcbb" };
        yield return new object[] { "bbbbb" };
        yield return new object[] { "pwwkew" };
    }
}
