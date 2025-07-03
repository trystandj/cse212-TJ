public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To solve this problem, we will:
        //  create an array of doubles with the specified length.
        //  iterate through the array indicies from 0 to length
        //  for each index, the number will be multiplied by the index + 1
        //  Return the value of the number after multiplying it by the index + 1

        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To solve this problem, we will:
        //  create a list to hold the rotated values
        //  calculate the length of the list
        //  then we will use a for loop to iterate throgh and calculate the new rotated index by adding the amount to the current index and
        //  using the modulo operator with the length of the list. Then we will move the data list into a new position in the rotated list.
        //  Then we will use a for loop to copy the values of the rotated list back to the original data list


        int length = data.Count;
        var rotatedList = new List<int>(new int[length]);

        for (int i = 0; i < length; i++)
        {
            int rotatedIndex = (i + amount) % length;
            rotatedList[rotatedIndex] = data[i];
           
        }
        
        for (int i = 0; i < length; i++)
        {
            data[i] = rotatedList[i];
        }
    }
}
