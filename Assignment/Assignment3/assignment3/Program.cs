﻿HomePage homePage = new HomePage
{
    MenuItems = new[] { "Home", "About us" },
    Height = 950,
    Width = 750,
    ProfilePic = new byte[] { 100, 200, 120, 225 },


};

AboutUsPage aboutUsPage = new AboutUsPage
{

    MenuItems = new[] { "Home", "About us" },
    Height = 950,
    Width = 750,
    ProfilePic = new byte[] { 100, 200, 120, 225 },
    Title = "About Us",
    Contacts = new[] { 9673334342, 98465857, 9823434329 }
};
//homePage.Login("", "");
homePage.Login("", "testurl");
homePage.Login("Anisha", "              ");
homePage.Login("anisha", "teksewa");

homePage.Navigate("https://www.example.com/home");
homePage.GetCurrentUrl();

homePage.HandleMenuClick("About us");

aboutUsPage.Navigate("https://www.example.com/aboutus");
aboutUsPage.GetCurrentUrl();
aboutUsPage.HandleMenuClick("test");

aboutUsPage.InitiatePhone("9673334342");
aboutUsPage.InitiatePhone("98465857");
aboutUsPage.InitiateEmail("testtest@ymail");
aboutUsPage.InitiateEmail("raraanisha@gmail.com");