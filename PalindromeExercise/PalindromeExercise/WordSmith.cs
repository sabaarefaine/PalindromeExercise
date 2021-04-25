using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        //create a method(IsAPalindrome) that will take a parameter of type string
        //and return a value of type bool.
        //If the given input is a palindrome – return true, else return false. 

        public bool IsAPalindrome(string value)
        {
            string reverse = new string(value.Reverse().ToArray());

            return string.Compare(value, reverse) == 0 ? true : false;
        }

       

    }
}
