using System;
using System.Collections.Generic;
using System.Text;

namespace Summary_Text
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalChars = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChars += word.Length + 1;
                if (totalChars > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "..."; // This is going to be a really...
        }
    }
}
