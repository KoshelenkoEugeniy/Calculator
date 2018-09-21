using System;
namespace CalculatorValidator
{
    public class ValidationResult
    {
        public double Number { get; set; }
        public bool Success { get; set; }
        public Func<double, double, double> OperationAction { get; set; }
        //public delegate double LocalDelegate(double x, double y);
        //public LocalDelegate OperationAction { get; set; }

        public ValidationResult()
        {
        }
    }
}
