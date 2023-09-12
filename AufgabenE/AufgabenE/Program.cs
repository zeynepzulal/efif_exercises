//Aufgabe E1 - Fibonacci-Folge
try
{
    Console.WriteLine("Please enter a number");
    int enteredNum = int.Parse(Console.ReadLine());

    List<int> myList = new List<int>();
    List<int> myNewList = new List<int>();

    for (int i = enteredNum; i >= 0; i--)
    {
        Console.WriteLine(i);
        myList.Add(i);
    }
    for (int i = 0; i < myList.Count - 1; i++)
    {
        int fibonacciFolge = myList[i] + myList[i + 1];
        Console.WriteLine("Fibonacci Folge :" + fibonacciFolge);
        myNewList.Add(fibonacciFolge);
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}








//Aufgabe E2 - Prime Zahlen

try
{
    Console.WriteLine("Please enter a number");
    int enterNum = int.Parse(Console.ReadLine());
    Console.WriteLine("Your Num: " + enterNum);


    bool isPrime = true;

    for (int i = 2; i < enterNum; i++)
    {
        //Console.WriteLine(i);
        if (enterNum % i != 0)
        {
            Console.WriteLine(isPrime);
            break;
        }
        else if (enterNum % i == 0)
        {
            Console.WriteLine(!isPrime);
            break;
        }
    }
}

catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}






//Aufgabe E3 - ggt-kgv

try
{
    Console.WriteLine("enter a number");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter another number");
    int num2 = int.Parse(Console.ReadLine());

    int product = num1 * num2;

    for (; ; )
    {
        int rest = num1 % num2;

        Console.WriteLine("rest: " + rest);

        if (rest == 0)
        {
            Console.WriteLine("ggt: " + num2);
            Console.WriteLine("kgv: " + product / num2);
            break;
        }
        else
        {

            num1 = num2;
            Console.WriteLine("num1: " + num1);
            num2 = rest;
            Console.WriteLine("num2 " + num2);

            rest = num1 % num2;
            Console.WriteLine("yeni rest: " + rest);
        }
    }

}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}