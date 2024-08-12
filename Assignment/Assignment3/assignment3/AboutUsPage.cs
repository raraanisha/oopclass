public class AboutUsPage : HomePage
{
    public string Title { get; set; }
    public long[] Contacts { get; set; }

    public void InitiatePhone(string number)
    {
        if (!string.IsNullOrWhiteSpace(number) && Contacts.Contains(Convert.ToInt64(number)) &&  number.Length == 10 )
        {
            Console.WriteLine($"Initiate Phone: {number}");
        }
        else
        {
            Console.WriteLine("Initiating Phone Number is Failed.");
        }
    }

    public void InitiateEmail(string email)
    {
        if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
        {
            char[] delimiters = { '@', '.' };
            var emailData = email.Split(delimiters);
            if (emailData.Count() >= 3)
            {
                Console.WriteLine($"Initiate Email: {email}");
            }
            else
            {
                Console.WriteLine("Initiating Email ID Failed.");
            }
        }
        else
        {
            Console.WriteLine("Initiating Email ID Failed.");
        }
    }
}