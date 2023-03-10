using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace KAITECH_Assignments
{
    public class Strings_Assignment
    {
        public static void GetTheMethodsAtAssignment()
        {
            Console.WriteLine("------String Assignment------\n" +
            "The List Of Methods:\n" +
            "General Note: for all strings tasks(except T1), you should take a string(s) as input from the user.\n" +
            "T1 - Write a C# program to replace the following words with the given ones in the following sentence.\n" +
            "     Sentence: “Hello Sameh, Welcome to Structural BIM Track.This is Round 1.”\n" +
            "     Replace “Sameh” with your name.\n" +
            "     Replace “Structural BIM Track” with “BIM Application Development Track”.\n" +
            "     Replace “Round 1” with your round number.\n" +
            "T2 - Write a C# program to read a sentence from the user and replace lowercase characters with uppercase ones.\n" +
            "     For Example:\n" +
            "     Input Sentence: “Hello World”\n" +
            "     Expected Output: “HELLO WORLD”\n" +
            "T3 - Write a C# program to extract a substring from a given string.\n" +
            "     Note: Don’t use Substring() function.\n" +
            "     Note: The index for a user starts from 1, while for a developer, starts from 0.\n" +
            "     For Example:\n" +
            "     Input string: “Hello World”\n" +
            "     Input Index to Start Extraction from: 3\n" +
            "     Input The Length of Substring: 6\n" +
            "     Expected Output: “llo Wo”.\n" +
            "T4 - Write a C# program to search the index of the first occurrence of a given character within a sentence.\n"+
            "     If the character doesn’t exist in the sentence, print a message.\n" +
            "     Note: The index for a user starts from 1, while for a developer, starts from 0.\n" +
            "     Note: Ignore the case sensitivity for character search.\n" +
            "     For Example:\n" +
            "     Input Sentence: “Hello World”\n" +
            "     Input Character: ‘o’\n" +
            "     Expected Output: 5\n" +
            "     Input Character: ‘O’\n" +
            "     Expected Output: 5\\n" +
            "     Input Character: ‘z’\n" +
            "     Expected Output: “The character ‘z’ doesn’t exist”\n" +
            "T5 - Write a C# program to count the total number of vowels in a string.\n" +
            "T6 - Write a C# program to print individual characters of a string in reverse order and separate them with spaces.\n" +
            "     Note: Put only one space between each character.\n" +
            "     Note: Don’t put spaces in the first or the last position of the string.\n" +
            "     For Example:\n" +
            "     Input: “Hello World”\n" +
            "     Expected Output: “d l r o W o l l e H”\n" +
            "T7 - Write a C# program to count the total number of words in a string.\n" +
            "     For Example:\n" +
            "     Input: “Welcome to BIM Application Development Track”\n" +
            "     Expected Output: 6\n" +
            "T8 - Write a C# program to check whether a given word is present in a given sentence.\n" +
            "     For Example:\n" +
            "     Input Sentence: “This is Task 8 in Strings Tasks”\n" +
            "     Input Word: “is”\n" +
            "     Expected Output: “The word ‘is’ exists in the sentence”.\n" +
            "     Input Word: “Assignment”\n" +
            "     Expected Output: “The word ‘Assignment’ doesn’t exist in the sentence”.\n" +
            "T9 - Write a C# program to check if the first character of each word in a sentence is uppercase or not. If not, print the word that doesn’t follow the condition.\n" +
            "     For Example:\n" +
            "     Input Sentence: “My Name Is Sameh”\n" +
            "     Expected Output: “All Words are Following The Condition”.\n" +
            "     Input Sentence: “My name is Sameh”\n" +
            "     Expected Output: “There are 2 Words Not Following The Condition:”\n" +
            "     “1 - name”\n" +
            "     “2 - is”\n" +
            "T10 - Write a C# program to find the maximum occurring character in a string.\n" +
            "      Note: If there’s more than one character that has the maximum occurring value, get the first one only.\n" +
            "      Note: Ignore the case sensitivity.\n" +
            "      For Example:\n" +
            "      Input: “Hello World”\n" +
            "      Expected Output: “The Highest frequency of character 'l' appears 3 times”.\n" +
            "\nPlease Assign The Number Of Method That You Want To Check.....\n");
            Console.WriteLine("The Number Of Method Is = ");
            var NoOfMethod = Console.ReadLine();
            do
            {
                switch (Methods_To_Help.IsIntNumber(NoOfMethod))
                {
                    case 1:
                        T1();
                        break;
                    case 2:
                        T2();
                        break;
                    case 3:
                        T3();
                        break;
                    case 4:
                        T4();
                        break;
                    case 5:
                        T5();
                        break;
                    case 6:
                        T6();
                        break;
                    case 7:
                        T7();
                        break;
                    case 8:
                        T8();
                        break;
                    case 9:
                        T9();
                        break;
                    case 10:
                        T10();
                        break;
                    default:
                        Console.WriteLine("\nSorry There Is Only T From [1] To [10]");
                        break;
                }
                Console.WriteLine("\nIf You Want To Quit Just Assign [Q] Or Enter Method Number : ...\n");
                NoOfMethod = Console.ReadLine();
            } while (NoOfMethod.ToString().ToLower() != "q");
        }

        /*T1- Write a C# program to replace the following words with the given ones in the following sentence.
             Sentence: “Hello Sameh, Welcome to Structural BIM Track. This is Round 1.”
             Replace “Sameh” with your name.
             Replace “Structural BIM Track” with “BIM Application Development Track”.
             Replace “Round 1” with your round number.*/
        private static void T1()
        {
            var StringWords = "Hello Sameh, Welcome to Structural BIM Track. This is Round 1.";
            StringWords.Replace("Sameh", "Muhamamd Osama");
            StringWords.Replace("Structural BIM Track.", "BIM Application Development Track.");
            StringWords.Replace("Round 1.", "Round 4.");
            Console.WriteLine(StringWords);
        }

        /*T2- Write a C# program to read a sentence from the user and replace lowercase characters with uppercase ones.
              For Example:
              Input Sentence: “Hello World”
              Expected Output: “HELLO WORLD”*/
        private static void T2()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine().ToUpper();
            Console.WriteLine("\nOutPut Sentence: " + StringWords);
        }

        /*Write a C# program to extract a substring from a given string.
          Note: Don’t use Substring() function.
          Note: The index for a user starts from 1, while for a developer, starts from 0.
          For Example:
          Input string: “Hello World”
          Input Index to Start Extraction from: 3
          Input The Length of Substring: 6
          Expected Output: “llo Wo”.*/
        private static void T3()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            StringWords.ToCharArray().ToList();
        ReInputIndex:
            Console.WriteLine("Input Index To Start:\n");
            var StartIndex = Methods_To_Help.IsIntNumber(Console.ReadLine());
        ReInputLength:
            Console.WriteLine("Input Length Of Cut:\n");
            var CutLength = Methods_To_Help.IsIntNumber(Console.ReadLine());

            var CutSentece = new StringBuilder();
            if (StartIndex <= StringWords.Length)
            {
                if ((CutLength + StartIndex) <= StringWords.Length)
                {
                    for (int i = StartIndex - 1; i < StartIndex + CutLength; i++)
                    {
                        CutSentece.Append(StringWords[i].ToString());
                    }
                    Console.WriteLine("\nOutPut Sentence: " + CutSentece);
                }
                else
                {
                    goto ReInputLength;
                }
            }
            else
            {
                goto ReInputIndex;
            }

        }
        /*T4- Write a C# program to search the index of the first occurrence of a given character within a sentence.
              If the character doesn’t exist in the sentence, print a message.
              Note: The index for a user starts from 1, while for a developer, starts from 0.
              Note: Ignore the case sensitivity for character search.
              For Example:
              Input Sentence: “Hello World”
              Input Character: ‘o’
              Expected Output: 5
              Input Character: ‘O’
              Expected Output: 5
              Input Character: ‘z’
              Expected Output: “The character ‘z’ doesn’t exist”*/
        private static void T4()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            StringWords.ToLower().ToCharArray().ToList();
        ReInputChar:
            Console.WriteLine("Input Your Char:\n");
            var CharToGet = Console.ReadLine();

            var CharIndex = 1;
            foreach (var CharIn in StringWords)
            {
                if (CharToGet.ToLower() == CharIn.ToString())
                {
                    Console.WriteLine($"Your Char Is \"{CharToGet}\" At Index = {CharIndex}\n");
                }
                else
                {
                    Console.WriteLine($"The character \"{CharToGet}\" doesn’t exist\n");
                    goto ReInputChar;
                }
                CharIndex++;
            }
        }
        /*T5- Write a C# program to count the total number of vowels in a string.*/
        private static void T5()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            StringWords.ToLower().ToCharArray().ToList();

            var CharIndex = 0;
            foreach (var CharIn in StringWords)
            {
                if (CharIn.ToString() == "a" || CharIn.ToString() == "e" || CharIn.ToString() == "i" || CharIn.ToString() == "o" ||
                    CharIn.ToString() == "u")
                {
                    CharIndex++;
                }
            }
            Console.WriteLine($"The Count Of Vowels Chars In Sentence = {CharIndex}\n");
        }
        /*T6- Write a C# program to print individual characters of a string in reverse order and separate them with spaces.
              Note: Put only one space between each character.
              Note: Don’t put spaces in the first or the last position of the string.
              For Example:
              Input: “Hello World”
              Expected Output: “d l r o W o l l e H”*/
        private static void T6()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            StringWords.Trim().Replace(" ", "").ToLower().ToCharArray().ToList();

            var CharsInSentence = new StringBuilder();
            for (int i = StringWords.Length - 1; i >= 0; i--)
            {
                CharsInSentence.Append(StringWords[i] + " ");
            }
            CharsInSentence.ToString().Trim();
            Console.WriteLine($"The Chars In Sentence : \"{CharsInSentence}\" \n");
        }
        /*T7- Write a C# program to count the total number of words in a string.
              For Example:
              Input: “Welcome to BIM Application Development Track”
              Expected Output: 6*/
        private static void T7()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            StringWords.Trim();

            var CountOfWords = 0;
            foreach (var word in StringWords)
            {
                if (word.ToString() == " ")
                {
                    CountOfWords++;
                }
            }
            if (CountOfWords == 0)
            {
                CountOfWords = 0;
            }
            else
            {
                CountOfWords++;
            }
            Console.WriteLine($"The Total Number Of Wards In Sentence : \"{CountOfWords}\" \n");
        }
        /*T8- Write a C# program to check whether a given word is present in a given sentence.
              For Example:
              Input Sentence: “This is Task 8 in Strings Tasks”
              Input Word: “is”
              Expected Output: “The word ‘is’ exists in the sentence”.
              Input Word: “Assignment”
              Expected Output: “The word ‘Assignment’ doesn’t exist in the sentence”.*/
        private static void T8()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            var StringArray = StringWords.Trim().ToLower().Split(' ');
            Console.WriteLine("Please Enter The Word:\n");
            var WordToSearch = Console.ReadLine();
            var NewWord = WordToSearch.Trim().ToLower();

            int Count = 0;
            foreach (string word in StringArray)
            {
                if (word == NewWord)
                {
                    Count++;
                }
            }
            if (Count != 0)
            {
                Console.WriteLine($"The word ‘{WordToSearch}’ exists in the sentence\n");
            }
            else
            {
                Console.WriteLine($"The word ‘{WordToSearch}’ doesn’t exist in the sentence\n");
            }
        }
        /*T9- Write a C# program to check if the first character of each word in a sentence is uppercase or not. If not, print the word that doesn’t follow the condition.
              For Example:
              Input Sentence: “My Name Is Sameh”
              Expected Output: “All Words are Following The Condition”.
              Input Sentence: “My name is Sameh”
              Expected Output: “There are 2 Words Not Following The Condition:”

              “1- name”
              “2- is”*/
        private static void T9()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            var WordsArray = StringWords.Trim().Split(' ');

            var CapitalWordsList = new List<string>();
            var SmallWordsList = new List<string>();
            foreach (var word in WordsArray)
            {
                var FirstChar = word.FirstOrDefault();
                if (FirstChar.ToString() == FirstChar.ToString().ToUpper())
                {
                    CapitalWordsList.Add(word);
                }
                else
                {
                    SmallWordsList.Add(word);
                }
            }
            if (CapitalWordsList.Count == WordsArray.Count())
            {
                Console.WriteLine($"All Words are Following The Condition\n");
            }
            else if (CapitalWordsList.Count == 0)
            {
                Console.WriteLine($"There Is No Word is Following The Condition\n");
            }
            else
            {
                var Scount = 1;
                Console.WriteLine($"There are {SmallWordsList.Count} Words Not Following The Condition:\n");
                foreach (var word in SmallWordsList)
                {
                    Console.WriteLine($"{Scount}- {word}\n");
                }
                var Ccount = 1;
                Console.WriteLine($"There are {CapitalWordsList.Count} Words Following The Condition:\n");
                foreach (var word in CapitalWordsList)
                {
                    Console.WriteLine($"{Ccount}- {word}\n");
                }
            }
        }
        /*T10- Write a C# program to find the maximum occurring character in a string.
               Note: If there’s more than one character that has the maximum occurring value, get the first one only.
               Note: Ignore the case sensitivity.
               For Example:
               Input: “Hello World”
               Expected Output: “The Highest frequency of character 'l' appears 3 times”.*/
        private static void T10()
        {
            Console.WriteLine("Please Enter Your Sentence:\n");
            var StringWords = Console.ReadLine();
            var CharsArray = StringWords.Trim().ToLower().Replace(" ", "").ToCharArray().ToList();
            var DCharsArray = CharsArray.Distinct();
            var ListOfChars = new List<StringBuilder>();
            foreach (var DChar in DCharsArray)
            {
                var CharToGet = new StringBuilder();
                foreach (var SChar in CharsArray)
                {
                    if (DChar == SChar)
                    {
                        CharToGet.Append(DChar);
                    }
                }
                ListOfChars.Add(CharToGet);
            }
            StringBuilder SBToGet = null;
            var index = 0;
            var MaxValue = 0;
            foreach (var SB in ListOfChars)
            {
                var count = SB.Length;
                if (count > MaxValue)
                {
                    SBToGet = new StringBuilder();
                    MaxValue = count;
                    SBToGet = SB;
                }
                index++;
            }
            Console.WriteLine($"The Highest frequency of character '{SBToGet.ToString()[0]}' appears {SBToGet.Length} times\n");
        }
    }
}


