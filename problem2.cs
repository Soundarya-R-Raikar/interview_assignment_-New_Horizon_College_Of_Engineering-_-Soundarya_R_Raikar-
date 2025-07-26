using System;

public class Pg2
{
    public static void ShiftingZeroes(int[] nums)
    {
        int count = 0;  
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i != count)
                {
                    int temp = nums[count];
                    nums[count] = nums[i];
                    nums[i] = temp;
                }
                count++;
            }
        }
    }
}
