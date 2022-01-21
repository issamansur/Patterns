using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMethod_and_patterns
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee " +
                "through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool NeedsCondiments()
        {
            string answer = GetUserInput();

            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            string answer = "no";

            Console.WriteLine("Would u like milk and " +
                "sugar with ur coffee? (y/n)");

            try
            {
                answer = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return answer;
        }
    }
}
