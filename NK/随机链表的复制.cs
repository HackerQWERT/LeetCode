// using System;
// using System.Collections.Generic;

// public class Node
// {
//     public int val;
//     public Node next;
//     public Node random;

//     public Node(int _val)
//     {
//         val = _val;
//         next = null;
//         random = null;
//     }
// }

// public class 随机链表的复制
// {
//     static void Main()
//     {
//         Node head = new Node(7);
//         head.next = new Node(13);
//         head.next.next = new Node(11);
//         head.next.next.next = new Node(10);
//         head.next.next.next.next = new Node(1);

//         head.next.random = head;
//         head.next.next.random = head.next.next.next.next;
//         head.next.next.next.random = head.next.next;
//         head.next.next.next.next.random = head;
//         head.next.random = head.next.next.next;
//         head.next.next.random = head.next.next;

//         Solution solution = new Solution();
//         Node result = solution.CopyRandomList(head);
//         while (result != null)
//         {
//             Console.WriteLine(result.val);
//             result = result.next;
//         }
//     }
//     Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
//     public Node CopyRandomList(Node head)
//     {
//         if (head == null)
//         {
//             return null;
//         }
//         Node current = head;
//         while (current != null)
//         {
//             dict.Add(current, new Node(current.val));
//             current = current.next;
//         }
//         foreach (var kv in dict)
//         {
//             var next = kv.Key.next;
//             var random = kv.Key.random;
//             if (next != null)
//             {
//                 kv.Value.next = dict[next];
//             }
//             if (random != null)
//             {
//                 kv.Value.random = dict[random];
//             }
//         }
//         return dict[head];
//     }
// }