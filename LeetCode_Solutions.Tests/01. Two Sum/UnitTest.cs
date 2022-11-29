namespace LeetCode_Solutions.Tests._01._Two_Sum;

public class UnitTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Should_GetMatchingElements_O_n2(int target, int[] expectedIndices, int[] givenOperands)
    {
        // Given is MemberData

        // When
        int[] actual = LeetCode_Solutions
            ._01._Two_Sum
            .Solution
            .GetMatchingElements_O_n2(givenOperands, target);

        // Then
        Assert.Equal(expectedIndices, actual);

        return Task.CompletedTask;
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Should_GetMatchingElements_O_n(int target, int[] expectedIndices, int[] givenOperands)
    {
        // Given is MemberData

        // When
        int[] actual = LeetCode_Solutions
            ._01._Two_Sum
            .Solution
            .GetMatchingElements_O_n(givenOperands, target);

        // Then
        Assert.Equal(expectedIndices, actual);

        return Task.CompletedTask;
    }

    private static IEnumerable<object[]> GetTestData()
    {
        // target, expectedIndices[], givenOperands[]
        yield return new object[] { 9, new[] { 0, 1 }, new[] { 2, 7, 11, 15 } };
        yield return new object[] { 6, new[] { 1, 2 }, new[] { 3, 2, 4 } };
        yield return new object[] { 6, new[] { 0, 1 }, new[] { 3, 3 } };
    }
}
