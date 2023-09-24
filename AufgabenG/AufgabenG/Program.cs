

//String - Methoden
Console.WriteLine("Please Write a short text");
try
{
    string text = Console.ReadLine();
    Console.WriteLine("your text: " + text);
    string newText = text.Remove(0, 3);
    Console.WriteLine(text.Length);
    newText = newText.Remove(newText.Length - 3, 3);
    Console.WriteLine(newText);
}
catch (Exception e)
{
    Console.WriteLine(e);
}




//Funktionen
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
try
{
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
}
catch (Exception e)
{
    Console.WriteLine(e);
}





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

    if (isPrimeNum(testNum) == true)
    {
        Console.WriteLine("sayi: " + i);
    }
}




// G4 - 1



string sentences = "Hello";
static int Length(string t)
{
    int index = 0;
    while (true)
    {
        try
        {
            int eleman = t[index];
            index++;
        }
        catch (Exception e)
        {
            break;
        }
    }
    return index;
}
Console.WriteLine(Length(sentences));



// G4 - 2
char karakter = 'l';
static int NumberOfChar(char t, string cümle)
{
    int countOfN = 0;
    for (int i = 0; i < cümle.Length; i++)
    {
        if (cümle[i] == t)
        {
            countOfN++;
        }
    }
    return countOfN;
}
Console.WriteLine(NumberOfChar(karakter, sentences));




//G4 - 3
char harf = 'a';
static int PositionOfKarakter(char c, string cümle)
{
    for (int i = 0; i < cümle.Length; i++)
    {
        if (cümle[i] == c)
        {
            return i;
        }
    }
    return -1;

}
Console.WriteLine(PositionOfKarakter(harf, sentences));



// G4-4


string sentences2 = "Be the change you want to see in the world";
char splitChar = ' ';

static List<string> Split(string s, char c)
{
    List<string> newList = new List<string>();
    List<int> indexNumberOfChar = new List<int>();

    int index = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == c)
        {
            //Console.WriteLine(i);
            indexNumberOfChar.Add(i);
            string a = s.Substring(index, i - index);
            index = i + 1;
            //Console.WriteLine(a);
            newList.Add(a);

        }
    }
    string lastWord = s.Substring(index);
    newList.Add(lastWord);

    return newList;
}

List<string> res = Split(sentences2, splitChar);
foreach (var el in res)
{
    Console.WriteLine(el);
}



