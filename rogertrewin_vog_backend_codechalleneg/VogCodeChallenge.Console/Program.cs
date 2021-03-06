using System;

namespace VogCodeChallenge.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] mixValues = new dynamic[] { 0, 1, 2, 3, 4, "hey!", 1.0f, 2.0f, 3.0f, 4.0f, "test" };
            dynamic[] valuesWithException = new dynamic[] { 1, -2, 4 };

            System.Console.WriteLine("Step 7: ");
            QuestionClass.IterateListWithNoLoop();
            System.Console.WriteLine();

            System.Console.WriteLine("Step 8 - Test with no posittive numbers: ");
            QuestionClass.TESTModule(mixValues);
            System.Console.WriteLine();

            System.Console.WriteLine("Step 8 - Test with negative numbers, should throw exception: ");
            try
            {
                QuestionClass.TESTModule(valuesWithException);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}
