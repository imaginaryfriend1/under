//Задайте одномерный массив, заполненный случайными числами. Найдите сумму
 //элементов, стоящих на нечётных позициях.
int[] array = new int[5];
Random rand = new Random();
int cnt = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-20, 20);
}
for (int i = 1; i < array.Length; i += 2)
{
    cnt = array[i] + cnt;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(cnt);