//Aufgaben B1
Console.Write("Please enter an integer");
int userInt = int.Parse(Console.ReadLine());

if (userInt == 42)
{
    Console.WriteLine("The answer to the ultimate question of life, the universe and everything!");
}

else if (userInt > 0)
{

    Console.WriteLine("positive Zahlen (ausser 42)");
}

else if (userInt == 0)
{
    Console.WriteLine("Null)");

}
else
{
    Console.WriteLine("negative Zahlen");
}


//Aufgabe B2
Console.Write("Please enter your name");
string customersName = Console.ReadLine();

Console.Write("Please enter your age");
int customersAge = int.Parse(Console.ReadLine());

Console.Write("Please enter your name");
string customersGender = Console.ReadLine();


if (customersAge >= 18 && customersGender == "woman")
{
    Console.WriteLine("Liebe" + customersName + " viel Spass beim Einkaufen!");
}

else if (customersAge >= 18 && customersGender == "man")
{
    Console.WriteLine("Lieber" + customersName + " viel Spass beim Einkaufen!");
}
else
{
    Console.WriteLine("Leider sind Sie nicht alt genug für einen Einkauf bei uns.");
}