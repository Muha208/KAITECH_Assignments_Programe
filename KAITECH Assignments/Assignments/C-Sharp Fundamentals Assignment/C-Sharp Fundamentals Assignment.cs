using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAITECH_Assignments
{
    public class C_Sharp_Fundamentals_Assignment
    {
        public static void GetTheMethodsAtAssignment()
        {
            Console.WriteLine("------C-Sharp Fundamentals Assignment------\n" +
                "The List Of Methods:\n" +
                "1- Write a C# program to take two numbers from the user and check whether they are equal or not.\n" +
                "2- Write a C# program to take two numbers from the user and print the sum.\n" +
                "3- Write a C# program to read a candidate’s age and determine whether he is eligible for casting his vote or not.\n" +
                "   The accepted age is 21 years.\n" +
                "4- Write a C# program that takes a number as input and checks whether it’s even or odd.\n" +
                "5- Write a C# program that takes two numbers as input and performs (+, -, x, /) operations on them,\n" +
                "   then display the result of these operations.\n" +
                "6- Write a C# program that takes ten numbers as input, then calculate and print their Sum & Average (using Loops).\n" +
                "   Note: Don’t use Sum() and Average() functions.\n" +
                "7- Write a C# program that takes a number as input and prints its multiplication table (using Loops).\n" +
                "   For Example:\n" +
                "   Input: 5\n" +
                "   Expected output:\n" +
                "   5 x 1 = 5\n" +
                "   5 x 2 = 10\n" +
                "   5 x 3 = 15\n" +
                "   ...\n" +
                "   5 x 12 = 60\n" +
                "8- Write a program in C# Sharp to accept a grade and declare the equivalent description.\n" +
                "9- Write a C# program to take two numbers from the user and swap them.\n" +
                "   nFor Example:\n" +
                "   nInput1: 5\n" +
                "   Input2: 10\n" +
                "   Expected output: Input1 = 10, Input2 = 5\n" +
                "10- Write a C# program to check whether a triangle can be formed by the given values of angles entered by the user.\n" +
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
        //Write a C# program to take two numbers from the user and check whether they are equal or not.
        private static void T1()
        {
            Console.WriteLine("Please Enter Tow Numbers To Check Whether They Are Equal Or Not....\n" +
                "First No Is = ");
            var firstNo = Methods_To_Help.IsIntNumber(Console.ReadLine());
            Console.WriteLine("\nSecond No Is = ");
            var secondNo = Methods_To_Help.IsIntNumber(Console.ReadLine());
            if (firstNo == secondNo)
            {
                Console.WriteLine("\nThe Two Numbers Is Equaled");
            }
            else
            {
                Console.WriteLine("\nThe Two Numbers Is Not Equaled");
            }
        }
        //Write a C# program to take two numbers from the user and print the sum.
        private static void T2()
        {
            Console.WriteLine("Please Enter Tow Numbers To Get The Sum Of Them....\n" +
                "First No Is = ");
            var firstNo = Methods_To_Help.IsIntNumber(Console.ReadLine());
            Console.WriteLine("\nSecond No Is = ");
            var secondNo = Methods_To_Help.IsIntNumber(Console.ReadLine());
            Console.WriteLine($"\nThe Sum Of Two Numbers Is = {firstNo + secondNo}");
        }
        //Write a C# program to read a candidate’s age and determine whether he is eligible for casting his vote or not.
        //The accepted age is 21 years.
        private static void T3()
        {
            Console.WriteLine("Please Enter Your Age....\n");
            var age = Methods_To_Help.IsIntNumber(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("\nYou Can Cast Your Vote\n" +
                    "Thank You");
            }
            else
            {
                Console.WriteLine("\nSorry You Can't Cast Your Vote.\n" +
                    "The accepted age is from 21 years.");

            }
        }
        //Write a C# program that takes a number as input and checks whether it’s even or odd.
        private static void T4()
        {
            Console.WriteLine("Please Enter Number To Check If It Odd Or Even....\n");
            var No = Methods_To_Help.IsIntNumber(Console.ReadLine());
            if (No % 2 == 0)
            {
                Console.WriteLine("\nThe Number Is Even ");
            }
            else
            {
                Console.WriteLine("\nThe Number Is Odd ");

            }
        }
        // Write a C# program that takes two numbers as input and performs (+, -, x, /) operations on them,
        //then display the result of these operations.
        private static void T5()
        {
            Console.WriteLine("Please Enter Tow Numbers To Calculate Them....\n" +
                "First No Is = ");
            var firstNo = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
        ReEnterTheSecondNo:
            Console.WriteLine("\nSecond No Is = ");
            var secondNo = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
        ReEnterTheOperation:
            Console.WriteLine("Please Enter The Operation....\n" +
                "(+, -, x, /) only Allowed\n" +
                "Your Operation Is = ");
            var Operation = Console.ReadLine();
            if (Operation.Trim() != "+" || Operation.Trim() != "-" || Operation.Trim() != "/" || Operation.Trim() != "*")
            {
                Console.WriteLine("\nSecond No Is = ");
                goto ReEnterTheOperation;
            }
            else
            {
                switch (Operation.Trim())
                {
                    case "+":
                        Console.WriteLine($"\nThe Resut = {firstNo + secondNo}");
                        break;
                    case "-":
                        Console.WriteLine($"\nThe Resut = {firstNo - secondNo}");
                        break;
                    case "*":
                        Console.WriteLine($"\nThe Resut = {firstNo * secondNo}");
                        break;
                    case "/":
                        if (secondNo != 0)
                        {
                            Console.WriteLine($"\nThe Resut = {firstNo / secondNo}");
                        }
                        else
                        {
                            Console.WriteLine($"\nCannot Divid By Zero\n" +
                                $"Please Re-Enter The Second No...\n");
                            goto ReEnterTheSecondNo;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        //Write a C# program that takes ten numbers as input, then calculate and print their Sum & Average (using Loops).
        //Note: Don’t use Sum() and Average() functions.
        private static void T6()
        {
            List<double> ListNo = new List<double>();
        ReEnterNumbers:
            Console.WriteLine("Please Enter Numbers That You Want To Get The Sum And The Average Of Them...\n" +
                "How Many Numbers That You Want To Add = ");
            var NumbersCount = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            if (NumbersCount <= 0)
            {
                for (int i = 0; i < NumbersCount; i++)
                {
                    Console.WriteLine($"\nNumber [{i + 1}] = ");
                    ListNo.Add(Methods_To_Help.IsDoubleNumber(Console.ReadLine()));
                }
                double Sum = 0;
                foreach (var No in ListNo)
                {
                    Sum += No;
                }
                Console.WriteLine($"\nThe Sum Of Numbers = {Sum}\n" +
                    $"The Average Of Numbers = {Sum / NumbersCount}");
            }
            else
            {
                goto ReEnterNumbers;
            }
        }
        /*Write a C# program that takes a number as input and prints its multiplication table (using Loops).
          For Example:
          Input: 5
          Expected output:
          5 x 1 = 5
          5 x 2 = 10
          5 x 3 = 15
          ...\
          5 x 12 = 60*/
        private static void T7()
        {
            Console.WriteLine("Please Enter Number To Get The Multiplication Table Of It....\n" +
                "The Number Is = ");
            var number = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            Console.WriteLine($"\nThe Multiplication Table Of {number} :\n");
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}\n");
            }
        }
        //Write a program in C# Sharp to accept a grade and declare the equivalent description.
        private static void T8()
        {
        ReEnterGrade:
            Console.WriteLine("Please Enter You Grade....\n" +
                "The Grades (E - V - G - A - F) Only\n" +
                "The Grade Is = ");
            var grade = Console.ReadLine().ToLower().Trim();
            if (grade == "e" || grade == "v" || grade == "g" || grade == "a" || grade == "f")
            {
                switch (grade)
                {
                    case "e":
                        Console.WriteLine("Your Grade Is Excellent");
                        break;
                    case "v":
                        Console.WriteLine("Your Grade Is VeryGood");
                        break;
                    case "g":
                        Console.WriteLine("Your Grade Is Good");
                        break;
                    case "a":
                        Console.WriteLine("Your Grade Is Average");
                        break;
                    case "f":
                        Console.WriteLine("Your Grade Is Fail");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                goto ReEnterGrade;
            }
        }
        /*Write a C# program to take two numbers from the user and swap them.
          nFor Example:
          nInput1: 5
          Input2: 10
          Expected output: Input1 = 10, Input2 = 5*/
        private static void T9()
        {
            Console.WriteLine("Please Enter Tow Numbers To Swap....\n" +
                "First No Is = ");
            var firstNo = Methods_To_Help.IsIntNumber(Console.ReadLine());
            Console.WriteLine("\nSecond No Is = ");
            var secondNo = Methods_To_Help.IsIntNumber(Console.ReadLine());
            Console.WriteLine($"First No Is = {secondNo}\n" +
                $"Second No Is = {firstNo}");
        }
        //Write a C# program to check whether a triangle can be formed by the given values of angles entered by the user.
        /*Based on Angles
          Acute-angled
          Obtuse-angled
          Right-angled*/
        private static void T10()
        {
            ReEnteredTheAngles:
            var listOfAngles = new List<double>();
            Console.WriteLine("Please Enter The Angles Of Triangl To Get The Type Of It Based On Angles\n" +
                "Acute-angled\n" +
                "Obtuse-angled\n" +
                "Right-angled\n" +
                "The Number Of Angles The You Want To Add Is  = ");
            var numberAngles = Methods_To_Help.IsIntNumber(Console.ReadLine());
            if (numberAngles > 0 && numberAngles <= 3)
            {
                for (int i = 0; i < numberAngles; i++)
                {
                    Console.WriteLine($"Angle [{i}] = ");
                    listOfAngles.Add(Methods_To_Help.IsDoubleNumber(Console.ReadLine()));
                }
                foreach (var angle in listOfAngles)
                {
                    if (angle <= 0)
                    {
                        Console.WriteLine($"Soory You Enterd An Applicable Angle Please Re-Enter The Angles\n");
                        goto ReEnteredTheAngles;
                    }
                    else
                    {
                        if (listOfAngles.Count == 1)
                        {
                            if (listOfAngles[0] == 90)
                            {
                                Console.WriteLine($"\nThe Triangl is [Right-angled]");
                            }
                            else if (listOfAngles[0] > 90)
                            {
                                Console.WriteLine($"\nThe Triangl is [Obtuse-angled]");
                            }
                            else
                            {
                                Console.WriteLine($"\nThe Triangl is [Acute-angled]");
                            }
                        }
                        else if (listOfAngles.Count == 2)
                        {
                            if (listOfAngles[1] == 90 || listOfAngles[0] == 90)
                            {
                                Console.WriteLine($"\nThe Triangl is [Right-angled]");
                            }
                            else if (listOfAngles[0] > 90 || listOfAngles[1] > 90)
                            {
                                Console.WriteLine($"\nThe Triangl is [Obtuse-angled]");
                            }
                            else
                            {
                                Console.WriteLine($"\nThe Triangl is [Acute-angled]");

                            }
                        }
                        else
                        {
                            if (listOfAngles[1] == 90 || listOfAngles[0] == 90 || listOfAngles[2] == 90)
                            {
                                Console.WriteLine($"\nThe Triangl is [Right-angled]");
                            }
                            else if (listOfAngles[0] > 90 || listOfAngles[1] > 90 || listOfAngles[2] > 90)
                            {
                                Console.WriteLine($"\nThe Triangl is [Obtuse-angled]");
                            }
                            else
                            {
                                Console.WriteLine($"\nThe Triangl is [Acute-angled]");

                            }
                        }
                    }
                }
            }
        }
    }
}
