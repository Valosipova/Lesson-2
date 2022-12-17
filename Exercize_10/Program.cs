// Задача 10. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int numberOfDigit = DigitNumber(number);
if (numberOfDigit == 3)
   {
    int result = number / 10 % 10; 
    Console.WriteLine("Вторая цифра числа"+ number + " - это " + result);
   }
else
   {
    Console.WriteLine("Введенное число - " + number + "не является трехзначным" );
   }


int DigitNumber (int number)
{
int numberOfDigit = 0;
int temp = number;
while (temp >= 1)
   {
    temp = temp / 10;
    numberOfDigit ++;
   }
return numberOfDigit;
}