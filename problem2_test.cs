using System;

class PT2
{
    static void Main()
    {
        Test(new int[] { 0, 1, 0, 3, 12 });
        Test(new int[] { 1, 2, 3, 4 });
        Test(new int[] { 0, 0, 0, 0 });
    }

    static void Test(int[] nums)
    {
        Console.Write("[" + string.Join(", ", nums) + "] -> ");
        Pg2.ShiftingZeroes(nums);
        Console.WriteLine("[" + string.Join(", ", nums) + "]");
    }
}
