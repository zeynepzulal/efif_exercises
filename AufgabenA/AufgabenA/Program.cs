//Aufgabe A1 UND A2

int iamavariable = 8;
// we cant use number as variable names.
int g = 9;
string IchPinEyneWariable = "ich bin eine Variable";
//we CANT use space
double _dbl = 4.3;
//we CANT start with " ! "
//we cant do it like int int = 2; 
bool iAmAVariable = false;



//Aufgabe A3
int Zahl = 1000000000;
Zahl = 2 * Zahl;
Console.WriteLine(Zahl);
Zahl = 3 * Zahl;
Console.WriteLine(Zahl);
Zahl = 4 * Zahl;
Console.WriteLine(Zahl);

//Aufgabe A4
//The data type int in C# represents a 32-bit (4 bytes) long integer.
//Integer values ​​in the range 2**31
//1 bit is used for the sign and the remaining 31 bits represent the value
//Int32.MaxValue --> 2,147,483,647
//Int32.MinValue --> -2,147,483,648


//Aufgabe A5
string msg = "Hello Fritz Fischer. You are 42 years old!";
Console.WriteLine(msg); // Print message

string userInput = Console.ReadLine(); // Get an input from the user and store the input in a variable

//The int.TryParse() method attempts to convert the user's input to an integer.


//Aufgabe A6
//1.
int a = 10023;
int b = 45;
Console.WriteLine(a / b); //Quotient
Console.WriteLine(a % b); //Rest


//2.
bool isDivisible = true;
if (1346 % 17 == 0)
{
    Console.WriteLine(isDivisible);
}
else
{
    Console.WriteLine(!isDivisible);
}