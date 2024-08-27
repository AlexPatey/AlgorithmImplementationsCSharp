namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class AddTwoNumbers_2
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var carry = 0;
        var dummyHead = new ListNode();
        var l3 = dummyHead;

        while (l1 != null || l2 != null)
        {
            var l1Val = l1?.val ?? 0;
            var l2Val = l2?.val ?? 0;

            var currentSum = l1Val + l2Val + carry;
            carry = currentSum / 10;
            var lastDigit = currentSum % 10;
            
            l3.next = new ListNode(lastDigit);

            l1 = l1?.next;
            l2 = l2?.next;
            l3 = l3.next;
        }

        if (carry > 0)
        {
            l3.next = new ListNode(carry);
        }
        
        return dummyHead.next;
    }
    
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}