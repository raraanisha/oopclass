class Student (string name, DateTime dob, string college, string program)
{
    public string name = name;
    public dateTime dob = dob;
    public string college = college;
    public string program = program;

    public string CalculateAge()
    {
        var agespan = DateTime.now - dob;
        var year = agespan.Days/365;
        var months = agespan.Days%365/30;
        return $"{year} years and {months Months}";
    }
    public string Getinitials()
    {
        var nameParts = name.Split(" ");
        char firstInitial = nameParts[0][0];
        var lastInitials = nameParts[nameParts.Length-1][0];
        return $"{firstInitial}{lastInitial}";

    }
    }
