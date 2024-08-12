
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class HomePage : IDriver
{
    public string[] MenuItems { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public byte[] ProfilePic { get; set; }
    //public string[][] LoginDetails { get; set; }

    // private Dictionary<string, string> userDetails = new();
    //  {
    //     {"anisha", "Teksewa"},
    //     {"hello", "Nepal123"}
    //  }

    public void HandleMenuClick(string menuItem)
    {

        if (!string.IsNullOrWhiteSpace(menuItem) && MenuItems.Contains(menuItem))
        {
            Console.WriteLine($"Clicked: {menuItem}");
        }
        else
        {
            Console.WriteLine("Invalid clicks.");
        }
    }

    
public void Login(string userName, string password)
{
    if ((!string.IsNullOrWhiteSpace(userName) && userName.Length > 0) && (!string.IsNullOrWhiteSpace(password) && password.Length > 4))
    {
        Console.WriteLine("Login Successful.");
        Console.WriteLine($"Hello! {userName}");
    }
    else
    {
        Console.WriteLine("Login Failed");
    }
}

public void Navigate(string url)
{
    Console.WriteLine($"Navigate to {url}");
}
public void GetCurrentUrl()
{
    Console.WriteLine("Current URL: https://www.example.com");
}
}