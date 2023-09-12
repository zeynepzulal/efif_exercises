
/* String - Methoden
Console.WriteLine("Please Write a short text");
string text = Console.ReadLine();


Console.WriteLine("your text: " + text);

string newText = text.Remove(0, 3);
Console.WriteLine(newText);
*/

/*
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
} */





//Aufgaben G

//G1 - 2
using System.Security;

int num1 = 6;
int num2 = 7;
int result = summary(num1, num2);
static int summary(int a, int b)
{
    int res = a + b;
    return res;
}

Console.WriteLine(result);


//G1 - 3
Console.WriteLine("enter a number");
int enteredNum = int.Parse(Console.ReadLine());
static bool isEven(int a)
{
    if(a % 2 == 0)
    {
        return true;
    }

    else
    {
        return false;
    }
}

Console.WriteLine(isEven(enteredNum));



//G2 - 1

int fahrenheit = 212;
static int fahrenheitToCelcilus(int f)
{
    int celcileus = (f - 32) * 5 / 9;
    return celcileus;
}
Console.WriteLine(fahrenheitToCelcilus(fahrenheit));



// G2-2

int celcileus = 100;
static int celcilusToFahrenheit(int c)
{
    int fahrenheit = c * 9 / 5 + 32;
    return fahrenheit;
}
Console.WriteLine(celcilusToFahrenheit(celcileus));

//G3
