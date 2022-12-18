// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326 -> 6

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int numberOfDigit = DigitNumber(number);
if (numberOfDigit == 3)
   {
    int result = number % 10; 
    Console.WriteLine("Третья цифра числа "+ number + " - это " + result);
   }
else
   {
    Console.WriteLine("Введенное число - " + number + " не является трехзначным, третьей цифры нет" );
   }

int DigitNumber (int number)
{
int numberOfDigit = 1;
int temp = number;
while (temp >= 2)
   {
    temp = temp / 100;
    numberOfDigit ++;
   }
return numberOfDigit;
}