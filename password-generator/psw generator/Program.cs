using System;

namespace psw_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter password strength (weak, medium, strong): ");       //asks the user to enter password strength            
            string strength = Console.ReadLine().ToLower();                          //stores it in "strength", converting to lower cases

            if (strength != "weak" && strength != "medium" && strength != "strong")  //checks if the user put anything other than "weak" "medium" or "strong"
            {
                Console.WriteLine("Error: Invalid password strength." +              //if it is other word, prints out the message
                                   " Please enter 'weak', 'medium', or 'strong'.");

            }
            else
            {

                Console.Write("Enter password length: ");                               //asks user to put password length
                int length = int.Parse(Console.ReadLine());                              //reads and stores it in "length"

                string password = GeneratePassword(strength, length);                   //calls out the function and stores the answer in "password"
                Console.WriteLine("Generated Password: {0}", password);                  //prints out the password
            }
        }

        // function for generating password

        static string GeneratePassword(string strength, int length)
        {
            const string lower = "abcdefghijklmnopqrstuvwxyz";                 //defines a constant string containing all lowercase letters
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";                     //defines a constant string containing all uppercase letters
            const string numbers = "0123456789";                                   //defines a constant string containing all numbers
            const string special = "!@#$%^&*()_+-=[]{}|;:'\",.<>?/";               //defines a constant string containing most special symbols

            string chars = lower;                                                  //starts with lowercase letters as the base character set
            if (strength == "medium") chars += upper + numbers;                    //if strength is "medium", add uppercase letters and numbers to the character set
            if (strength == "strong") chars += upper + numbers + special;          //if strength is "strong", add uppercase, numbers, and special characters to the set

            Random rand = new Random();                                            //creates a new Random object for generating random numbers
            char[] passwordArray = new char[length];                               //create a character array to hold the generated password characters

            for (int i = 0; i < length; i++)                                       //fills the password array with random characters from the selected character set
            {
                passwordArray[i] = chars[rand.Next(chars.Length)];             //picks a random character from the set
            }

            return new string(passwordArray);                                  //converts the character array to a string and returns it as the final password
        }
    }
}


