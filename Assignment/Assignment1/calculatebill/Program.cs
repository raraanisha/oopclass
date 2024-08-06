Console.WriteLine("Enter the electric unit: ");
int  unit = int.Parse(Console.ReadLine());
char notify;
//using if-else
if (unit >=1 && unit <= 20){
    Console.WriteLine("The total amount is Rs 100");
}
else if (unit >= 21 && unit <= 25){
    Console.WriteLine($"The total amount is Rs: {100 + (unit -20) * 5}" );
}
else if(unit >= 26 && unit <= 50){
    Console.WriteLine($"The total amount is Rs : { 125 + (unit - 25 ) * 10}" );
}else{
    Console.WriteLine("The total amount is Rs 2000");
}
//using if and switch
if (unit >=1 && unit <= 20){
    notify = 'a';
}
else if (unit >= 21 && unit <= 25){
   notify = 'b';
}
else if(unit >= 26 && unit <= 50){
    notify = 'c';
}else{
    notify = 'd';
}
switch (notify){
    case 'a' : Console.WriteLine("The total amount is Rs 100"); break;
    case 'b':  Console.WriteLine($"The total amount is Rs: {100 + (unit -20) * 5}" );   break;
    case 'c' : Console.WriteLine($"The total amount is Rs : { 125 + (unit - 25 ) * 10}" ); break;
    default :  Console.WriteLine("The total amount is Rs 2000"); break;
}


