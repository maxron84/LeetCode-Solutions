namespace LeetCode_Solutions._13._Roman_to_Integer
{
    public class Solution
    {
        public static int GetIntegerFromRoman(string roman = "MCMLXXXIV")
        {
            // Accepted characters
            Dictionary<char, int> map = new()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            // Constraint to quantity
            if (roman.Length < 1 || roman.Length > 15)
                return 0;

            // Constraint to accepted characters
            foreach (var item in roman)
                for (var i = 0; i < map.Count; i++)
                    if (map[item].Equals(null))
                        return 0;

            // Operation Roman to Integer
            var result = 0;

            for (var i = 0; i < roman.Length; i++)
                result = !(i > 0 && map[roman[i]] > map[roman[i - 1]]) ? result + map[roman[i]] : result + map[roman[i]] - 2 * map[roman[i - 1]];

            // Constraint to accepted valuerange
            if (result < 1 || result > 3999)
                return 0;

            return result; // = 1984
        }
    }
}
