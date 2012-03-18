using System.Collections.Generic;

namespace GuessNumber
{
    public class NumberGuess
    {
        public static string suggest(List<string> input, List<string> result)
        {
            
            var aCount = getACount(input, result);
            var sameCount = getBCount(input, result);
            return string.Format("{0}A{1}B", aCount, sameCount - aCount);
        }

        private static int getBCount(List<string> input, List<string> result)
        {
            int SameCount = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (result.Contains(input[i]))
                {
                    SameCount++;
                }
            }

            return SameCount;
        }

        private static int getACount(List<string> input, List<string>result )
        {
            int ACount = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Equals(result[i]))
                {
                    ACount++;
                }
            }
            return ACount;
        } 
    }
}