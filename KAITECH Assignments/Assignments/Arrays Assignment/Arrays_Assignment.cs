using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KAITECH_Assignments
{
    internal class Arrays_Assignment
    {
        public static void GetTheMethodsAtAssignment()
        {
            Console.WriteLine("------Array Assignment------\n" +
            "The List Of Methods:\n" +
            "General Note: for all tasks, you should take array(s) as input from the user.\n" +
            "T1 - Write a C# program to find the Sum & Average of all items of the array.\n" +
            "     Note: Results shall be rounded by two digits(e.g., 10 / 3 = 3.33).\n" +
            "     Note: Don’t use Sum() & Average() functions.\n" +
            "T2 - Write a C# program to copy (Deep Copy) the items from one array into another array.\n" +
            "     Note: Don’t use Array.Copy() function.\n" +
            "T3 - Write a C# program to read n number of values in an array and display it in reverse order.\n" +
            "     Note: Don’t use Array.Reverse() function.\n" +
            "T4 - Write a C# program to print all unique items in an array.\n" +
            "     For Example:\n" +
            "     Array: { 1, 1, 1, 5, -12, -12}\n" +
            "     Expected output: { 1, 5, -12}\n" +
            "T5 - Write a C# program to count the total number of duplicate items in an array.\n" +
            "     For Example:\n" +
            "     Array: { 1, 1, 1, 5, -12, -12, 7, 7}\n" +
            "     Expected output: 4\n" +
            "T6 - Write a C# program to separate odd and even integers for a given array.\n" +
            "     Note: Put them in a 2D array with two rows, one for odds, and one for evens, then print them.\n" +
            "T7 - Write a C# program to sort items of an array in descending order.\n" +
            "T8 - Write a C# program to find the second smallest element in an array.\n" +
            "T9 - Write a C# program to add two Matrices of the same size and print the resultant Matrix.\n" +
            "T10 - Write a C# program to multiply two Square Matrices and print the resultant Matrix.\n" +
            "      Note: Search for the mathematical approach to multiply two Matrices.\n" +
            "T11 - Write a C# program to find the sum of the Right Diagonal of a given matrix.\n" +
            "T12 - Write a C# program to check whether a given matrix is an Identity Matrix or not.\n" +
            "T13 - + 10 Bonus: for implementing Matrix input / output shape for Tasks(T9, T10, T11, T12).\n" +
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
                    case 11:
                        T11();
                        break;
                    case 12:
                        T12();
                        break;
                    case 13:
                        T13();
                        break;
                    default:
                        Console.WriteLine("\nSorry There Is Only T From [1] To [10]");
                        break;
                }
                Console.WriteLine("\nIf You Want To Quit Just Assign [Q] Or Enter Method Number : ...\n");
                NoOfMethod = Console.ReadLine();
            } while (NoOfMethod.ToString().ToLower() != "q");
        }
        /*T1 - Write a C# program to find the Sum & Average of all items of the array.
               Note: Results shall be rounded by two digits(e.g., 10 / 3 = 3.33)
               Note: Don’t use Sum() & Average() functions.*/
        private static void T1()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 0; i < InputArray.Length; i++)
            {
                sum += InputArray[i];
            }
            Console.WriteLine($"Output Of Array --- Sum = {sum} - Average = {String.Format("{0:0.00}", sum / InputArray.Length)}:\n");
        }
        /*T2 - Write a C# program to copy (Deep Copy) the items from one array into another array.\n" +
               Note: Don’t use Array.Copy() function.*/
        private static void T2()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            double[] CopyArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            for (int i = 0; i < InputArray.Length; i++)
            {
                CopyArray[i] = InputArray[i];
            }
            Console.WriteLine($"The Origenal Array:\n");
            for (int i = 0; i < InputArray.Length; i++)
            {
                Console.WriteLine($"{InputArray[i]}\n");
            }
            Console.WriteLine($"The Copy Array:\n");
            for (int i = 0; i < CopyArray.Length; i++)
            {
                Console.WriteLine($"{CopyArray[i]}\n");
            }
        }
        /*T3 - Write a C# program to read n number of values in an array and display it in reverse order.\n" +
               Note: Don’t use Array.Reverse() function.*/
        private static void T3()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            double[] ReverseArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            int count = 0;
            for (int i = InputArray.Length - 1; i >= 0; i--)
            {
                ReverseArray[count] = InputArray[i];
                count++;
            }
            Console.WriteLine($"The Origenal Array:\n");
            for (int i = 0; i < InputArray.Length; i++)
            {
                Console.WriteLine($"{InputArray[i]}\n");
            }
            Console.WriteLine($"The Reverse Array:\n");
            for (int i = 0; i < ReverseArray.Length; i++)
            {
                Console.WriteLine($"{ReverseArray[i]}\n");
            }
        }
        /*T4 - Write a C# program to print all unique items in an array.
               For Example:\n" +
               Array: { 1, 1, 1, 5, -12, -12}
               Expected output: { 1, 5, -12}*/
        private static void T4()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            Console.WriteLine($"The Uniqe Numbers In Array:\n");
            var UnipeArray = InputArray.Distinct().ToArray();
            for (int i = 0; i < UnipeArray.Length; i++)
            {
                Console.WriteLine($"{UnipeArray[i]}\n");
            }
        }
        /*T5 - Write a C# program to count the total number of duplicate items in an array.
               For Example:
               Array: { 1, 1, 1, 5, -12, -12, 7, 7}
               Expected output: 4*/
        private static void T5()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            Console.WriteLine($"The Uniqe Numbers In Array:\n");
            var UnipeArray = InputArray.Distinct().ToArray();
            Console.WriteLine($"The Total Number Of Duplicate Items In An Array = {UnipeArray.Length}\n");
        }
        /*T6 - Write a C# program to separate odd and even integers for a given array.
               Note: Put them in a 2D array with two rows, one for odds, and one for evens, then print them.*/
        private static void T6()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[,] OddAndEvenArray = new double[ArrayCapacity, ArrayCapacity];
            int countOfOdd = 0;
            int countOfEven = 0;
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                var InputNumber = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
                if (InputNumber % 2 == 0)
                {
                    OddAndEvenArray[0, countOfEven] = InputNumber;
                    countOfEven++;
                }
                else
                {
                    OddAndEvenArray[1, countOfOdd] = InputNumber;
                    countOfOdd++;
                }
            }
            Console.WriteLine($" Even Numbers | Odd Numbers\n");
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"       {OddAndEvenArray[0, i]}      | {OddAndEvenArray[1, i]}\n");
            }
        }
        /*T7 - Write a C# program to sort items of an array in descending order.*/
        private static void T7()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            var DesArray = InputArray.OrderByDescending(x => x).ToArray();
            Console.WriteLine($"The Descending Array:\n");
            for (int i = 0; i < DesArray.Length; i++)
            {
                Console.WriteLine($"{DesArray[i]}\n");
            }
        }
        /*T8 - Write a C# program to find the second smallest element in an array.*/
        private static void T8()
        {
            Console.WriteLine($"Please Input The Capacity Of Array:\n");
            int ArrayCapacity = Methods_To_Help.IsIntNumber(Console.ReadLine());
            double[] InputArray = new double[ArrayCapacity];
            for (int i = 0; i < ArrayCapacity; i++)
            {
                Console.WriteLine($"Number[{i + 1}] = \n");
                InputArray[i] = Methods_To_Help.IsDoubleNumber(Console.ReadLine());
            }
            var AesArray = InputArray.Distinct().OrderBy(x => x).ToArray();
            Console.WriteLine($"The Second Smallest In Array = [{AesArray[1]}]\n");
        }
        /*T9 - Write a C# program to add two Matrices of the same size and print the resultant Matrix.*/
        private static void T9()
        {
            Console.Write($"Please Input Two Matrices With Same Capacity To Get The Resultant Matrix:\n");
            Console.Write($"**** Note That:\n" +
                          $"               1 - You Can Separate Numbers By Space Or Any Symble (-,'.....).\n");
            Console.Write($"               2 - The Capacity Will According By Each Column And Each Row.\n");
            Console.Write($"               3 - After Finnish The Matrix Press Double Enter.\n");
            Console.Write($"For Ex:\n 1 1\n 2 2\n[Press Enter]\n[Press Enter]\n");
            Console.WriteLine($"Please Input The First Matrix:\n");
            var TotalString = new StringBuilder();
            string Input = null;
            do
            {
                Input = Console.ReadLine().Trim();
                var StringRow = Input + "M";
                TotalString.Append(StringRow.ToString());
            } while (Input != String.Empty);

            Console.WriteLine($"Please Input The Second Matrix:\n");
            var TotalStringSec = new StringBuilder();
            string SecInput = null;
            do
            {
                SecInput = Console.ReadLine().Trim();
                var StringRow = SecInput + "M";
                TotalStringSec.Append(StringRow.ToString());
            } while (SecInput != String.Empty);

            var ColumnsCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalString).ColumnCapacity;
            var RowCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalString).RowCapacity;
            var InputArray = Methods_To_Help.GetUnkownArrayFormUser(TotalString).UserArray;

            var SecColumnsCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalStringSec).ColumnCapacity;
            var SecRowCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalStringSec).RowCapacity;
            var SecInputArray = Methods_To_Help.GetUnkownArrayFormUser(TotalStringSec).UserArray;

            var MinCapacityColumns = Math.Min(ColumnsCapacity, SecColumnsCapacity);
            var MinCapacityRow = Math.Min(RowCapacity, SecRowCapacity);
            Console.WriteLine("The Resultant Input Array:\n");
            for (int i = 0; i < MinCapacityColumns; i++)
            {
                for (int j = 0; j < MinCapacityRow; j++)
                {
                    Console.Write($"{InputArray[i, j] + SecInputArray[i, j]} ");
                }
                Console.Write($"\n");
            }
        }
        /*T10 - Write a C# program to multiply two Square Matrices and print the resultant Matrix.
                Note: Search for the mathematical approach to multiply two Matrices.*/
        private static void T10()
        {
            Console.Write($"Please Input Two Matrices With Same Capacity To Get The Multiple Matrix:\n");
            Console.Write($"**** Note That:\n" +
                          $"               1 - You Can Separate Numbers By Space Or Any Symble (-,'.....).\n");
            Console.Write($"               2 - The Capacity Will According By Each Column And Each Row.\n");
            Console.Write($"               3 - After Finnish The Matrix Press Double Enter.\n");
            Console.Write($"For Ex:\n 1 1\n 2 2\n[Press Enter]\n[Press Enter]\n");
            Console.WriteLine($"Please Input The First Matrix:\n");
            var TotalString = new StringBuilder();
            string Input = null;
            do
            {
                Input = Console.ReadLine().Trim();
                var StringRow = Input + "M";
                TotalString.Append(StringRow.ToString());
            } while (Input != String.Empty);

            Console.WriteLine($"Please Input The Second Matrix:\n");
            var TotalStringSec = new StringBuilder();
            string SecInput = null;
            do
            {
                SecInput = Console.ReadLine().Trim();
                var StringRow = SecInput + "M";
                TotalStringSec.Append(StringRow.ToString());
            } while (SecInput != String.Empty);

            var ColumnsCapacityM1 = Methods_To_Help.GetUnkownArrayFormUser(TotalString).ColumnCapacity;
            var RowCapacityM1 = Methods_To_Help.GetUnkownArrayFormUser(TotalString).RowCapacity;

            var ColumnsCapacityM2 = Methods_To_Help.GetUnkownArrayFormUser(TotalStringSec).ColumnCapacity;
            var RowCapacityM2 = Methods_To_Help.GetUnkownArrayFormUser(TotalStringSec).RowCapacity;

            var MinCapacityColumns = Math.Min(ColumnsCapacityM1, ColumnsCapacityM2);
            var MinCapacityRow = Math.Min(RowCapacityM1, RowCapacityM2);

            string[] RowsArrayM1 = TotalString.ToString().Replace("MM", "").Trim().Split('M');
            string[] RowsArrayM2 = TotalStringSec.ToString().Replace("MM", "").Trim().Split('M');
            var NumbersString = new StringBuilder();
            int RowIndexM2 = 0;
            foreach (string Srow in RowsArrayM1)
            {
                var NewM1 = Methods_To_Help.GetStringWithoutSymbol(Srow.Trim(), " ");
                var StringLengthM1 = NewM1.Split(' ');
                for (int i = 0; i < MinCapacityColumns; i++)
                {
                    double MultiItem = 0;
                    foreach (var item in StringLengthM1)
                    {
                        var NewM2 = Methods_To_Help.GetStringWithoutSymbol(RowsArrayM2[RowIndexM2].Trim(), " ");
                        var StringLengthM2 = NewM2.Split(' ');
                        MultiItem += Methods_To_Help.IsDoubleNumber(item) * Methods_To_Help.IsDoubleNumber(StringLengthM2[i]);
                        RowIndexM2++;
                    }
                    RowIndexM2 = 0;
                    NumbersString.Append(MultiItem.ToString() + "l");
                }
                NumbersString.Remove(NumbersString.Length - 1, 1);
                NumbersString.Append("m");
            }
            var ReadyString = NumbersString + "m";
            string[] RowsArray = ReadyString.ToString().Replace("mm", "").Trim().Split('m');
            double[,] NewArray = new double[MinCapacityColumns, MinCapacityRow];

            Console.WriteLine($"The Multiple Matrix:\n");
            int index = 0;
            foreach (var TRow in RowsArray)
            {
                var AddToRow = TRow.Trim() + "l";
                string[] RowsItems = TRow.Replace("ll", "").Split('l');
                for (int j = 0; j < MinCapacityRow; j++)
                {
                    NewArray[index, j] = Methods_To_Help.IsDoubleNumber(RowsItems[j]);
                    Console.Write($"{NewArray[index, j]} ");
                }
                index++;
                Console.Write("\n");
            }
        }
        /*T11 - Write a C# program to find the sum of the Right Diagonal of a given matrix.*/
        private static void T11()
        {
            Console.Write($"Please Input Two Matrices With Same Capacity To Get The Resultant Matrix:\n");
            Console.Write($"**** Note That:\n" +
                          $"               1 - You Can Separate Numbers By Space Or Any Symble (-,'.....).\n");
            Console.Write($"               2 - The Capacity Will According By Each Column And Each Row.\n");
            Console.Write($"               3 - After Finnish The Matrix Press Double Enter.\n");
            Console.Write($"For Ex:\n 1 1\n 2 2\n[Press Enter]\n[Press Enter]\n");
            Console.WriteLine($"Please Input The Matrix:\n");
            var TotalString = new StringBuilder();
            string Input = null;
            do
            {
                Input = Console.ReadLine().Trim();
                var StringRow = Input + "M";
                TotalString.Append(StringRow.ToString());
            } while (Input != String.Empty);

            var ColumnsCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalString).ColumnCapacity;
            var RowCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalString).RowCapacity;
            var InputArray = Methods_To_Help.GetUnkownArrayFormUser(TotalString).UserArray;

            Console.Write("\nThe Sum Of The Right Diagonal Of A Given Matrix = ");
            double sum = 0;
            int ColToSub = RowCapacity - 1;
            for (int i = 0; i < ColumnsCapacity; i++)
            {
                sum += InputArray[i, ColToSub];
                ColToSub--;
            }
            Console.Write($" {sum} ");
        }
        /*T12 - Write a C# program to check whether a given matrix is an Identity Matrix or not.*/
        private static void T12()
        {
            Console.Write($"Please Input Two Matrices With Same Capacity To Get The Resultant Matrix:\n");
            Console.Write($"**** Note That:\n" +
                          $"               1 - You Can Separate Numbers By Space Or Any Symble (-,'.....).\n");
            Console.Write($"               2 - The Capacity Will According By Each Column And Each Row.\n");
            Console.Write($"               3 - After Finnish The Matrix Press Double Enter.\n");
            Console.Write($"For Ex:\n 1 1\n 2 2\n[Press Enter]\n[Press Enter]\n");
            Console.WriteLine($"Please Input The Matrix:\n");
            var TotalString = new StringBuilder();
            string Input = null;
            do
            {
                Input = Console.ReadLine().Trim();
                var StringRow = Input + "M";
                TotalString.Append(StringRow.ToString());
            } while (Input != String.Empty);

            var ColumnsCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalString).ColumnCapacity;
            var RowCapacity = Methods_To_Help.GetUnkownArrayFormUser(TotalString).RowCapacity;
            var InputArray = Methods_To_Help.GetUnkownArrayFormUser(TotalString).UserArray;

            int CkeckNo = 0;
            foreach (var item in InputArray)
            {
                for (int i = 0; i < ColumnsCapacity; i++)
                {
                    for (int j = 0; j < RowCapacity; j++)
                    {
                        if (item == InputArray[i, j])
                        {
                            CkeckNo++;
                        }
                    }
                }
            }
            if (CkeckNo == InputArray.LongLength)
            {
                Console.Write("\nIt's Identity Matrix");
            }
            else
            {
                Console.Write("\nIt's not Identity Matrix");
            }
        }
        /*T13 - + 10 Bonus: for implementing Matrix input / output shape for Tasks(T9, T10, T11, T12).*/
        private static void T13()
        {
            T9();
        }

    }
}
