// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     //判断主附件编号
//     // record Good(int Price, int Value, int Id, List<Good> Goods);
//     public class Good
//     {
//         public int Price { get; set; }
//         public int Value { get; set; }
//         //满意度
//         public int Satisfaction { get; set; }

//         public int Id { get; set; }
//         public List<Good> Goods { get; set; }

//         public Good(int price, int value, int id, List<Good> goods)
//         {
//             Price = price;
//             Value = value;
//             Id = id;
//             Satisfaction = value * price;
//             Goods = goods;
//         }
//     }
//     public static void Main()
//     {
//         string str = System.Console.ReadLine();
//         int maxMoney = int.Parse(str.Split(' ')[0]);
//         int goodCount = int.Parse(str.Split(' ')[1]);
//         Good[] goods = new Good[goodCount + 1];
//         int mainGoodCount = 0;
//         //读取商品信息到数组goodCount
//         for (int i = 1; i <= goodCount; i++)
//         {
//             string[] goodInfo = System.Console.ReadLine().Split(' ');
//             int Price = int.Parse(goodInfo[0]);
//             int Value = int.Parse(goodInfo[1]);
//             int Id = int.Parse(goodInfo[2]);
//             if (Id == 0)
//                 mainGoodCount++;
//             goods[i] = new Good(Price, Value, Id, new List<Good>());
//         }
//         //将附件加入主件
//         for (int i = 1; i <= goodCount; i++)
//         {
//             var id = goods[i].Id;
//             if (id != 0)
//                 goods[id].Goods.Add(goods[i]);
//         }
//         //根据ID=0将主件取出到mainGoods
//         Good[] mainGoods = new Good[mainGoodCount + 1];
//         int index = 1;
//         for (int i = 1; i <= goodCount; i++)
//         {
//             var good = goods[i];
//             if (good.Id == 0)
//                 mainGoods[index++] = good;
//         }
//         int[,] dp = new int[mainGoodCount + 1, maxMoney + 1];

//         for (int i = 1; i <= mainGoodCount; i++)
//         {
//             for (int j = 0; j <= maxMoney; j++)
//             {
//                 //买不起
//                 if (j < mainGoods[i].Price)
//                     dp[i, j] = dp[i - 1, j];
//                 //买得起主件
//                 else
//                 {
//                     //没有附件
//                     if (mainGoods[i].Goods.Count == 0)
//                         dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - mainGoods[i].Price] + mainGoods[i].Satisfaction);
//                     //有附件1
//                     else if (mainGoods[i].Goods.Count == 1)
//                     {
//                         List<int> Values = new List<int>();
//                         Values.Add(dp[i - 1, j]);//不买主件
//                         Values.Add(dp[i - 1, j - mainGoods[i].Price] + mainGoods[i].Satisfaction);//买主件
//                         if (j >= mainGoods[i].Price + mainGoods[i].Goods[0].Price)//买主件和附件1
//                             Values.Add(dp[i - 1, j - mainGoods[i].Price - mainGoods[i].Goods[0].Price] + mainGoods[i].Satisfaction + mainGoods[i].Goods[0].Satisfaction);
//                         dp[i, j] = Values.Max();
//                     }
//                     //有附件1和2
//                     else if (mainGoods[i].Goods.Count == 2)
//                     {
//                         List<int> Values = new List<int>();
//                         Values.Add(dp[i - 1, j]);//不买主件
//                         Values.Add(dp[i - 1, j - mainGoods[i].Price] + mainGoods[i].Satisfaction);//买主件
//                         if (j >= mainGoods[i].Price + mainGoods[i].Goods[0].Price)//买主件和附件1
//                             Values.Add(dp[i - 1, j - mainGoods[i].Price - mainGoods[i].Goods[0].Price] + mainGoods[i].Satisfaction + mainGoods[i].Goods[0].Satisfaction);
//                         if (j >= mainGoods[i].Price + mainGoods[i].Goods[1].Price)//买主件和附件2
//                             Values.Add(dp[i - 1, j - mainGoods[i].Price - mainGoods[i].Goods[1].Price] + mainGoods[i].Satisfaction + mainGoods[i].Goods[1].Satisfaction);
//                         if (j >= mainGoods[i].Price + mainGoods[i].Goods[0].Price + mainGoods[i].Goods[1].Price)//买主件和附件1和2
//                             Values.Add(dp[i - 1, j - mainGoods[i].Price - mainGoods[i].Goods[0].Price - mainGoods[i].Goods[1].Price] + mainGoods[i].Satisfaction + mainGoods[i].Goods[0].Satisfaction + mainGoods[i].Goods[1].Satisfaction);
//                         dp[i, j] = Values.Max();
//                     }
//                 }
//             }
//         }
//         System.Console.WriteLine(dp[mainGoodCount, maxMoney]);
//     }
// }
