public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// // PART 1: MultiplesOf Function
    // ==========================================
   
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // STEP-BY-STEP PLAN:
        // 1. Create a new double array of size 'length' to hold the resulting multiples.
        // 2. Use a for loop that iterates 'length' times (from index 0 to length - 1).
        // 3. For each iteration, calculate the multiple by multiplying the 'Number' 
        //    by (currentIndex + 1) so it starts at 1x, 2x, 3x, etc.
        // 4. Assign the calculated value to the corresponding position in the array.
        // 5. Return the completed array.


        double[] result = new double[length];
        
        for (int i = 0; i < length ; i++)
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
        //Step 1: Check  if the list is null, has 1 or fewer elements, or amount is 0, exit early.
        // Step 2: Normalize the amount using module (amount % data.Count) to handle cases safely.
        // Step 3: Calculate the split index where the rotation point begins (data.Count - amount).
        // Step 4: Use GetRange to slice out the right-hand portion that needs to wrap around to the front.
        // Step 5: Use GetRange to slice out the remaining left-hand portion of the list.
        // Step 6: Clear the original list using data.Clear().
        // Step 7: Re-populate the original list by adding the right part first, followed by the left part using AddRange()
        if (data == null || data.Count <= 1 || amount <= 0)
        {
            return;
        }
        amount %= data.Count;
        if (amount == 0)
        {
            return;
        }
        int splitIndex = data.Count - amount;
        List<int> rightPart = data.GetRange(splitIndex, amount);
        List<int> leftPart = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
