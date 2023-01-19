using static System.Console;
Clear();
//Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
WriteLine("Enter the number: ");
int number = int.Parse(ReadLine());
int sumFigure = Sum(number);
WriteLine($"The sum of the digits of the number {number} is {sumFigure}.");

int Sum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result += (A % 10);
        A /= 10;
    }
    return result;
}