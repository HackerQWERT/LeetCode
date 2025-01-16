
// // public class ListNode
// // {
// //     public int val;
// //     public ListNode next;
// //     public ListNode(int val = 0, ListNode next = null)
// //     {
// //         this.val = val;
// //         this.next = next;
// //     }
// // }
// public class 删除排序链表中的重复元素II
// {
//     public ListNode DeleteDuplicates(ListNode head)
//     {
//         if (head == null)
//             return null;
//         var node = new ListNode(0, head);
//         var first = node;
//         var left = head;
//         var right = head.next;
//         while (true)
//         {
//             if (right == null)
//                 break;
//             if (left.val == right.val)
//             {
//                 //移动right到不相同
//                 while (true)
//                 {
//                     right = right.next;
//                     if (right == null)
//                     {
//                         first.next = null;
//                         return node.next;
//                     }
//                     else if (left.val != right.val)
//                     {
//                         first.next = right;
//                         left = right;
//                         right = right.next;
//                         break;
//                     }
//                 }
//             }
//             else
//             {
//                 first = left;
//                 left = right;
//                 right = right.next;
//             }
//         }
//         return node.next;
//     }
// }