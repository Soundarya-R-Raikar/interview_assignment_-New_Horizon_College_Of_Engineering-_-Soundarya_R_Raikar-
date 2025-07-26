using System;

class PT1
{
    static void Main()
    {
        Console.WriteLine(Pg1.DuplicateNumbersInArray(new int[] { 3, 2, 3, 9 }));      
        Console.WriteLine(Pg1.DuplicateNumbersInArray(new int[] { 1, 2, 3, 4 }));      
        Console.WriteLine(Pg1.DuplicateNumbersInArray(new int[] { 1, 2, 3, -1 }));    
        Console.WriteLine(Pg1.DuplicateNumbersInArray(new int[] { 1, 2, -3, 4 }));    
        Console.WriteLine(Pg1.DuplicateNumbersInArray(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })); 
        Console.WriteLine(Pg1.DuplicateNumbersInArray(new int[] { 0, 0, 0, 1 }));      
    }
}

