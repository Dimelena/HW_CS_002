// Homework 02

// Task 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа. Через строку решать нельзя.

/*
int Request(string req)
{
    Console.Write(req);
    int resalt = Convert.ToInt32(Console.ReadLine());
    return resalt;
}

int num = Request("Input a three-digit number: ");
if (num < 100 || num > 1000)
{
    Console.WriteLine("Repeat the entry (Your number is not a three-digit number).");
    return;
} 
int SecondDigit = num / 10 % 10;
Console.WriteLine("Second digit of number is " + SecondDigit);
*/


// Task 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.

/*
int Request(string req)
{
    Console.Write(req);
    int resalt = Convert.ToInt32(Console.ReadLine());
    return resalt;
}
int CutNumber(int num)
{
    while (num > 1000)
    {
        num /=10;
    }
    return num % 10;
}
bool Verify(int num)
{
    if (num < 100)
    {
        Console.WriteLine("There is no third digit");
        return false;
    }
    return true;
}
int num = Request("Input a number ");
if (Verify(num))
{
    Console.WriteLine(CutNumber(num));
} 
*/
