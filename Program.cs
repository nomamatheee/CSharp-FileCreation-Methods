using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string pathOne = @"C:\Users\user\Downloads\pathOne.txt";
        string pathTwo = @"C:\Users\user\Downloads\pathTwo.txt";
        string pathThree = @"C:\Users\user\Downloads\pathThree.txt";
        string pathFour = @"C:\Users\user\Downloads\pathFour.txt";

        try
        {
            File.Create(pathOne);
            File.CreateText(pathTwo);
            FileInfo obj = new FileInfo(pathThree);
            obj.CreateText();
            FileInfo obj2 = new FileInfo(pathFour);
            obj2.Create();

            if (File.Exists(pathOne)) Console.WriteLine("the text file has been created successfully");
            if (File.Exists(pathTwo)) Console.WriteLine("the text file has been created successfully ");
            if (File.Exists(pathThree)) Console.WriteLine("the text file has been successfully created");
            if (File.Exists(pathFour)) Console.WriteLine("the text file has been created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("text file creation error");
        }

        Console.ReadLine();
    }
}
