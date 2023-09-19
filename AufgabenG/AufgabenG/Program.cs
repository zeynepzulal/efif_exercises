
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

//G1 - 1
static void AnswerToEverything()
{
    Console.WriteLine("42");
}


//G1 - 2

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
    if (a % 2 == 0)
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

for (int i = 2; i <= 100; i++)
{
    int testNum = i;
    static bool isPrimeNum(int k)
    {

        for (int i = 2; i < k; i++)
        {
            if (k % i == 0)
            {
                return false;
            }

        }

        return true;


    }
    /*
    Console.WriteLine("sayi: " + i);
    Console.WriteLine(isPrimeNum(testNum));
    */
    if (isPrimeNum(testNum) == true)
    {
        Console.WriteLine("sayi: " + i);
    }

}


// G4
string sentences = "Nerds sind nicht normal";

int length = 0;
int countofN = 0;
foreach (var charachter in sentences)
{
    Console.WriteLine(charachter);
    length++;
    Console.WriteLine("length of sentences: " + length);

    if(charachter == "n")
    {
        countofN++;
        Console.WriteLine(countofN);
    }

}

