double[,] Fillmassif(int rowsCnt, int columnsCnt)
{
    double[,] massif = new double[rowsCnt, columnsCnt];
    Random rand = new Random();
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int t = 0; t < massif.GetLength(1); t++)
        {
            massif[i, t] = rand.NextDouble() * 100 + 20;
        }
    }
    return massif;
}
void Printmassif(double[,] massif)
{
    for (int i = 0; i < massif.GetLength(0); i++)
    {
        for (int t = 0; t < massif.GetLength(1); t++)
        {
            Console.Write($"{massif[i, t]:f2}" + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] massif = Fillmassif(m, n);
Printmassif(massif);