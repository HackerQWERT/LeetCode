using System;

public class 加油站
{
    // static void Main(string[] args)
    // {
    //     int[] gas = [2, 3, 4];
    //     int[] cost = [3, 4, 3];
    //     Console.WriteLine(CanCompleteCircuit(gas, cost));
    // }
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        for (int i = 0; i < gas.Length; i++)
        {
            int currentGas = 0;
            int addGas = 0;
            int costGas = 0;
            int j = i;
            while (true)
            {
                addGas = gas[j];
                costGas = cost[j];
                if (currentGas + addGas - costGas < 0)
                {
                    if (i > j)
                        return -1;
                    else
                    {
                        i = j;
                        break;
                    }

                }
                currentGas = currentGas + addGas - costGas;
                if (j + 1 >= gas.Length)
                    j = 0;
                else
                    j++;
                if (j == i)
                    return i;
            }
        }
        return -1;

    }
}