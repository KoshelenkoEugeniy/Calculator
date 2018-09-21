using System;
using CalculatorService;

namespace CalculatorValidator
{
    public class Validator
    {
        public ValidationResult NumberValidation(string number)
        {
            ValidationResult result = new ValidationResult
            {
                Success = Double.TryParse(number, out double convertedNumber),
                Number = convertedNumber,
                OperationAction = null
            };

            return result;
        }

        public ValidationResult OperatorValidation(string action)
        {
            ValidationResult result = new ValidationResult();
            IService service = new Service();

            switch (action)
            {
                case "+":
                    //result.OperationAction = new ValidationResult.LocalDelegate(service.Add);
                    result.OperationAction = service.Add;
                    result.Success = true;
                    break;
                case "-":
                    result.OperationAction = service.Sub;
                    result.Success = true;
                    break;
                case "*":
                    result.OperationAction = service.Mul;
                    result.Success = true;
                    break;
                case "/":
                    result.OperationAction = service.Div;
                    result.Success = true;
                    break;
                default:
                    result.Success = false;
                    break;
            }
            result.Number = 0;

            return result;
        }
    }
}
