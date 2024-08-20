internal class PeopleReport
{
    public static async Task SaveMales(List<Person> people, string filePath)
    {
        List<Person> males = people.Where(x => x.Sex == "Male").ToList();
        string fileContents = "Index,User Id,First Name,Last Name,Sex,Email,Phone,Date of birth,Job Title";
        foreach (Person male in males)
        {
            fileContents += $"\n{male.Index},{male.UserId},{male.FirstName},{male.LastName},{male.Sex},{male.Email},{male.Phone},{male.DateOfBirth},{male.JobTitle}";
        }
        await File.WriteAllTextAsync($"{filePath}/Males.csv", fileContents);
    }

    public static async Task SaveFemales(List<Person> people, string filePath)
    {
        List<Person> females = people.Where(x => x.Sex == "Female" && (DateTime.Now - x.DateOfBirth).Days / 365 >= 18).ToList();
        string fileContents = "Index,User Id,First Name,Last Name,Sex,Email,Phone,Date of birth,Job Title";
        foreach (Person female in females)
        {
            fileContents += $"\n{female.Index},{female.UserId},{female.FirstName},{female.LastName},{female.Sex},{female.Email},{female.Phone},{female.DateOfBirth},{female.JobTitle}";
        }
        await File.WriteAllTextAsync($"{filePath}/AdultFemales.csv", fileContents);
    }

    public static async Task SaveDotComUsers(List<Person> people, string filePath)
    {
        List<Person> dotComUsers = people.Where(x => x.Email.EndsWith(".com")).ToList();
        string fileContents = "User Id,Email,Phone";
        foreach (Person dotcomUser in dotComUsers)
        {
            fileContents += $"\n{dotcomUser.UserId},{dotcomUser.Email},{dotcomUser.Phone}";
        }
        await File.WriteAllTextAsync($"{filePath}/DotComUsers.csv", fileContents);
    }
}