using System.Text;

namespace LeetCode_2181_MergeNodesInBetweenZeros;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        //[0,3,1,0,4,5,2,0]

        ListNode head = new ListNode(0,
            new ListNode(3,
                new ListNode(1, new ListNode(0, new ListNode(4, new ListNode(5, new ListNode(2, new ListNode(0))))))));
        
        Console.WriteLine(solution.MergeNodes(head));
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        StringBuilder strBuilder = new StringBuilder($"[{val}");

        var newNode = next; 
        while (newNode != null)
        {
            strBuilder.Append($", {newNode.val}");
            newNode = newNode.next;
        }

        strBuilder.Append("]");

        return strBuilder.ToString();
    }
}

public class Solution {
    public ListNode MergeNodes(ListNode head) {

        ListNode resHead = new ListNode(0);
        ListNode resTail = resHead;
        head = head.next;

        while(head.next != null){
            
            if(head.val != 0)
            {
                resTail.val += head.val;
                head = head.next;
            }
            else 
            {
                resTail.next = new ListNode(0);
                resTail = resTail.next;
                head = head.next;
            }
        }

        return resHead;
    }
}