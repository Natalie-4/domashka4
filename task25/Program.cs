/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите первое число: ");
int A =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B =  Convert.ToInt32(Console.ReadLine());

int Power(int x, int y)
{
    int n = 1;
    for(int j = 1; j <= y; j++)
{
    n = n*x;
}
return n;
}

int N = Power(A,B);
Console.WriteLine(N);

