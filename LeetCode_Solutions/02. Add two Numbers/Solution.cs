namespace LeetCode_Solutions._02._Add_two_Numbers;

public class Solution
{
    // Logic translated from the following approach in Java:
    // https://github.com/ani03sha/RedQuarkTutorials/blob/master/LeetCode/Java/src/main/java/org/redquark/tutorials/leetcode/AddTwoNumbers.java
    public static ListNode<int> GetSum(ListNode<int>? digitsOne, ListNode<int>? digitsTwo)
    {
        // Head of the new linked list - this is the head of the resultant list
        ListNode<int>? head = null;

        // Reference of head which is null at this point
        ListNode<int>? temp = null;

        // Carry
        int carry = 0;

        // Loop for the two lists
        while (digitsOne != null || digitsTwo != null)
        {
            // At the start of each iteration, we should add carry from the last iteration
            int sum = carry;

            // Since the lengths of the lists may be unequal, we are checking if the current node is null for one of the lists
            if (digitsOne != null)
            {
                sum += digitsOne.Value;
                digitsOne = digitsOne.Next;
            }

            if (digitsTwo != null)
            {
                sum += digitsTwo.Value;
                digitsTwo = digitsTwo.Next;
            }

            // At this point, we will add the total sum % 10 to the new node in the resultant list
            ListNode<int> node = new ListNode<int>(sum % 10);

            // Carry to be added in the next iteration
            carry = sum / 10;

            // If this is the first node or head
            if (temp == null)
            {
                temp = head = node;
            }
            // For any other node
            else
            {
                temp.Next = node;
                temp = temp.Next;
            }
        }

        // After the last iteration, we will check if there is carry left. If it's left then we will create a new node and add it
        if (carry > 0)
        {
            temp!.Next = new ListNode<int>(carry);
        }

        return head ?? throw new NullReferenceException();
    }
}
