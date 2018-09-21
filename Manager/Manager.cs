using System;
using CalculatorValidator;
using CalculatorView;

namespace CalculatorManager
{
    public class Manager
    {
        private ValidationResult[] _providedInfo = new ValidationResult[3];

        private readonly View _view = new View();
        private readonly Validator _validator = new Validator();

        public void ProvideInputInfo()
        {
            Func<int, ValidationResult> numberRequest = GetValidatedNumber;
            Func<int, ValidationResult> operatorRequest = GetValidatedOperator;

            for (int i = 1; i <= 3; i++)
            {
                if (i == 3)
                    _providedInfo[i - 1] = CheckValidation(i, operatorRequest);
                else
                    _providedInfo[i - 1] = CheckValidation(i, numberRequest);
            }
        }

        public void ShowResult(double result)
        {
            _view.ShowResult(result);
        }

        public double MakeCalculation()
        {
            return _providedInfo[2].OperationAction(_providedInfo[0].Number, _providedInfo[1].Number);
        }


        private ValidationResult CheckValidation(int number, Func<int, ValidationResult> func)
        {
            ValidationResult temp = new ValidationResult();

            while (true)
            {
                temp = func(number);
                if (temp.Success)
                    break;
                else
                    _view.ShowWrongData();
            }
            return temp;
        }

        private ValidationResult GetValidatedNumber(int num)
        {
            return _validator.NumberValidation(_view.ShowNumberRequest(num)); ;
        }

        private ValidationResult GetValidatedOperator(int num)
        {
            return _validator.OperatorValidation(_view.ShowOperatorRequest()); ;
        }

    }
}
