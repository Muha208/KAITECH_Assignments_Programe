using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAITECH_Assignments
{
    public static class Methods_To_Help
    {
        public static int IsIntNumber(string Number)
        {
            int NewNumber;
            if (int.TryParse(Number.Trim(), out NewNumber))
            {
                return NewNumber;
            }
            else
            {
                return 0;
            }
        }
        public static double IsDoubleNumber(string Number)
        {
            double NewNumber;
            if (double.TryParse(Number.Trim(), out NewNumber))
            {
                return NewNumber;
            }
            else
            {
                return 0;
            }
        }
        public static string GetStringWithoutSymbol(string Text, string ReplaceSymbol = "")
        {
            List<string> ListOfSymbols = new List<string>()
            {":",";","~","`","\\","@","\'","\"","$",",",">","<","=","+",".","{","}","[","]","/","`","#","%","^","*","&","(",")","_","?"," "};
            foreach (var Symbol in ListOfSymbols)
            {
                Text.Replace(Symbol, ReplaceSymbol);
            }
            return Text;
        }
        public static (double[,] UserArray, int ColumnCapacity, int RowCapacity) GetUnkownArrayFormUser(StringBuilder TextInput)
        {
            string[] RowsArray = TextInput.ToString().Replace("MM", "").Trim().Split('M');
            var NumbersString = new StringBuilder();
            var ColumnsCapacity = 0;
            foreach (var row in RowsArray)
            {
                ColumnsCapacity++;
                var New = Methods_To_Help.GetStringWithoutSymbol(row.Trim(), " ");
                var StringLength = New.Split(' ').LongLength;
                NumbersString.Append(StringLength + "l");
            }
            var ReadyString = NumbersString + "l";
            string[] CapacityArray = ReadyString.ToString().Replace("ll", "").Trim().Split('l').OrderBy(x => x).ToArray();
            int RowCapacity = Methods_To_Help.IsIntNumber(CapacityArray[0]);
            double[,] InputArray = new double[ColumnsCapacity, RowCapacity];

            for (int i = 0; i < ColumnsCapacity; i++)
            {
                int RowIndex = 0;
                var rowItems = Methods_To_Help.GetStringWithoutSymbol(RowsArray[i].ToString().Trim(), " ").Split(' ');
                foreach (var item in rowItems)
                {
                    if (RowIndex < RowCapacity)
                    {
                        InputArray[i, RowIndex] = Methods_To_Help.IsDoubleNumber(item);
                        RowIndex++;
                    }
                }
            }
            return (InputArray, ColumnsCapacity, RowCapacity);
        }
        internal static string IsDriectoryExists(string FullDirectoryPath)
        {
            var DirectoryParentPath = new DirectoryInfo(FullDirectoryPath).Parent.FullName;
            if (!Directory.Exists(DirectoryParentPath))
            {
                Directory.CreateDirectory(DirectoryParentPath);
            }
            return FullDirectoryPath;
        }
    }
}
