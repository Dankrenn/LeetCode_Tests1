using System;
//Дан массив целых чисел nums и целое число target, вернуть индексы двух чисел так, чтобы они в сумме target. 
public class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        int target = int.Parse(Console.ReadLine());
        int[] ints = (TwoSum(nums, target));
        Console.WriteLine(ints[0] + " " + ints[1]);
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.ContainsKey(target - nums[i]))
            {
                return new int[] { seen[target - nums[i]], i };
            }
            if (!seen.ContainsKey(nums[i]))
            {
                seen.Add(nums[i], i);
            }

        }
        return null;
    }
}

