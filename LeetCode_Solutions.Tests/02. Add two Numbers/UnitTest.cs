using LeetCode_Solutions._02._Add_two_Numbers;

namespace LeetCode_Solutions.Tests._02.Add_Two_Numbers;

public class UnitTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Add_Two_Numbers(ListNode<int> l1, ListNode<int> l2, ListNode<int> expected)
    {
        // Given is MemberData

        // When
        List<int> expectedValues = new();
        List<int> actualValues = new();

        ListNode<int> actual = LeetCode_Solutions
            ._02._Add_two_Numbers
            .Solution
            .GetSum(l1, l2);

        while (expected.Next != null && actual.Next != null)
        {
            expectedValues.Add(expected.Value);
            expected = expected.Next;
            actualValues.Add(actual.Value);
            actual = actual.Next;
        }

        // Then
        Assert.Equal(expectedValues, actualValues);

        return Task.CompletedTask;
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]
        {
            // 243
            new ListNode<int>(2) { Next = new(4) { Next = new(3) } },
            // 564
            new ListNode<int>(5) { Next = new(6) { Next = new(4) } },
            // 708
            new ListNode<int>(7) { Next = new(0) { Next = new(8) } }
        };

        yield return new object[] { new ListNode<int>(0), new ListNode<int>(0), new ListNode<int>(0) };

        yield return new object[]
        {
            // 999_999_9
            new ListNode<int>(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) } } } } } } } },
            // 999_9
            new ListNode<int>(9) { Next = new(9) { Next = new(9) { Next = new(9) } } },
            // 899_900_01
            new ListNode<int>(8) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(0) { Next = new(0) { Next = new(0) { Next = new(1) } } } } } } }
        };
    }
}
