/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите любое число: ");
string? Number = Console.ReadLine();
int dlina = Number.Length;
int chislo = Convert.ToInt32(Number);
int SumDigits = 0;
int count = 0;
while (count <= dlina)
{
    int digit = chislo % 10;
    SumDigits = SumDigits + digit;
    int interValue = chislo / 10;
    chislo = interValue;
    count++;
}
Console.WriteLine(SumDigits);