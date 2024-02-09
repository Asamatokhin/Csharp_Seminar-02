// Задание 3
//Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber / secondNumber == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет, " + firstNumber % secondNumber); // Конкнатинация строк
    System.Console.WriteLine($"Нет, {firstNumber % secondNumber}"); // f - строка
}