using ABC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleForFundamental;
internal class Linq   //linq = Language Integrated Query
{
   static double[] marks = [35.5, 39.7, 40.1, 65, 84, 76.6];    // yesti chaiyo "35.50","39.70"
    // Get all marks above 40
    static List<Student> students =
        [
        new Person("Ram Bista", new DateTime (1990, 12,12), "NMC", "BIT"),
        new Person("Radha Bista", new DateTime (1991, 12,12), "KEC", "B.Tech"),
        new Person("Rohit Bista", new DateTime (1992, 12,12), "Orient", "BIM"),
        new Person("Ramkant Bista", new DateTime (1993, 12,12), "PK", "BscCsit"),
        new Person("Ramnath Bista", new DateTime (2014, 12,12), "CCRC", "BE"),
        new Person("Ramhari Bista", new DateTime (2015, 12,12), "NCIT", "BIT"),
        new Person("Ramraj Bista", new DateTime (2010, 12,12), "Quest", "Mtech")
        ];
    public static void Query()
    {
        // Imperative
        List<double> passMarks = [];
        foreach (var mark in marks)
        {
            if (mark > 40)
            {
                passMarks.Add(mark);
            }
        }
        //Declarative
        var passMarks1 = marks.Where(mark => mark > 40); //Filter
        var result = marks.Select(x => x.ToString("F2"));  //F2 FOR DECIMAL TYPES //PROJECTION
        foreach(var mark in result)
        {
            Console.WriteLine(mark);
        }
        // Get all passmarks converted too nearest integer
        // Method syntax
        var passMarks2 = marks.Where(mark => mark > 40).Select(x => Math.Round(x, MidpointRounding.AwayFromZero));
        //Expression syntax we can do by any syntax
        passMarks2 = from mark in marks
                     where mark > 40
                     select Math.Round(mark);
        foreach (var mark in passMarks2)
        {
            Console.WriteLine(mark);
        }
       
      
         //Get all employees who are older than 20 years
        var youngerStudents = students.Where(x => x.dob.Year > 2000);
  // Get all employees who are born after 2000 AD

  var emps = students
  .Select(x => new { Name = x.name, Age = x.Calculate()});
  .OrderBy(x => x.Age.Item2);

  foreach(var item in emps{
    Console.Writeline($"{item.Name}\{item.Age.Item1}") });


    }
}