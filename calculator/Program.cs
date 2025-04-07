using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;                                             //declaring variable for the first number
            double secondNumber;                                            //declaring variable for the second number
            double result;                                                  //declaring the result variable

            Console.WriteLine("What is the first number?");                 //asks the user to put in the first number
            firstNumber = double.Parse(Console.ReadLine());                 //reads and puts users number in firstNumber

            Console.WriteLine("What is the second number?");                //asks the user to put in the second number
            secondNumber = double.Parse(Console.ReadLine());                //reads and puts users number in secondNumber

            if (firstNumber < 0 || secondNumber < 0)                        //checks if any of the two numbers is negative
            {
                Console.WriteLine("Can not put negative numbers!");          //if it is, prints out this message
            }
            else                                                             // if not, continues the program
            {

                Console.WriteLine("What action do you wanna take? (* / - +)");  //asks the user which action they wanna take
                string action = Console.ReadLine();                             //reads and puts user symbol in action

                if (action == "*")                                              //checks if the user's put symbol is multiplication
                {
                    result = firstNumber * secondNumber;                        // if it is, multiplies two numbers and puts the answer in result
                    Console.WriteLine("The result is  {0:f2}", result);         //prints out the result

                }
                else if (action == "+")                                         //if its not previous symbol,  checks if its addition
                {
                    result = firstNumber + secondNumber;                        // if it is, adds the two numbers and puts it in the answer
                    Console.WriteLine("The result is  {0:f2}", result);          //prints out the result of the addition

                }
                else if (action == "-")                                         //if its not previous symbol, checks if its substaction
                {

                    result = firstNumber - secondNumber;                        // substracts the numbers and puts in the answer
                    if (result < 0)                                             //checks if the result is negative number
                    {
                        Console.WriteLine(result);
                        Console.WriteLine("The answer is negative, ERROR");     //if it is, prints out this line
                    }
                    else Console.WriteLine("The result is  {0:f2}", result);    //if not, prints out the result

                }
                else if (action == "/")                                         //if its not previous symbol, checks if its division
                {

                    if (firstNumber == 0 || secondNumber == 0)                 //checks if any of the numbers is 0
                    {
                        Console.WriteLine("Division is not possible");         //if it is, prints out the message
                    }
                    else
                    {
                        result = firstNumber / secondNumber;                   //if not, it devides the numbers
                        Console.WriteLine("The result is  {0:f2}", result);    //prints out the result
                    }

                }
                else                                                            //if it's not any of these symbols, prints out this message
                {
                    Console.WriteLine("ERROR, wrong symbol ");
                }
            }











        }

    }
}
