
/* String - Methoden
Console.WriteLine("Please Write a short text");
string text = Console.ReadLine();


Console.WriteLine("your text: " + text);

string newText = text.Remove(0, 3);
Console.WriteLine(newText);
*/


//Funktionen
using System.Threading.Channels;

int sq = square(3);
Console.WriteLine(sq);
static int square(int x)
{
    return x * x;
}

static void SayHi(string name)
{
    // void-function: does something (print to console in this case)
    // but doesn't return anything
    Console.WriteLine("Hello, dear " + name + "!");
}





//Aufgaben G

//G1
int num1 = 6;
int num2 = 7;
int result = summary(num1, num2);
static int summary(int a, int b)
{
    int res = a + b;
    return res
}

//G2
int fahrenheit = fahrenheitToCelcius(212);
static int fahrenheitToCelcius(int a)
{

}







//G3