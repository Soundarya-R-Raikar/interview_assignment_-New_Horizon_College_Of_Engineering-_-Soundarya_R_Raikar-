using System;
using System.Collections.Generic;

public class P1
{
    public static bool DuplicateNumbersInArray(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (seen.Contains(num))
                return true;
            seen.Add(num);
        }
        return false;
    }
}
