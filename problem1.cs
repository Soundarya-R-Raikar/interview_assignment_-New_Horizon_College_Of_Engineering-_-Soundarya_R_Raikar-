using System;
using System.Collections.Generic;

public class P1
{
    public static bool DuplicateNumberInArray(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!seen.Add(num)) 
                return true;
        }
        return false;
    }
}

