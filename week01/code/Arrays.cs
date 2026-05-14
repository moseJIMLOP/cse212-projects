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

        // First, understand what the problem is asking.
        // Start with the input number.
        // Use a loop that goes from 0 to length - 1.
        // Multiply the input number by (i + 1) to generate each multiple.
        // Store each result in the array at position i.
        // Return the completed array.


        //double [ ] result = new double [length];
        //for (int i = 0; i < length; i++)
        //{ 
        //   result [i] = number * (i + 1);
        //}
        //return result;



        return []; // replace this return statement with your own
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

        // First, understand what the problem is asking.
        // We need to rotate the list to the right by 'amount' positions.
        // Example: data = 1,2,3,4,5,6,7,8,9
        // If amount = 5 → 5,6,7,8,9,1,2,3,4
        // If amount = 3 → 7,8,9,1,2,3,4,5,6

        // Step 1: Divide the list into two parts:
        //         - listA = last 'amount' elements
        //         - listB = first (data.Count - amount) elements

        // Step 2: Get the last 'amount' elements from the list.

        // Step 3: Get the first part of the list (everything before the last 'amount').
        // Step 4: Clear the original list.
        // Step 5: Add the last elements first, then add the remaining elements.

        //List<int> listA = data.GetRange(data.Count - amount, amount);
        //List<int> listB = data.GetRange(0, data.Count - amount);
        //data.Clear();
        //data.AddRange(listA);
        //data.AddRange(listB);
    }
}
