/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите целое число: ");
string number = Console.ReadLine();

if (number.Length < 3)
{
Console.Write("В указанном числе нет третьей цифры:" + " " + number);
}

else

{
Console.WriteLine("Третья чифра введенного числа:" + " " + number[2]);
}


