// See https://aka.ms/new-console-template for more information
// C# LINQ

// Task 1



int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(i => i % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}


// Task 2

List<Double> studentGrade = new List<double> { 87.5, 45.7, 34.6, 96.6, 84.3 };
var result = studentGrade.Average();
Console.WriteLine(result);




//C# Functions

// Task 1

void greetUser(string name, int age, double balance)
{
    Console.WriteLine("Welcome back " + name + " Your age is " + age + " And your balance is " + balance);
    return;
}

greetUser("Ahmed", 34, 6544.6);

// Task 2

double calculateVolume(double width, double height, double length)
{
    return width * height * length;
}
double vol = calculateVolume(34.5, 21.5, 67.8);
Console.WriteLine(vol);

