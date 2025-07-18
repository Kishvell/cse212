public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new array of size 'length'.
        // 2. Use a loop from 0 to length - 1.
        // 3. At each index i, store (i + 1) * number in the array.
        // 4. Return the filled array.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// This function modifies the original list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Normalize amount in case it’s >= data.Count (though not needed here since it's guaranteed valid).
        // 2. Extract the last 'amount' elements from the list.
        // 3. Remove these last 'amount' elements from the original list.
        // 4. Insert the extracted elements at the beginning of the list.

        int count = data.Count;
        List<int> tail = data.GetRange(count - amount, amount);
        data.RemoveRange(count - amount, amount);
        data.InsertRange(0, tail);
    }
}
