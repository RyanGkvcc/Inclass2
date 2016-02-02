using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public Factorial()
        {
            //Prompt the user for a number to compute.
            Console.WriteLine("Input a numbet to calculate the factorial of: ");
            try
            {
                //Get the number to perform factorial on from the user.
                int factorialInt = Convert.ToInt32(Console.ReadLine());
                //Output what the problem to solve is.
                Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");
                //Solve the problem and put it in a answerInt
                int answerInt = Calculate(factorialInt);
                //Output the answer to the screen.
                Console.WriteLine(Environment.NewLine + "The answer is: " + answerInt + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine("You did not entera valid integer");
            }
            
        }

        private int Calculate(int number)
        {
            //If the number is 1, we have reached the Base Case. We want our execution
            //to change and start returning from the method calls.
            //If we did not have this base case, we would continue to put calls on
            //the call stack until a stack ocerflow were to happen.
            if (number == 1)
            {
                return 1;
                //return number; Also works!
            }
            //Since we are not at the base case of number equalling 1, we want to 
            //call this method that we are in another time and send in the number -1
            //is the parameter to the recursive call.
            return number * Calculate(number - 1);
        }
    }
}
