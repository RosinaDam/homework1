using homework1.Types;

//var numbers = new Numbers();

//Numbers numbers = new Numbers();

// See https://aka.ms/new-console-template for more information

//---------------------- Task 1 --------------------------------

Console.WriteLine("Please enter first number:");
string firstNumber = Console.ReadLine();
int firstNumberInt = int.Parse(firstNumber);

Console.WriteLine("Please enter second number:");
string secondNumber = Console.ReadLine();
int secondNumberInt = int.Parse(secondNumber);

Console.WriteLine(firstNumberInt + secondNumberInt);

//---------------------- Task 2 --------------------------------

Console.WriteLine("Please enter your first name:");
string firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine(lastName + " " + firstName);

//---------------------- Task 3 --------------------------------

string sentence = "Sentense to parse this word.";
Console.WriteLine(sentence);

string substr1 = sentence.Substring(0, 8);
Console.WriteLine(substr1.ToUpper());


//---------------------- Task 4 --------------------------------

Console.WriteLine("Please input the radius of a circle:");
string radiusStr = Console.ReadLine();

double radiusDoub = double.Parse(radiusStr);
double pi = Math.PI;

double area = radiusDoub * radiusDoub * pi;

Console.WriteLine(area.ToString("0.##"));

//---------------------- Task 5 --------------------------------

Console.WriteLine("Please enter your age:");

string myAgeS = Console.ReadLine();
int myAgeI;

if (int.TryParse(myAgeS, out myAgeI))
{

    Console.WriteLine("Valid age input:" + myAgeI.ToString());

}
    else {

        Console.WriteLine("Invalid age entered!");

}