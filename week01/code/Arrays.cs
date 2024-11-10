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


        // First a new fixed array is generated
        var multiples = new double[length];

        // The multiples array is populated with the corresponding multiples
        for(int i = 0; i<length ; i++)
        {
          multiples[i] = number * (i + 1);
        }
        // the new multiples are returned
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
      // First I obtain a new array with the last items in the list (the ones moving to the left)
      List<int> lastData = data.GetRange(data.Count - amount,amount);
      // Second I obtain a new array with the items moving to the right
      List<int> arrangedData = data.GetRange(0, data.Count- amount);

      // I empty the array
      data.Clear();
      // I add the arrays in the desired order before returning it
      data.AddRange(lastData);
      data.AddRange(arrangedData);
      return data;
    }
}
