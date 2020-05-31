using System;
using System.Collections.Generic;

namespace Summary_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really reallly really long text.";

            Console.WriteLine(StringUtility.SummerizeText(sentence, 25));

        }

    }
}
