// Homework 02

// Task 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа. Через строку решать нельзя.

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