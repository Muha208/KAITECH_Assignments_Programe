using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KAITECH_Assignments;

namespace KAITECH_Assignments
{
    public static class Assignments
    {
        static void Main()
        {
            Console.WriteLine("------Welcome------\n" +
                "KAHITECH Assignments System -- By Eng.Muhammad Osama\n" +
                "The List Of Assignments:\n" +
                "1- C-Sharp Fundamentals Assignment\n" +
                "2- Strings Assignment\n" +
                "3- Arrays Assignment\n" +
                "4- IO Assignment\n" +
                "Please Assign The Number Of Assignment You Want To Check.....\n");
            var AssignmentNo = Console.ReadLine();
            do
            {
                switch (Methods_To_Help.IsIntNumber(AssignmentNo))
                {
                    case 1:
                        C_Sharp_Fundamentals_Assignment.GetTheMethodsAtAssignment();
                        break;
                    case 2:
                        Strings_Assignment.GetTheMethodsAtAssignment();
                        break;
                    case 3:
                        Arrays_Assignment.GetTheMethodsAtAssignment();
                        break;
                    case 4:
                        IO_Assignment.GetTheMethodsAtAssignment();
                        break;
                    default:
                        Console.WriteLine("\nSorry There Is Only Assignment From [1] To [1]");
                        break;
                }
                Console.WriteLine("\nIf You Want To Quit Just Assign [Q] Or Enter Assignment Number : ...\n");
                AssignmentNo = Console.ReadLine();
            } while (AssignmentNo.ToString().ToLower() != "q");
        }
    }
}
