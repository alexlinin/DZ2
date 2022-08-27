/*
Задача 10 нужно решить через ЦЕЛЫЕ ЧИСЛА, без строчек
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string number1 = Convert.ToString(number);

if (number1.Length != 3)
{
Console.Write("Вы указали не трехзначное число: ");
Console.WriteLine(number);
}

else

{number = number%100/10;
Console.WriteLine("Вторая чифра введенного числа:" + " " + number);
}


