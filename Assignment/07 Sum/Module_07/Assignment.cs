using System;
namespace Module_07
{
    class Assignment
    {
        public int sum = 0;
        public int Sum(int input)
        {
            Console.Write(input + " ");
            sum += input;
            if (input == 1) return sum;

            if(input % 2 == 0) Sum(input/2);
            else if(input % 2 == 1) Sum((3*input)+1);

            return sum;
        }
    }
}
