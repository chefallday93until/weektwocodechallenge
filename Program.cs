using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void FizzBuzz(int number)
        {
            

            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }


            




        }

        static void LetterCounter(string letter, string inString)
        {
            
            {


                var lowCase = 0; 
                var upCase = 0;
                
                for(var i = 0; i < inString.Length; i++)

                
                {
                    var currentLetter = inString[i].ToString();
                   
                    if (letter.ToUpper() == currentLetter)
                    {
                        upCase += 1;
                    }
                   
                    
                    else if (letter.ToLower() == currentLetter)
                    {
                        lowCase += 1;
                    }

                
                    
                }
               
                Console.WriteLine("Input: " + inString);
                Console.WriteLine("Number of lowercase: " + letter + "'s found: " + lowCase );
                Console.WriteLine("Number of UPPERCASE: " + letter + "'s found: " + upCase);
                Console.WriteLine("Total number of " + letter + "'s found: " + (lowCase + upCase) );
            }

        }

        static void TextStats(string input)
        {

            int numChar = input.Length -1;
            
            int numWord = 0;
            int numVowel = 0;
            int numConso = 0;
            int numSpecial = 0;
            int longest = 0;
            int shortest = 0;
            numConso = (input.Length - numVowel);
            
            for (var i = 0; i <= input.Length -1 ; i++)
            {
                var currentVowel = input[i];  

               

                if (currentVowel == 'a' || currentVowel == 'e' || currentVowel == 'i' || currentVowel == 'o' || currentVowel == 'u')
                {
                    numVowel += 1;
                }

                

                
               
            }

            Console.WriteLine("Number of characters: " + numChar);
            Console.WriteLine("Number of words: " + numWord);
            Console.WriteLine("Number of vowels: " + numVowel);
            Console.WriteLine("Number of consonants: " + numConso);
            Console.WriteLine("Number of special characters: " + numSpecial);
            Console.WriteLine("Longest word: " + longest);
            Console.WriteLine("Shortest word: " + shortest);



        }

        static void Main(string[] args)
        {
            for (var i = 1; i <= 20; i++)
            {
                FizzBuzz(i);
            }


            {

                LetterCounter("i", "I love biscuits and gravy. It's the best breakfast ever.");
            }

            {
                LetterCounter("n", "Never gonna give you up. Never gonna leet you down.");
            }
            {
                LetterCounter("s", "Sally sells seashells down by the seashore. She's from Sussex.");
            }


            {
                TextStats("It's a man's obligation, to stick his boneration, in a woman's seperation. This sort of penetration, will increase the population. Of the younger generation.");
            }





            Console.ReadKey();
        }
    }
}
