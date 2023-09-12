//Aufgabe D1
for (int i = 10; i <= 20; i++)
{
    Console.WriteLine(i);
}

int numWhileLoop = 10;
while (numWhileLoop <= 20)
{
    Console.WriteLine(numWhileLoop);
    numWhileLoop++;
}

for (int i = 2; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }

}

int evenNumWhileLoop = 2;
while (evenNumWhileLoop <= 20)
{
    if (evenNumWhileLoop % 2 == 0)
    {
        Console.WriteLine(evenNumWhileLoop);
    }

    evenNumWhileLoop++;
}



for (int i = -1; i >= -10; i--)
{
    Console.WriteLine(i);
}

int NumInDescendingOrder = -1;
while (NumInDescendingOrder >= -10)
{
    Console.WriteLine(NumInDescendingOrder);
    NumInDescendingOrder--;
}


//Aufgabe D2
int k = 7;
while (k < 13)
{
    Console.WriteLine(2 * k);
    k++;
}

//Aufgabe D3
// output --->  5,6,7,8,9

int x = 5;
while (x < 10)
{

    if (x == 8)
    {
        break;
    }
    else
    {
        Console.WriteLine(x);
        x++;
    }
}


//Aufgabe D4
Console.WriteLine("Please enter a positive number");
int zahl;
try
{
    zahl = int.Parse(Console.ReadLine());
    while (zahl > 0)
    {
        Console.WriteLine(zahl + "is positive");
    }

}
catch (Exception)
{

    throw;
}

  