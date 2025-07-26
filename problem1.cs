using System;

public class Pg1
{
    public static bool DuplicateNumbersInArray(int[] nums)
    {
        Array.Sort(nums);  
        for (int i = 1; i < nums.Length; i++) 
        {
            if (nums[i] == nums[i - 1])
                return true;
        }
        return false;
    }
}
