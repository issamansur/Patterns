using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMethod_and_patterns
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool NeedsCondiments()
        {
            string answer = GetUserInput();

            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            string answer = "no";

            Console.WriteLine("Would u like lemon " +
                "with ur tea? (y/n)");

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
