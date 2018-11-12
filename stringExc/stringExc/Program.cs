using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringExc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi! What would you like to say ?");
            //string senToday = Console.ReadLine();
            //Console.WriteLine("And the letter to track:");
            //char myLetter = Char.Parse(Console.ReadLine());
            //Console.WriteLine("The letter "+myLetter+" appears "+CountingLetters(senToday, myLetter)+" times.");
            //Console.WriteLine("ENTER DNA SEQUENCE:");
            //string dnaSequence = Console.ReadLine();
            //Console.WriteLine("ENTER PATTERN:");
            //string myPattern =Console.ReadLine();
            //Console.WriteLine("The pattern "+myPattern+(DnaSearchPattern(dnaSequence, myPattern)?" Exists!":" Does not Exists."));
            Console.WriteLine("Enter a word / sentance to reverse:");
            string revMe = Console.ReadLine();
            Console.WriteLine(ReverseThis(revMe));
            Console.WriteLine(isPallindrome(revMe));
        }
        static string ReverseThis(string revMe)
        {
            string reverseDone="";
            for(int i = 0; i <revMe.Length; i++)
            {
                reverseDone = revMe[i]+reverseDone;
            }
            return reverseDone;
        }


        static bool isPallindrome(string myWord)
        {
            return myWord == ReverseThis(myWord);
        }
        static bool DnaSearchPattern(string dnaSequence,string myPattern)
        {
            for(int i = 0; i <= (dnaSequence.Length-myPattern.Length); i++)
            {
                if (dnaSequence.Substring(i, myPattern.Length) == myPattern)
                {
                    return true;
                }
            }
             return false;
        }

        static int CountingLetters(string senToday,char myLetter)
            {
             int count = 0;
             for(int i = 0; i < senToday.Length; i++)
               {
               if (senToday[i] == myLetter)
                        count++;
               }
             return count;
            }
        
    }
}
