//Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;
WriteLine("Enter first number: ");
int firstNumber = int.Parse(ReadLine());
WriteLine("Enter second number: ");
int secondNumber = int.Parse(ReadLine());
int FirstNumberDegreeNumberSecond = Degree(firstNumber, secondNumber);
WriteLine($"The first number to the power of the second number is {FirstNumberDegreeNumberSecond}");


int Degree(int A, int B)
{
int result = 1;
    int degree = 1;
        while (degree <= B)
        {
           result *= A;
           degree++;
        }
return result;
}


