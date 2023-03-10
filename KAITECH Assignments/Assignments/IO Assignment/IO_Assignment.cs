using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace KAITECH_Assignments
{
    public static class IO_Assignment
    {
        #region Fields
        private const string T1TextFilePath = @"..\..\T1Text Files\T1.txt";
        private const string T2CreatAndDeletePath = @"..\..\T2FolderToDelete";
        private const string T3CreatFolderWithHiddenSubFoldersPath = @"..\..\T3FolderWithHiddenSubFolders";
        private const string T4FolderWithFilesToRenamePath = @"..\..\T4FolderWithFilesToRename";
        private const string T5OreginalFolderPath = @"..\..\T5OreginalFolder";
        private const string T5CopyFolderPath = @"..\..\T5CopyFolder";
        private const string T6FolderToGetSizePath = @"..\..\T6FolderOfSize";
        private const string T7FolderToGetTimePath = @"..\..\T7FolderOfTime";
        private const string T8FolderOfRevitPath = @"..\..\T8FolderOfRevit";
        #endregion
        public static void GetTheMethodsAtAssignment()
        {
            Console.WriteLine("------IO Assignment------\n" +
                "T1- Write a C# program to create a text file and write the following Text with 5 lines in it, then open the file automatically with coding (Mimicking double clicking on it).\n" +
                "    Text:\n" +
                "    “Dear Eng. { YourName},”\n" +
                "    “Welcome to BIM Application Development Track.”\n" +
                "    “This is Round { YourRoundNumber }.“\n" +
                "T2 - Write a C# program to delete a folder with all of its content (files & sub-folders & sub-files, ...).\n" +
                "T3 - Write a C# program to create a hidden file.\n" +
                "T4 - Write a C# program to rename a file.\n" +
                "T5 - Write a C# program to copy a folder with all of its content (files & sub-folders & sub-files, ...) from one location to another location.\n" +
                "T6 - Write a C# program to get the size of a folder in Mega Bytes.\n" +
                "T7 - Write a C# program to get the Last Modification Time for each file & sub-folder & sub-file in a specified folder.\n" +
                "T8 - Write a C# program to get the number of Revit Projects & Families in a Folder.\n" +
                "     For Example:\n" +
               @"     Input: E:\Test Folder\n" +
                "     Expected Output:\n" +
                "     “This Folder has:”\n" +
                "     “3 Revit Projects”\n" +
                "     “2 Revit Families”\n" +
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
                    default:
                        Console.WriteLine("\nSorry There Is Only T From [1] To [10]");
                        break;
                }
                Console.WriteLine("\nIf You Want To Quit Just Assign [Q] Or Enter Method Number : ...\n");
                NoOfMethod = Console.ReadLine();
            } while (NoOfMethod.ToString().ToLower() != "q");
        }
        /*T1 - Write a C# program to create a text file and write the following Text with 5 lines in it, then open the file automatically with coding (Mimicking double clicking on it).
               Text:
               “Dear Eng. { YourName},”
               “Welcome to BIM Application Development Track.”
               “This is Round { YourRoundNumber }.*/
        private static void T1()
        {
            Console.Write("Plaese Enter Your Name If You Want To Change It [You Can Leave It Empty] :\n");
            string Input = Console.ReadLine().Trim();
            string NewName;
            if (Input != String.Empty)
            {
                NewName = Input;
            }
            else
            {
                NewName = "Muhammad";
            }
            Console.Write("\nPlaese Enter Your Round Number If You Want To Change It [You Can Leave It Empty] :\n");
            string Input2 = Console.ReadLine().Trim();
            string NewRoundNumber;
            if (Input2 != String.Empty)
            {
                NewRoundNumber = Input2;
            }
            else
            {
                NewRoundNumber = "4";
            }
            Console.Write("\nIf You Want To Add Any Additional Text [You Can Leave It Empty] :\n");
            string Input4 = Console.ReadLine().Trim();
            string NewText;
            if (Input4 != String.Empty)
            {
                NewText = Input4;
            }
            else
            {
                NewText = "";
            }
            Console.Write("\nPlaese Enter The File Path With The File Name And Extension If You Want To Change It [You Can Leave It Empty] :\n");
            string Input3 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input3 != String.Empty)
            {
                NewFilePath = Input3;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T1TextFilePath;
            }
            var TextString = new StringBuilder();
            TextString.AppendLine($"Dear Eng. {NewName},");
            TextString.AppendLine($" ");
            TextString.AppendLine($"Welcome to BIM Application Development Track.");
            TextString.AppendLine($" ");
            TextString.AppendLine($"This is Round {NewRoundNumber}.");
            TextString.AppendLine($" ");
            TextString.AppendLine($"{NewText}");

            FileInfo file = new FileInfo(NewFilePath);
            var TextCreat = file.CreateText();
            TextCreat.Write(TextString);
            TextCreat.Close();

            Console.Write("\n*****Plaese Enter To Open The File Or Write Anything Then Press Enter To Quit :\n");
            string Input5 = Console.ReadLine().Trim();
            if (Input5 == String.Empty)
            {
                using (var NewProsses = new Process())
                {
                    NewProsses.StartInfo.FileName = NewFilePath;
                    NewProsses.Start();
                }
            }
        }
        /*T2 - Write a C# program to delete a folder with all of its content (files & sub-folders & sub-files, ...).*/
        private static void T2()
        {
            Console.Write("\nPlaese Enter The Directory Path That You Want To Dalete [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T2CreatAndDeletePath;
            }
            var NewDirectory = new DirectoryInfo(NewFilePath);
            NewDirectory.Create();
            for (int i = 0; i < 10; i++)
            {
                var SubFolderPath = $@"{NewFilePath}\SubFolderNo{i + 1}";
                var NewSubDirectory = new DirectoryInfo(SubFolderPath);
                NewSubDirectory.Create();
                for (int j = 0; j < 10; j++)
                {
                    var FilePath = $@"{SubFolderPath}\FileNo{j + 1}.txt";
                    FileInfo file = new FileInfo(FilePath);
                    var TextCreat = file.CreateText();
                    TextCreat.Write($"This Text File No {j + 1}");
                    TextCreat.Dispose();
                }
            }
            Console.Write("\n" + @"Finnished To Create Folder\[10]SubFolders\[10]TextFiles" + "\n");
            Console.Write("\nNow If You Want To Delete This Folder Press [Yes] Or [Y]");
            string Input3 = Console.ReadLine().ToLower().Trim();
            if (Input3 == "yes" || Input3 == "y")
            {
                NewDirectory.Delete(true);
                Console.Write("\nThe Folder Was Deleted");
            }
        }
        /*T3 - Write a C# program to create a hidden file.*/
        private static void T3()
        {
            Console.Write("\nPlaese Enter The Directory Path That You Want To Create An Hidden Folder Inside It [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T3CreatFolderWithHiddenSubFoldersPath;
            }
            var NewDirectory = new DirectoryInfo(NewFilePath);
            NewDirectory.Create();
            for (int i = 0; i < 10; i++)
            {
                var SubFolderPath = $@"{NewFilePath}\SubFolderNo{i + 1}";
                var NewSubDirectory = new DirectoryInfo(SubFolderPath);
                NewSubDirectory.Create();
                for (int j = 0; j < 10; j++)
                {
                    var FilePath = $@"{SubFolderPath}\FileNo{j + 1}.txt";
                    FileInfo file = new FileInfo(FilePath);
                    file.Attributes = FileAttributes.Normal;
                    var TextCreat = file.CreateText();
                    TextCreat.Write($"This Text File No {j + 1}");
                    TextCreat.Dispose();
                    file.Attributes = FileAttributes.Hidden;
                }
                NewSubDirectory.Attributes = FileAttributes.Hidden;
            }
            Console.Write("\n" + @"Finnished To Create Folder\[10](Hidden)SubFolders\[10]TextFiles" + "\n");
            Console.Write("\n*****Press [ Enter ] To Open The Folder \nOr\nIf You Want To Delete This Folder Press [Yes] Or [Y] :\n");
            string Input5 = Console.ReadLine().Trim();
            if (Input5 == String.Empty)
            {
                using (var NewProsses = new Process())
                {
                    NewProsses.StartInfo.FileName = NewFilePath;
                    NewProsses.Start();
                }
            }
            else if (Input5 == "yes" || Input5 == "y")
            {
                NewDirectory.Delete(true);
                Console.Write("\nThe Folder Was Deleted");
            }
        }
        /*T4 - Write a C# program to rename a file.*/
        private static void T4()
        {
            Console.Write("\nPlaese Enter The Directory Path [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            string ExistFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                ExistFilePath = Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T4FolderWithFilesToRenamePath;
                ExistFilePath = Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            var NewSubDirectory = new DirectoryInfo(ExistFilePath);
            if (!NewSubDirectory.Exists)
            {
                NewSubDirectory.Create();
            }
            var ListOfFiles = NewSubDirectory.GetFiles().DefaultIfEmpty();
            var FilesList = new List<FileInfo>();
            int count = 1;
            foreach (var file in ListOfFiles)
            {
                Console.WriteLine($"{count} - " + file.Name);
                FilesList.Add(file);
                count++;
            }
            var LIstOfInput = new List<string>();
        ReInputNo:
            Console.Write("\nPlease Input The Files Number (Separted With Space) That You Want To Rename :\n");
            string Input0 = Console.ReadLine().Trim();
            if (Input0 != String.Empty)
            {
                LIstOfInput = Input0.Split(' ').ToList();
            }
            else
            {
                goto ReInputNo;
            }
            var ListOfNum = new List<int>();
            foreach (var input in LIstOfInput)
            {
                var NumInput = Methods_To_Help.IsIntNumber(input);
                ListOfNum.Add(NumInput);
            }
            int i = 0;
            foreach (var fileNo in ListOfNum)
            {
                string NewName;
                var FileRename = FilesList[fileNo - 1];
                var ChangeName = FileRename.FullName.Remove((FileRename.FullName.Length - FileRename.Name.Length - 1), FileRename.Name.Length);
                var FileEx = FileRename.Extension;
                Console.Write($"\nPlease Input The New Name Of File [{FileRename.Name}] :\n");
                var Input5 = Console.ReadLine().Trim();
                if (Input5 != String.Empty)
                {
                    NewName = Input5;
                }
                else
                {
                    NewName = $"File{i}";
                }
                var NewFileRename = NewName + FileEx;
                FileRename.MoveTo(ExistFilePath + $@"\{NewFileRename}");
                i++;
            }
            Console.Write("\n" + @"Finnished To Change Files Name" + "\n");
            Console.Write("\n*****Press [ Enter ] To Open The Folder :\n");
            string Input6 = Console.ReadLine().Trim();
            if (Input6 == String.Empty)
            {
                using (var NewProsses = new Process())
                {
                    NewProsses.StartInfo.FileName = NewFilePath;
                    NewProsses.Start();
                }
            }
        }
        /*T5 - Write a C# program to copy a folder with all of its content (files & sub-folders & sub-files, ...) from one location to another location.*/
        private static void T5()
        {
            Console.Write("\nPlaese Enter The Directory Path Of Folder That You Want To Copy  [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T5OreginalFolderPath;
                var NewDirectory = new DirectoryInfo(NewFilePath);
                NewDirectory.Create();
                for (int i = 0; i < 10; i++)
                {
                    var SubFolderPath = $@"{NewFilePath}\SubFolderNo{i + 1}";
                    var NewSubDirectory = new DirectoryInfo(SubFolderPath);
                    NewSubDirectory.Create();
                    for (int j = 0; j < 10; j++)
                    {
                        var FilePath = $@"{SubFolderPath}\FileNo{j + 1}.txt";
                        FileInfo file = new FileInfo(FilePath);
                        var TextCreat = file.CreateText();
                        TextCreat.Write($"This Text File No {j + 1}");
                        TextCreat.Dispose();
                    }
                }
                Console.Write("\n" + @"Finnished To Create Folder\[10](Hidden)SubFolders\[10]TextFiles" + "\n");
            }
            Console.Write("\nPlaese Enter The Copy Directory Path That You Want To Copy Folder Inside It [You Can Leave It Empty] :\n");
            string Input2 = Console.ReadLine().Trim();
            string CopyFilePath;
            if (Input1 != String.Empty)
            {
                CopyFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(CopyFilePath);
            }
            else
            {
                CopyFilePath = T5CopyFolderPath;
            }
            var CopyDirectory = new DirectoryInfo(NewFilePath);
            var FoldersD = CopyDirectory.GetDirectories().ToList();
            var FilesD = CopyDirectory.GetFiles().ToList();
            foreach (var folder in FoldersD)
            {
                var CopySubDirectory = new DirectoryInfo(folder.FullName);
                var FoldersSD = CopySubDirectory.GetDirectories().ToList();
                var FilesSD = CopySubDirectory.EnumerateFiles().ToList();
                foreach (var folderS in FoldersSD)
                {
                    var CopySubSubDirectory = new DirectoryInfo(folderS.FullName);
                    var FoldersSSD = CopySubSubDirectory.GetDirectories().ToList();
                    var FilesSSD = CopySubSubDirectory.EnumerateFiles().ToList();
                    var NewSD = new DirectoryInfo(CopySubSubDirectory + $@"\{folderS.Name}");
                    NewSD.Create();
                    foreach (var fileSS in FilesSSD)
                    {
                        fileSS.CopyTo(NewSD.FullName);
                    }
                }
                var NewD = new DirectoryInfo(CopyFilePath + $@"\{folder.Name}");
                NewD.Create();
                foreach (var file in FilesSD)
                {
                    file.CopyTo(NewD + @"\" + file.Name);
                }
                foreach (var file in FilesD)
                {
                    file.CopyTo(NewD + file.Name);
                }
            }
            Console.Write("\n" + @"Finnished To Copy Folder And SubFolder And Files" + "\n");
        }
        /*T6 - Write a C# program to get the size of a folder in Mega Bytes.*/
        private static void T6()
        {
            Console.Write("\nPlaese Enter The Directory Path Of Folder That You Want To Know The Size Of It  [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T6FolderToGetSizePath;
                var NewDirectory = new DirectoryInfo(NewFilePath);
                NewDirectory.Create();
                for (int i = 0; i < 10; i++)
                {
                    var SubFolderPath = $@"{NewFilePath}\SubFolderNo{i + 1}";
                    var NewSubDirectory = new DirectoryInfo(SubFolderPath);
                    NewSubDirectory.Create();
                    for (int j = 0; j < 10; j++)
                    {
                        var FilePath = $@"{SubFolderPath}\FileNo{j + 1}.txt";
                        FileInfo file = new FileInfo(FilePath);
                        var TextCreat = file.CreateText();
                        TextCreat.Write($"This Text File No {j + 1}");
                        TextCreat.Dispose();
                    }
                }
                Console.Write("\n" + @"Finnished To Create Folder\[10](Hidden)SubFolders\[10]TextFiles" + "\n");
            }
            var NewDirectory2 = new DirectoryInfo(NewFilePath);
            var CopyDirectory = new DirectoryInfo(NewFilePath);
            var FoldersD = CopyDirectory.GetDirectories().ToList();
            var FilesD = CopyDirectory.GetFiles().ToList();
            long SizeS = 0;
            foreach (var folder in FoldersD)
            {
                var CopySubDirectory = new DirectoryInfo(folder.FullName);
                var FoldersSD = CopySubDirectory.GetDirectories().ToList();
                var FilesSD = CopySubDirectory.EnumerateFiles().ToList();
                foreach (var folderS in FoldersSD)
                {
                    var CopySubSubDirectory = new DirectoryInfo(folderS.FullName);
                    var FoldersSSD = CopySubSubDirectory.GetDirectories().ToList();
                    var FilesSSD = CopySubSubDirectory.EnumerateFiles().ToList();
                    var NewSD = new DirectoryInfo(CopySubSubDirectory + $@"\{folderS.Name}");
                    NewSD.Create();
                    foreach (var fileSS in FilesSSD)
                    {
                        SizeS += fileSS.Length;
                    }
                }
                var NewD = new DirectoryInfo(NewFilePath + $@"\{folder.Name}");
                NewD.Create();
                foreach (var file in FilesSD)
                {
                    SizeS += file.Length;
                }
                foreach (var file in FilesD)
                {
                    SizeS += file.Length;
                }
            }
            Console.WriteLine($"The Full Size = {SizeS} byets");
        }
        /*T7 - Write a C# program to get the Last Modification Time for each file & sub-folder & sub-file in a specified folder.*/
        private static void T7()
        {
            Console.Write("\nPlaese Enter The Directory Path Of Folder That You Want To Know The Change Time Of It  [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T7FolderToGetTimePath;
                var NewDirectory = new DirectoryInfo(NewFilePath);
                NewDirectory.Create();
                for (int i = 0; i < 10; i++)
                {
                    var SubFolderPath = $@"{NewFilePath}\SubFolderNo{i + 1}";
                    var NewSubDirectory = new DirectoryInfo(SubFolderPath);
                    NewSubDirectory.Create();
                    for (int j = 0; j < 10; j++)
                    {
                        var FilePath = $@"{SubFolderPath}\FileNo{j + 1}.txt";
                        FileInfo file = new FileInfo(FilePath);
                        var TextCreat = file.CreateText();
                        TextCreat.Write($"This Text File No {j + 1}");
                        TextCreat.Dispose();
                    }
                }
                Console.Write("\n" + @"Finnished To Create Folder\[10](Hidden)SubFolders\[10]TextFiles" + "\n");
            }
            var CopyDirectory = new DirectoryInfo(NewFilePath);
            var FoldersD = CopyDirectory.GetDirectories().ToList();
            var FilesD = CopyDirectory.GetFiles().ToList();
            foreach (var folder in FoldersD)
            {
                var CopySubDirectory = new DirectoryInfo(folder.FullName);
                var FoldersSD = CopySubDirectory.GetDirectories().ToList();
                var FilesSD = CopySubDirectory.EnumerateFiles().ToList();
                foreach (var folderS in FoldersSD)
                {
                    var CopySubSubDirectory = new DirectoryInfo(folderS.FullName);
                    var FoldersSSD = CopySubSubDirectory.GetDirectories().ToList();
                    var FilesSSD = CopySubSubDirectory.EnumerateFiles().ToList();
                    var NewSD = new DirectoryInfo(CopySubSubDirectory + $@"\{folderS.Name}");
                    NewSD.Create();
                    foreach (var fileSS in FilesSSD)
                    {
                        Console.WriteLine($"The File Path {fileSS.FullName} --- {fileSS.Name} --> The Last Access Time = {fileSS.LastAccessTime}");
                    }
                }
                var NewD = new DirectoryInfo(NewFilePath + $@"\{folder.Name}");
                NewD.Create();
                foreach (var file in FilesSD)
                {
                    Console.WriteLine($"The File Path {file.FullName} --- {file.Name} --> The Last Access Time = {file.LastAccessTime}");
                }
                foreach (var file in FilesD)
                {
                    Console.WriteLine($"The File Path {file.FullName} --- {file.Name} --> The Last Access Time = {file.LastAccessTime}");
                }
            }
        }
        /*T8 - Write a C# program to get the number of Revit Projects & Families in a Folder.
               For Example:
                   Input: E:\Test Folder
                   Expected Output:
                           “This Folder has:”
                           “3 Revit Projects”
                           “2 Revit Families”*/
        private static void T8()
        {
            Console.Write("\nPlaese Enter The Directory Path Of Folder That You Want To Know The Change Time Of It  [You Can Leave It Empty] :\n");
            string Input1 = Console.ReadLine().Trim();
            string NewFilePath;
            if (Input1 != String.Empty)
            {
                NewFilePath = Input1;
                Methods_To_Help.IsDriectoryExists(NewFilePath);
            }
            else
            {
                NewFilePath = T8FolderOfRevitPath;
                var NewDirectory = new DirectoryInfo(NewFilePath);
                NewDirectory.Create();
                for (int i = 0; i < 10; i++)
                {
                    var SubFolderPath = $@"{NewFilePath}\SubFolderNo{i + 1}";
                    var NewSubDirectory = new DirectoryInfo(SubFolderPath);
                    NewSubDirectory.Create();
                    for (int j = 0; j < 10; j++)
                    {
                        var FilePath = $@"{SubFolderPath}\FileNo{j + 1}.rvt";
                        FileInfo RVTfile = new FileInfo(FilePath);
                        var RVTCreate = RVTfile.Create();
                        var Filerva = $@"{SubFolderPath}\FileNo{j + 1}.rfa";
                        FileInfo RFAfile = new FileInfo(Filerva);
                        var RFACreate = RFAfile.Create();
                    }
                }
            }
            Console.Write("\n" + @"Finnished To Create Folder\[10]SubFolders\[10]Revit File & [10]Revit Families Files" + "\n");
            var CopyDirectory = new DirectoryInfo(NewFilePath);
            var FoldersD = CopyDirectory.GetDirectories().ToList();
            var FilesD = CopyDirectory.GetFiles().ToList();
            var RVTList = new List<FileInfo>();
            var RFAList = new List<FileInfo>();
            foreach (var folder in FoldersD)
            {
                var CopySubDirectory = new DirectoryInfo(folder.FullName);
                var FoldersSD = CopySubDirectory.GetDirectories().ToList();
                var FilesSD = CopySubDirectory.EnumerateFiles().ToList();
                foreach (var folderS in FoldersSD)
                {
                    var CopySubSubDirectory = new DirectoryInfo(folderS.FullName);
                    var FoldersSSD = CopySubSubDirectory.GetDirectories().ToList();
                    var FilesSSD = CopySubSubDirectory.EnumerateFiles().ToList();
                    var NewSD = new DirectoryInfo(CopySubSubDirectory + $@"\{folderS.Name}");
                    NewSD.Create();
                    foreach (var fileSS in FilesSSD)
                    {
                        if (fileSS.Extension == ".rvt")
                        {
                            RVTList.Add(fileSS);
                        }
                        else if (fileSS.Extension == ".rfa")
                        {
                            RFAList.Add(fileSS);
                        }
                    }
                }
                var NewD = new DirectoryInfo(NewFilePath + $@"\{folder.Name}");
                NewD.Create();
                foreach (var file in FilesSD)
                {
                    if (file.Extension == ".rvt")
                    {
                        RVTList.Add(file);
                    }
                    else if (file.Extension == ".rfa")
                    {
                        RFAList.Add(file);
                    }
                }
                foreach (var file in FilesD)
                {
                    if (file.Extension == ".rvt")
                    {
                        RVTList.Add(file);
                    }
                    else if (file.Extension == ".rfa")
                    {
                        RFAList.Add(file);
                    }
                }
            }
            Console.WriteLine($"This Folder Includ:\n [{RVTList.Count}] Revit Files\n [{RFAList.Count}] Revit Families Files");
        }

    }
}
