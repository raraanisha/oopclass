using System;
using System.Collections.Generic;
using System.Linq;
namespace trainee;
internal class Trainee
{
    public string Name { get; }
    public DateTime Dob { get; }
    public string College { get; }
    public string Program { get; }

    public Trainee(string name, DateTime dob, string college, string program)
    {
        Name = name;
        Dob = dob;
        College = college;
        Program = program;
    }

    // Calculate age of a trainee in years and months
    public (string, int) CalculateAge()
    {
        var ageSpan = DateTime.Now - Dob;
        var years = ageSpan.Days / 365;
        var months = (ageSpan.Days % 365) / 30;
        return ($"{years} Years and {months} Months", ageSpan.Days);
    }

    // Get name initials of a trainee
    public string GetInitials()
    {
        var nameParts = Name.Split(" ");
        char firstInitial = nameParts[0][0];
        var lastInitial = nameParts[^1][0];
        return $"{firstInitial}{lastInitial}";
    }

    public static string PrintDetails(Trainee trainee) =>
        $"{trainee.Name}\t{trainee.Dob.ToShortDateString()}\t{trainee.College}\t{trainee.Program}";
}

internal class Reports
{
    static List<Trainee> trainees = new List<Trainee>
    {
        new Trainee("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
        new Trainee("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
        new Trainee("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
        new Trainee("Suneer Bista", new DateTime(2000, 6, 10), "Cenral TU", "BIT"),
        new Trainee("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
        new Trainee("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC"),
        new Trainee("Rama Chitrakar", new DateTime(2003, 8, 17), "People's College", "BSC"),
        new Trainee("Mahesh Manandhar", new DateTime(2004, 9, 23), "CCRC", "BIM"),
        new Trainee("Renu Shahi", new DateTime(2004, 9, 23), "Vedas", "BIM"),
        new Trainee("Sanjana Luitel", new DateTime(2007, 4, 26), "PK", "BSC")
    };

    public static void LetsQuery()
    {
        // Get all trainees grouped by their college
        var groupedByCollege = trainees.GroupBy(t => t.College)
            .Select(group => new
            {
                College = group.Key,
                Trainees = group.ToList()
            });

        Console.WriteLine("Trainees grouped by college:");
        foreach (var group in groupedByCollege)
        {
            Console.WriteLine($"College: {group.College}");
            foreach (var trainee in group.Trainees)
            {
                Console.WriteLine(Trainee.PrintDetails(trainee));
            }
        }

        Console.WriteLine("\nTrainees who are in their teens:");
        // Get name and age of trainees who are in their teens
        var teenTrainees = trainees
            .Select(t => new { t.Name, Age = t.CalculateAge() })
            .Where(t => t.Age.Item2 >= 13 * 365 && t.Age.Item2 < 20 * 365);

        foreach (var teen in teenTrainees)
        {
            Console.WriteLine($"{teen.Name} - {teen.Age.Item1}");
        }

        Console.WriteLine("\nTrainees ordered by initials:");
        // Get name initials, age and academic program of trainees and order result by initials
        var orderedByInitials = trainees
            .Select(t => new
            {
                Initials = t.GetInitials(),
                Age = t.CalculateAge().Item1,
                t.Program
            })
            .OrderBy(t => t.Initials);

        foreach (var item in orderedByInitials)
        {
            Console.WriteLine($"{item.Initials} - {item.Age} - {item.Program}");
        }
    }
}
