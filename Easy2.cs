using System;
using System.Collections;
using System.Linq;
//Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//You May assume that each input would have exactly one solution, and you may not use the same element twice.
public class Easy2
{
    public static string TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            map.Add(nums[i], i);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (map.Keys.Contains(diff) && map[diff] != map[nums[i]])
            {
                return "[" + map[nums[i]] + ", " + map[diff] + "]";
            }
        }
        return "";
    }
}
