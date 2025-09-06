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
        // 1. Create an array named "results" with the same length as "length".
        // 2. For i from 0 to length - 1, compute the multiple as (i + 1) * number.
        // 3. Store each multiple in results[i].
        // 4. Return results.

        double[] results = new double[length];
        for (int i = 0; i < length; i++)
        {
            results[i] = (i + 1) * number;
        }
        return results;
    }
    // TODO Problem 1 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.

    // replace this return statement with your own


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // 1.Check that data is not null and that amount is between 1 and data.Count (inclusive).
        // 2.Extract the last amount elements and store them in a variable.
        // 3.Remove the extracted elements from the original list.
        // 4.Insert the extracted elements at the beginning of the data list.

        if (data.Count >= amount)
        {
            List<int> rotate = data.GetRange(data.Count - amount, amount);
            data.RemoveRange(data.Count - amount, amount);
            data.InsertRange(0, rotate);
        }
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
