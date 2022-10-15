// See https://aka.ms/new-console-template for more information
int[] A = new int[100];
int sum = 0; //задаем сумму
Random rnd = new Random();
for (int i = 0; i < A.Length; i++)
{
    A[i] = rnd.Next(1001);
}
Console.WriteLine("Чётные числа");
for (int i = 0; i < A.Length; i++)
{
    if (A[i] % 2 == 0)
    {
        Console.Write(A[i] + ", ");
    }
}
Console.WriteLine();
Console.WriteLine("Кратные трем");
for (int i = 0; i < A.Length; i++)
{
    if (A[i] % 3 == 0)
    {
        Console.Write(A[i] + ", ");
    }
}
Console.WriteLine("Сумма отрицательных чисел");
for (int i = 0; i < A.Length; i++)
{
    if (A[i] < 0)
    {
        sum += A[i];
    }
}
Console.WriteLine(sum);
