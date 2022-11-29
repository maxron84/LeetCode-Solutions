namespace LeetCode_Solutions._02._Add_two_Numbers;

public class ListNode<T> where T : struct, IComparable
{
    public T Value { get; private set; }

    public ListNode<T>? Next { get; set; }

    public ListNode(T value)
    {
        Value = value;
    }
}
