﻿string filePath = @"C:\Users\anisha_teksewa\Desktop\dotnettraining\Assignment\Assignment5";
List<Person> people = await CSVParser.ParseCSV(filePath);
await PeopleReport.SaveMales(people, filePath);
await PeopleReport.SaveFemales(people, filePath);
await PeopleReport.SaveDotComUsers(people, filePath);