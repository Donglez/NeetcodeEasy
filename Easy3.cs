using System;
using System.Collections;
using System.Numerics;

//Given an integer array (nums), find the contiguous subarray (containing at least one number)
//which has the has the largest sum and return its sum
public class Easy3
{
	public static int MaxSubArray(int[] nums)
	{
		
		int sum = nums[0];
        int maxSum = sum;

        for (int i = 1; i < nums.Length; i++)
		{
			if (nums[i] + sum >= nums[i])
			{
				sum += nums[i];
			}
			else
			{
				sum = nums[i];
			}
			maxSum = Math.Max(sum, maxSum);
		}
		return maxSum;
	}
}
