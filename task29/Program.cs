// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//   1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Задайте массив из восьми элементов: ");
int [] array = new int [8];
for (int x = 0; x < array.Length; x++)
{
    array[x] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[" + string.Join(", ", array) + "]");

