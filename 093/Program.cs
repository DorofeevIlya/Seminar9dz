//  93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

System.Console.Write("Введите количество строк в массиве А  :");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов в массиве А:");
int k = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк в массиве Б :");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов в массиве Б:");
int s = Convert.ToInt32(Console.ReadLine());
int[,] a = RandomDuoArray(n, k);
PrintDuoArray (a);
System.Console.WriteLine();
int[,] b = RandomDuoArray2(m, s);
PrintDuoArray2 (b);
PeremnozitArray(a,b);
System.Console.WriteLine();
PrintDuoArray (a);
int[,] RandomDuoArray(int n, int k)
{
    int[,] a = new int[n, k];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(0, 10);
    return a;
}
void PrintDuoArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],5}");
        System.Console.WriteLine();
    }
}
int[,] RandomDuoArray2(int m, int s)
{
    int[,] b = new int[m, s];
    Random random = new Random();
    for (int i = 0; i < b.GetLength(0); i++)
        for (int j = 0; j < b.GetLength(1); j++)
            b[i, j] = random.Next(0, 10);
    return b;
}
void PrintDuoArray2(int[,] b)

{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
            System.Console.Write($"{b[i, j],5}");
        System.Console.WriteLine();
    }
}
void PeremnozitArray(int[,] a,int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            {
                a[i, j] = a[i, j]*b[i, j];
            } 
        }
    }
}
