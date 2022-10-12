//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

int[,] Fillmassif(int rowsCnt, int columnsCnt, int leftRange = 10, int rightRange = 99)
{
    int[,] massif = new int[rowsCnt, columnsCnt];

    Random rand = new Random();

    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int t = 0; t < massif.GetLength(1); t++)
        {
            massif[i, t] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return massif;
}
void PrintMatrix(int[,] massif)
{
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int t = 0; t < massif.GetLength(1); t++)
        {
            Console.Write(massif[i, t] + " ");
        }
        Console.WriteLine();
    }
}
int[,] massif = Fillmassif(10, 10);
PrintMatrix(massif);
Console.WriteLine("Введите позицию строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца");
int n = Convert.ToInt32(Console.ReadLine());
void IndexMassif(int[,] massif)
{
    if (m >= 0 && m < massif.GetLength(0) && n >= 0 && n < massif.GetLength(1))
    {
        Console.WriteLine(massif[m, n]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}
IndexMassif(massif);

