using LeetCode_Solutions._02._Add_two_Numbers;

namespace LeetCode_Solutions.Tests._02.Add_Two_Numbers;

public class UnitTest
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public Task Should_Add_Two_Numbers(ListNode<int> operand_1, ListNode<int> operand_2, ListNode<int> expected)
    {
        // Given is MemberData

        // When
        List<int> expectedValues = new();
        List<int> actualValues = new();

        ListNode<int> actual = LeetCode_Solutions
            ._02._Add_two_Numbers
            .Solution
            .GetSum(operand_1, operand_2);

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
            // operand_1: 243
            new ListNode<int>(2) { Next = new(4) { Next = new(3) } },
            // operand_2: 564
            new ListNode<int>(5) { Next = new(6) { Next = new(4) } },
            // expected: 708
            new ListNode<int>(7) { Next = new(0) { Next = new(8) } }
        };

        // all: 0
        yield return new object[] { new ListNode<int>(0), new ListNode<int>(0), new ListNode<int>(0) };

        yield return new object[]
        {
            // operand_1: 999_999_9
            new ListNode<int>(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(9) } } } } } } } },
            // operand_2: 999_9
            new ListNode<int>(9) { Next = new(9) { Next = new(9) { Next = new(9) } } },
            // expected: 899_900_01
            new ListNode<int>(8) { Next = new(9) { Next = new(9) { Next = new(9) { Next = new(0) { Next = new(0) { Next = new(0) { Next = new(1) } } } } } } }
        };
    }
}
