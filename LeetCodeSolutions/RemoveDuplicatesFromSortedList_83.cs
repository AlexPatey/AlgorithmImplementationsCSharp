namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class RemoveDuplicatesFromSortedList_83
{
    public static ListNode RemoveDuplicates(ListNode head)
    {
        // check if head is null or not
        if(head != null){
            // create new node
            ListNode current = head;
            // loop
            while(current.next != null){
                if(current.val == current.next.val){
                    ListNode temp = current.next;
                    current.next = temp.next;
                }
                else{
                    // iterate and ignore 
                    current = current.next;
                }
            }
        }
        return head;
    }
    
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

