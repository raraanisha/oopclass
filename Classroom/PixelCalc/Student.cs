class Student(string name, DateTime dob, string college, string program)
{
    public string name = name;
    public DateTime dob = dob;
    public string college = college;
    public string program = program;
    //Calculate age of an student in years and month eg. 22 years and 2 months.
    //tuple
    public (string, int) CalculateAge()
    {
        var agespan = DateTime.Now - dob;
        var year = agespan.Days / 365;
        var month = agespan.Days % 365/30;
        return ($"{year} years and {month} months", agespan.Days);
    }
    //Get name initials of thr student.
    public string NameInitial()
    {
        string result = "";
        var words = name.Split(" ");
        foreach (string word in words)
        {
            if (word.Length > 0)
            {
                result += word[0];
            }
        }
        return result;
    }
    //Get short
    public string GetInitials()
    {
        var nameParts = name.Split(" ");
        char firstInitial = nameParts[0][0];
        char lastInitial = nameParts[nameParts.Length -1][0]; //nameParts.Last()[0]; //nameParts[^1][0];
        //nameParts[1..][0]; returns everything along index 1.
        return $"{firstInitial}{lastInitial}";
    }
    public string CapitalizeName() => name.ToUpper();
    // Print details of a student. Output format : BR is 23 years old.
    //static method does not need object to call it. it can be called by class name.
    //public static void PrintStudentDetails(string initials, string dates) => Console.WriteLine($"{initials} is {dates} old.");
    public static void PrintStudentDetails(string initials, string dates, int days = 0) => Console.WriteLine($"{initials} is {dates} old.{((days == 0) ? "" : $" {days} days old.")}");
    public static void PrintStudentDetails(string details) => Console.WriteLine($"Student details: {details}");
}