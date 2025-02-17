// using System.Collections.Generic;
// using System.Linq;

// public class LRUCache
// {
//     static void Main()
//     {
//         LRUCache lRUCache = new LRUCache(2);
//         lRUCache.Put(1, 0);
//         lRUCache.Put(2, 2);
//         lRUCache.Get(1);
//         lRUCache.Put(3, 3);
//         lRUCache.Get(2);
//         lRUCache.Put(4, 4);
//         lRUCache.Get(1);
//         lRUCache.Get(3);
//         lRUCache.Get(4);




//     }
//     private Dictionary<int, LinkedListNode<(int key, int value)>> cacheDict;
//     private int capacity;
//     private LinkedList<(int key, int value)> list = new();

//     public LRUCache(int capacity)
//     {
//         this.capacity = capacity;
//         cacheDict = new Dictionary<int, LinkedListNode<(int key, int value)>>();
//     }

//     public int Get(int key)
//     {
//         if (cacheDict.ContainsKey(key))
//         {
//             list.Remove(cacheDict[key]);
//             list.AddLast(cacheDict[key]);
//             return list.Last.Value.value;
//         }
//         return -1;
//     }

//     public void Put(int key, int value)
//     {
//         if (cacheDict.ContainsKey(key))
//         {
//             list.Remove(cacheDict[key]);
//             cacheDict[key] = new LinkedListNode<(int key, int value)>((key, value));
//             list.AddLast(cacheDict[key]);
//         }
//         else
//         {
//             if (cacheDict.Count == capacity)
//             {
//                 int removeKey = list.First.Value.key;
//                 cacheDict.Remove(removeKey);
//                 list.RemoveFirst();
//             }
//             cacheDict[key] = new LinkedListNode<(int key, int value)>((key, value));
//             list.AddLast(cacheDict[key]);
//         }
//     }
// }

// /**
//  * Your LRUCache object will be instantiated and called as such:
//  * LRUCache obj = new LRUCache(capacity);
//  * int param_1 = obj.Get(key);
//  * obj.Put(key,value);
//  */