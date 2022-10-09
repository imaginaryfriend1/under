// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

int [] array = new int[5];
Random random = new Random();
int count = 0;
for (int i =0; i <array.Length; i++)
{
    array[i] = random.Next(100,1000);
    if (array[i] % 2 ==0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count);