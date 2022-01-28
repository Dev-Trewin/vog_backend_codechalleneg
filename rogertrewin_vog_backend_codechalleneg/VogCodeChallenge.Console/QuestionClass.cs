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
