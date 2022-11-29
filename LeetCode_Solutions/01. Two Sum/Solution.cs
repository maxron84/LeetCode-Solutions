namespace LeetCode_Solutions._01._Two_Sum;

public static class Solution
{
    public static int[] GetMatchingElements_O_n2(int[] operands, int target)
    {
        int arrayLength = operands.Length;

        if (operands == null || arrayLength < 2)
            return Array.Empty<int>();

        for (int i = 0; i < arrayLength; i++)
            for (int j = i + 1; j < arrayLength; j++)
                if (operands[i] + operands[j] == target)
                    return new[] { i, j };

        return Array.Empty<int>();
    }

    public static int[] GetMatchingElements_O_n(int[] operands, int target)
    {
        int arrayLength = operands.Length;
        Dictionary<int, int> resultDictionary = new();

        if (operands == null || arrayLength < 2)
            return Array.Empty<int>();

        for (int i = 0; i < arrayLength; i++)
        {
            int firstNumber = operands[i];
            int secondNumber = target - firstNumber;

            if (resultDictionary.TryGetValue(secondNumber, out int index))
                return new[] { index, i };

            resultDictionary[firstNumber] = i;
        }

        return Array.Empty<int>();
    }
}
