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

        // Step1: create an array of the specified length to hold the multiples
        double[] multiples = new double[length];

        // Step2:loop from 0 to length - 1
        for (int i = 0; i < length; i++)
        {
            // Step3: calculate the multiple by multiplying the number by (i + 1) and store it in the array
            multiples[i] = number * (i + 1);    
        }

        // Step4: return the populated array
        return multiples;
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

        // Step1: Create a new list to hold the rotated values
        List<int> rotated = new List<int>(data.Count);
        
        // Step2: Loop through the original list starting from the index that is (data.Count - amount) to the end of the list
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            // Step3: Add the elements from the original list to the new list
            rotated.Add(data[i]);
        }

        // Step4: Loop through the original list from the beginning to the index that is (data.Count - amount)
        for (int i = 0; i < data.Count - amount; i++)
        {
            // Step5: Add the remaining elements from the original list to the new list
            rotated.Add(data[i]);
        }

        // Step6: Clear the original list and add the rotated values back to it
        data.Clear();
        data.AddRange(rotated);
    }
}
