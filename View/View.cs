using System;

namespace CalculatorView
{
    public class View
    {
        public string ShowNumberRequest(int number)
        {
            Console.WriteLine($"Please type number {number}:");
            return Console.ReadLine();
        }

        public string ShowOperatorRequest()
        {
            Console.WriteLine($"Please type operator:");
            return Console.ReadLine();
        }

        public void ShowWrongData()
        {
            Console.WriteLine("Wrong data was typed! Please try once more!");
        }

        public void ShowResult(double result)
        {
            Console.WriteLine($"Result = {result}");
            Console.ReadLine();
        }
    }
}
