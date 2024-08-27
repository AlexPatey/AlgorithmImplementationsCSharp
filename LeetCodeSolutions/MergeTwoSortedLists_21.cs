namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class MergeTwoSortedLists_21
{
    
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        //We need to create a result list node, and a reference list node that points to the head of the result list node
        var resultNode = new ListNode();
        var headNode = resultNode;

        //If one or the other list nodes is an empty list, return the other
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }
        
        //If list 1's value is less than list 2's value, add a new list node to result node and set its value to list 1's value, and then set list 1 to it's next node, else do the same for list 2, and repeat until either list1 or list2 has been assigned a null reference
        do
        {
            if (list1.val < list2.val)
            {
                resultNode.next = new ListNode
                {
                    val = list1.val
                };
                list1 = list1.next;
            }
            else
            {
                resultNode.next = new ListNode
                {
                    val = list2.val
                };
                list2 = list2.next;
            }
            resultNode = resultNode.next;
            
            
        } while (list1 != null && list2 != null);

        //As the lists may be of uneven length, check that you append the values of the non-exhausted list to the result node
        
        if (list1 == null)
        {
            while (list2 != null)
            {
                resultNode.next = new ListNode
                {
                    val = list2.val
                };
                list2 = list2.next;
                resultNode = resultNode.next;
            }
        }
        
        if (list2 == null)
        {
            while (list1 != null)
            {
                resultNode.next = new ListNode
                {
                    val = list1.val
                };
                list1 = list1.next;
                resultNode = resultNode.next;
            }
        }
        
        return headNode.next;
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