public static class DisplaySums {
    public static void Run() {
        DisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 

        Console.WriteLine("------------");
        DisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10

        Console.WriteLine("------------");
        DisplaySumPairs([5, 11, 2, -4, 6, 8, -1]);
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
    }

    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to
    /// 10 using a set in O(n) time.  We are assuming that there are no duplicates
    /// in the list.
    /// </summary>
    /// <param name="numbers">array of integers</param>
    private static void DisplaySumPairs(int[] numbers) {
         Dictionary<int, bool> seenNumbers = new Dictionary<int, bool>();
         foreach (int currentNumber in numbers)
        {
            int complement = 10 - currentNumber;

            if (seenNumbers.ContainsKey(complement))
            {
                // Found a pair!
                if (currentNumber < complement)
                {
                    Console.WriteLine($"({currentNumber}, {complement})");
                }
                else
                {
                    Console.WriteLine($"({complement}, {currentNumber})");
                }
            }
            // Add the current number to the dictionary.
            // We use .TryAdd() to prevent exceptions if the number is already there
            // (though problem states no duplicates in input, it's good practice).
            seenNumbers.TryAdd(currentNumber, true);
        }


    }
}