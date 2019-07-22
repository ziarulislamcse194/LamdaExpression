using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        delegate int CalculatorHandler(int f, int s);

        static void Main(string[] args)
        {
            //CalculatorHandler addMethod = Add;
            //CalculatorHandler addMethod = delegate(int firstNumber, int secondNumber)
            //                            {
            //                                return firstNumber + secondNumber;
            //                            };


            //CalculatorHandler addMethod = (int firstNumber, int secondNumber) => firstNumber + secondNumber;
            //CalculatorHandler addMethod = (firstNumber, secondNumber) => firstNumber + secondNumber;

            //CalculatorHandler addMethod = (x, y) => x + y; 



            Action<string> printOut = (name) =>
            {
                Console.WriteLine("Hello world" + name);
            };
            printOut("Someone");

            Console.ReadKey();

            //Func<int,int,int> addMethod = (x, y) =>
            //                                        {
            //                                            int r = x + y;
            //                                            return r;
            //                                        };


            //CalculatorHandler addMethod = (x, y) =>
            //                                        {
            //                                            int r = x + y;
            //                                            return r;
            //                                        };





            //int result = addMethod(2,4);
            //Console.WriteLine(result);



        }







        //public static int Add(int firstName, int secondName)
        //{
        //    return firstName + secondName;
        //}

        //public static int Subtrac(int firstName, int secondName)
        //{
        //    return firstName - secondName;
        //}

        //public static int Multiply(int firstName, int secondName)
        //{
        //    return firstName * secondName;
        //}
    }
}
