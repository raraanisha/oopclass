using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForDotnettraining.Generics;
internal class PlayingWithCollections

{
    //Arrays, List, Dictionairies

    public static void LearnArrays()
    {
        string[] empNames = new string[10];
        empNames[0] = "Anisha";
          empNames[1] = "Anisha";
          empNames[2] = "Anisha";  
          string names = ["Anisha", "Sita", "Gita"];
          byte[] evenNumbers = [2, 4, 6, 8, 10, 12, 14, 16, 18];  
          int[][] mat1 = [[2, 3, 4], [3, 4, 5]];   //jagged arrays
          int[,] mat2 {{1, 2, 3},{3, 4, 5}};

int[] numbers = Enumerables.Range(1, 100).ToArray();
    }

// create an array of numbers from 1 to 100
// from that collection print the number to console if its multiple of 3 or 5

        //   int[100] newCollectionNum = new int[100];
        //   for(i = 0; i <= 100; i++ )
        //   {
        //     i = i + 1;

        //  }
          

        //   int[] getArrayResult = 
        //   newCollectionNum[]

    
    public void LearnList()
    {

List<string> names = ["Anisha", "Anisha", "Anisha"];
names.Add("Hello");


List<(string Country, string Capital)> countries = new();
countries.Add(("Nepal", "Kathmandu"));
countries.Add(("China", "Beijing"));
countries.Add(("Japan", "Tokyo"));s



List<Person> people = new();
Person person1 = new ();
Person person2 = new ();
Person person3 = new ();
Person person4 = new ();
Person person5 = new ();


// people.Add(person1);
// people.Add(person2);
// people.Add(person3);
// people.Add(person4);
// people.Add(person5);


people.AddRange([new Person(), person2, person3, person4, person5]);
    }
    


    public void LearnDictionary()
    {

        Dictionary<string, int> countryPopulation = new();
countryPopulation.Add("Nepal", 3578282);
countryPopulation.Add("China", 748377884);
countryPopulation.Add("Japan", 6354546);

    }




    }
           
