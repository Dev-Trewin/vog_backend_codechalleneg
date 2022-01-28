using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VogCodeChallenge.Console
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void IterateListWithNoLoop()
        {
            var val = "";
            NamesList.Aggregate(val, (best, cur) => {
                System.Console.WriteLine(cur);
                return cur;
            });
            System.Console.ReadLine();
        }

        static dynamic GetResult(dynamic value) => value switch
        {
            // With one Switch Statement, cover the provided requirements.
            // A.For integer values of 1,2,3,4 multiply the provided value by 2 and return the result.
            // B.For any integer value bigger than 4, multiply the provided value by 3 and return the result.
            // C. for integer values below 1, throw proper exception.
            // D.For float values of 1.0f and 2.0f return 3.0f
            // E.For any string values convert them to UpperCase.
            // F. for anything else, return the input value itself.

            var v when v.GetType() == typeof(Int32) && ((Int32)v >= 1 && (Int32)v <= 4) => ((Int32)v * 2),
            var v when v.GetType() == typeof(Int32) && (Int32)v > 4 => (Int32)v * 3,
            var v when v.GetType() == typeof(Int32) && (Int32)v <= -1 => throw new ArgumentOutOfRangeException($"{v} is not a valid number"),
            var v when v.GetType() == typeof(Single) && ((float)v >= 1.0f && (float)v <= 2.0f) => 3.0f,
            var v when v.GetType() == typeof(String) => v.ToString().ToUpper(),
            _ => value
        };

        public static void TESTModule(dynamic[] values)
        {
            dynamic result;
            foreach (dynamic val in values)
            {
                result = GetResult(val);
                System.Console.WriteLine($"Type: {result.GetType().ToString()}, Original Value={val} Result={result}");
            }
        }
    }
}
