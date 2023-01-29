var s = new Solution();
var d1 = s.ToListNode(9);
var d2 = s.ToListNode(9999999991);


var res = s.AddTwoNumbers(d1, d2);
Console.WriteLine();

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

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var list = new List<ListNode>();
        var i = 0;
        ListNode resNode = null;
        var forNext = 0;
        while (true)
        {
            var s1 = (l1?.val ?? 0) + (l2?.val ?? 0) + forNext;
            if (s1 >= 10)
            {
                s1 -= 10;
                forNext = 1;
            }
            else
            {
                forNext = 0;
            }

            var node = new ListNode(s1);
            list.Add(node);

            if (i != 0)
                list[i - 1].next = node;
            else
                resNode = node;

            i++;

            if (l1 != null)
                l1 = l1.next;

            if(l2 != null)
                l2 = l2.next;

            if (l1 == null && l2 == null && forNext == 0)
                break;
        }

        return resNode;
    }

    public ListNode ToListNode(long sum)
    {
        var digits = sum.ToString().Select(t => int.Parse(t.ToString())).ToArray();
        ListNode node = null;
        for (var i = 0; i < digits.Length; i++)
        {
            node = new ListNode(digits[i], node);
        }

        return node;
    }
}
