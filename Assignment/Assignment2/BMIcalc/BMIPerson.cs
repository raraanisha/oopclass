class BMIPerson
{


//creating parameterized constructor
public BMIPerson(string n, double h, double w)
{
this.name = n;
this.height = h;
this.weight = w;
}


public string name;
public double height;
public double weight;

//creating method

double Calculation(double height, double weight)
{
double bmi = weight /Math.Pow((height * 0.3048),2);
return Math.Round(bmi,2);
}

public void PrintBMIdetails(){
Console.WriteLine($"BMI Index of {this.name} with height {this.height} feet and weight {this.weight} kg is{Calculation(this.height,this.weight)}");

}
}

