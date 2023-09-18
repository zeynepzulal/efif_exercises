
//F1 
int[] naturalNumbers = new int[20];
int[] evenNumbers = new int[20];
int[] squareNumbers = new int[20];
for (int i = 0; i < 20; i++)
{
    naturalNumbers[i] = i;
    evenNumbers[i] = i * 2;
    squareNumbers[i] = i * i;
}

foreach (var item in naturalNumbers)
{
    Console.WriteLine(item);
}

foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

foreach (var item in squareNumbers)
{
    Console.WriteLine(item);
}



// F2 - 1

int[] primeNumbers = new int[20];
bool isPrime = true;
for (int i = 2; i < 100; i++)
{
    for (int j = 2; j < 100; j++)
    {
        if (i % j == 0)
        {
            
            Console.WriteLine(!isPrime + " ,asal sayi degil : " + i);
            break;
        }
        else
        {

            if (isPrime)
            {

                Console.WriteLine(isPrime + " ,asal sayi: " + i);
                primeNumbers[i - 2] = i;
                if (primeNumbers.Length > 20)
                {
                    break;
                }
                

                break;
                
            }

        }
    }
}
foreach (var item in primeNumbers)
{
    Console.WriteLine(primeNumbers);
}



/*
// F2 - 2

int[] fibonacciNumbers = new int[20];

fibonacciNumbers[0] = 1;
fibonacciNumbers[1] = 1;

for(int i = 2; i < fibonacciNumbers.Length; i++)
{
    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];

}

foreach(var item in fibonacciNumbers)
{
    Console.WriteLine("fibonacci num: " + item);
}
*/



// F3

int[] fibonacciNumbers = new int[20];

fibonacciNumbers[0] = 1;
fibonacciNumbers[1] = 1;

for (int i = 2; i < fibonacciNumbers.Length; i++)
{
    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];

}

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine("fibonacci num: " + item);
}


Console.WriteLine("enter the last number");
int sonSayi = int.Parse(Console.ReadLine());
Console.WriteLine("SAYI: " + sonSayi);

bool isFibonacciNum = fibonacciNumbers.Any(x => x == sonSayi);

List<int> newFibonacciNumList = new List<int>();

for (int i = 2; i < sonSayi; i++)
{
    if (isFibonacciNum)
    {
        fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
        int newFibonacciNum = fibonacciNumbers[i];
        newFibonacciNumList.Add(newFibonacciNum);
        if (newFibonacciNumList[newFibonacciNumList.Count - 1] == sonSayi)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("sorry , it is not a fibonacci number");
        break;
    }

}

foreach (var item in newFibonacciNumList)
{
    Console.WriteLine("fibonacci num: " + item);
}