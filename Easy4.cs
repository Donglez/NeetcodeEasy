using System;

//Two Sum II.
//Given an array of integers that is already sorted in ascending order, find two numbers such that they add
//up to a specific target number.
//The function twoSum should return indices of the two numbers such that they add up to the target,
//where index 1 is less than index 2.

//Your returned answers (both indeces 1 and 2) are not zero based
//You may assume that each input would have exactly one solution and you may not use the same element twice.
public class Easy4
{
	public static string TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> diffs = new Dictionary<int, int>();
		string output = "";
		for (int i = 0; i < nums.Length; i++)
		{
			diffs.Add(target - nums[i], i + 1);
		}
		for (int i = 0; i < nums.Length; i++)
		{
			if (diffs.ContainsKey(nums[i]) && diffs[nums[i]] != (i+1))
			{
				output = "[" + diffs[nums[i]] + ", " + (i + 1) + "]";
			}
		}
		return output;
	}
}
