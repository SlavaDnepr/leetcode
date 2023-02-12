var s = new Solution();

var l1 = s.ToList(new int[] { 1, 2 });
s.Print(l1);
var l2 = s.ToList(new int[] { 1, 3, 4 });
s.Print(l2);
var res = s.MergeTwoLists(l1, l2);
s.Print(res);
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode prev = null;
        ListNode first = null;

        while (list1 != null || list2 != null)
        {
            ListNode node = null;
            if (list2 == null || list1 != null && list1.val < list2.val)
            {
                node = new ListNode(list1.val);
                list1 = list1.next;
            }
            else if (list1 == null || list2 != null && list2.val <= list1.val)
            {
                node = new ListNode(list2.val);
                list2 = list2.next;
            }

            if (prev != null)
                prev.next = node;
            else
                first = node;

            prev = node;
        }

        return first;
    }

    public ListNode ToList(int[] ints)
    {
        ListNode prev = null;
        ListNode first = null;
        foreach (var i in ints)
        {
            var node = new ListNode(i);
            if (prev != null)
                prev.next = node;
            else
                first = node;

            prev = node;
        }

        return first;
    }

    public void Print(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " ");
            node = node.next;
        }

        Console.WriteLine();
    }
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