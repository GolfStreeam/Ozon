using System;
using System.Text;

namespace TestProject
{
    public static class StringUtil
    {
        private const char SPACE = '_';

        public static String RemoveExcessSpace(this String input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;
            var resultBuilder = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == SPACE && input[i + 1] == SPACE)
                    continue;
                resultBuilder.Append(input[i]);
            }
            if (resultBuilder[0] == SPACE)
                resultBuilder.Remove(0, 1);

            return resultBuilder.ToString();
        }
    }
}
