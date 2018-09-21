using System;
using CalculatorManager;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager _manager = new Manager();

            _manager.ProvideInputInfo();
            _manager.ShowResult(_manager.MakeCalculation());
        }


        /*
         * 
        // in main 
        Func<ReturnData> func = Input;

            ReturnData x = GetInput(func);
            ReturnData y = GetInput(func);

            func = InputOperation;
            ReturnData action = GetInput(func);

            action.OperationAction(x.Number, y.Number);
        //


        static ReturnData GetInput(Func<ReturnData> func)
        {
            ReturnData temp = new ReturnData();

            while (true)
            {
                temp = func();
                if (temp.Success)
                    break;
            }
            return temp;
        }

        static ReturnData Input()
        {
            Console.WriteLine("Please input number:");
            string str = Console.ReadLine();
            double num;
            bool res = Double.TryParse(str, out num);

            ReturnData data = new ReturnData();
            data.Number = num;
            data.OperationAction = null;
            data.Success = res;

            return data;
        }

        static ReturnData InputOperation()
        {
            Console.WriteLine("Please input Operation:");
            string str = Console.ReadLine();
            bool res;
            ReturnData data = new ReturnData();

            switch (str)
            {
                case "+":
                    data.OperationAction = Add;
                    res = true;
                    break;
                case "-":
                    data.OperationAction = Sub;
                    res = true;
                    break;
                case "*":
                    data.OperationAction = Mul;
                    res = true;
                    break;
                case "/":
                    data.OperationAction = Div;
                    res = true;
                    break;
                default:
                    res = false;
                    break;

            }
            data.Number = 0;
            data.Success = res;

            return data;
        }

        struct ReturnData
        {
            public bool Success { get; set; }
            public double Number { get; set; }
            public Func<double, double, double> OperationAction { get; set;}
        }


        static public double Add(double x, double y)
        {
            return x + y;
        }
        static public double Sub(double x, double y)
        {
            return x - y;
        }
        static public double Mul(double x, double y)
        {
            return x * y;
        }
        static public double Div(double x, double y)
        {
            return x / y;
        }
*/
    }
}
