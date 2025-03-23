using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string firstWord;                                                      //Declaring variable for the first word                     
            string secondWord;                                                     //Declaring variable for the second word  


            Console.WriteLine("Write first word to check if it is an anagram ");   //Asks the user to enter the first word
            firstWord = Console.ReadLine().ToLower();                              //Stores it in firstWord, converting it to lowercase


            Console.WriteLine("Write second word to check if it is an anagram ");  //Asks the user to enter the second word
            secondWord = Console.ReadLine().ToLower();                             //Stores it in secondWord, converting it to lowercase

            if (!firstWord.All(char.IsLetter) || !secondWord.All(char.IsLetter))   //Checks if any of these words  does not contain letters
            {
                Console.WriteLine("The input must be letters! ERROR");             //If it's not, returns message
            }
            else                                                                   //Else, continues the program
            {

                if (AreAnagrams(firstWord, secondWord))                            //Calls the function to check if words are anagrams
                    Console.WriteLine("The words are anagrams.");                  //If it is, prints out this message
                else
                    Console.WriteLine("The words are not anagrams.");              //If not, prints out this message
            }
        }
       
        //Function for checking if the words are anagarams
        static bool AreAnagrams(string firstWord, string secondWord)                 
        {
            if (firstWord.Length != secondWord.Length)                             //Checks if the words are not the same length
                return false;                                                      //Returns false if its not the same length


            char[] charArray1 = firstWord.ToCharArray();                           //converts the first word to char type and stores in array
            char[] charArray2 = secondWord.ToCharArray();                          //converts the second word to char type and stores in array

            Array.Sort(charArray1);                                                //Sorts the letters of first word
            Array.Sort(charArray2);                                                //Sorts the letters of second word
            return new string(charArray1) == new string(charArray2);               //Returns true if the sorted character arrays are identical

        }
    }
}
    

