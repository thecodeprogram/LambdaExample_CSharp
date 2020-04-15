using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Example
{
    class OddEven_Numbers
    {
        List<int> numbers;

        public OddEven_Numbers(List<int> _numbers)
        {
            this.numbers = _numbers;
            list_numbers();
            expression_operation();
            statement_operation();
        }

        private void list_numbers()
        {
            //First see what the numbers are.
            Console.WriteLine("Lambda Numbers : ");
            for (int i = 0; i < this.numbers.Count; i++)
            {
                Console.WriteLine(this.numbers[i] + "");
            }
        }

        private void expression_operation()
        {
            Console.WriteLine(Environment.NewLine + "Lambda Expressions  ");
            //Here we see the expressions of the lambda
            //Here we are going to make a mathematical calculations for all items without any statements 
            //So we call it as lambda expressions
            //We will multiply all numbers int eh list by two 
            //In here we used foreach but if you want you can use the for loop or another loop to write all of the values.
            var multiply_by_2 = numbers.Select(x => x * 2);
            foreach (var item in multiply_by_2)
            {
                Console.WriteLine(item);
            }
        }

        private void statement_operation()
        {
            Console.WriteLine(Environment.NewLine + "Lambda Statements  ");
            //Here we see the lambda statements.
            //We are going to writeline the numbers are accomodate the statement which we specified in lambda
            //So we call it as lambda statements
            List<int> odd_number = numbers.FindAll(x => (x % 2) == 1);
            foreach (var item in odd_number)
            {
                Console.WriteLine(item);
            }
        }
    }
}
