
// using System.Collections.Generic;
// using System.Linq;

// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }
// public class 合并K个升序链表
// {
//     ListNode head = new ListNode();

//     ListNode current;
//     public ListNode MergeKLists(ListNode[] lists)
//     {
//         PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
//         current = head;
//         foreach (var list in lists)
//             if (list != null)
//                 pq.Enqueue(list, list.val);

//         while (pq.Count > 0)
//         {
//             var min = pq.Dequeue();
//             current.next = min;
//             current = current.next;
//             if (min.next != null)
//                 pq.Enqueue(min.next, min.next.val);
//         }
//         return head.next;
//     }
// }