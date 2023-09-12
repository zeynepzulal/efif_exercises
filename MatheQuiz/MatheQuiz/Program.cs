int wrongAnswer = 0;
Random rand = new Random();

try
{
    while (true)
    {



        int firstNum = rand.Next(1, 10); //1-10 arasi random sayi üretecek
        Console.WriteLine("First Number: " + firstNum);

        int secondNum = rand.Next(1, 10);
        Console.WriteLine("Secon Number: " + secondNum);




        Console.Write("Please enter an operator: + , -  or * ");
        string operators = Console.ReadLine();

        Console.WriteLine("Operator: " + operators);
        Console.WriteLine("Please solve the question according to the operator you choose");
        Console.WriteLine("Please write your guess");
        int yourRes = int.Parse(Console.ReadLine());
        Console.WriteLine("your res: " + yourRes);


        int realRes;
        if (operators == "+")
        {
            realRes = firstNum + secondNum;

        }
        else if (operators == "-")
        {
            realRes = firstNum - secondNum;

        }

        else if (operators == "*")
        {
            realRes = firstNum * secondNum;

        }

        else
        {
            Console.WriteLine("Invalid operator. Please enter +, - or *.");
            continue; // Döngünün başına dön
        }

        if (realRes == yourRes)
        {
            Console.WriteLine("Congrats, you can continue the game");
            Console.ReadLine();

        }

        else
        {
            Console.WriteLine("Sorry!!!!");
            wrongAnswer++; // Yanlış cevap sayacını arttır
            Console.WriteLine("Wrong answer count: " + wrongAnswer);

            if (wrongAnswer >= 3) // Örneğin 3 yanlış cevapta oyunu bitir
            {
                Console.WriteLine("You've reached 3 wrong answers. Game over!");
                break; // Döngüden çık
            }
        }


    }

}
catch (Exception e)
{
    Console.WriteLine(e);
}