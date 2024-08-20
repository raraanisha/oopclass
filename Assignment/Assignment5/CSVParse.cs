internal class CSVParser
{
    public static async Task<List<Person>> ParseCSV(string filePath)
    {
        string fileContent = await File.ReadAllTextAsync($"{filePath}/People.csv");
        var lines = fileContent.Split(["\n", "\r"], StringSplitOptions.RemoveEmptyEntries);
        List<Person> people = new();
        foreach (var item in lines.Skip(1))
        {
            var personData = item.Split(",", StringSplitOptions.RemoveEmptyEntries);
            DateTime.TryParse(personData[7], out DateTime date);
            people.Add(new Person
            {
                Index = int.Parse(personData[0]),
                UserId = personData[1],
                FirstName = personData[2],
                LastName = personData[3],
                Sex = personData[4],
                Email = personData[5],
                Phone = personData[6],
                DateOfBirth = date,
                JobTitle = string.Join(",",personData, 8, personData.Length - 8)
            });
        }
        return people;
    }
}