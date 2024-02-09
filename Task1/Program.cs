// Задание 1
// Семинар 2
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

System.Console.Write("Введите трезначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int newNumber = leftDigit * 10 + rightDigit;
    System.Console.WriteLine(newNumber);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}