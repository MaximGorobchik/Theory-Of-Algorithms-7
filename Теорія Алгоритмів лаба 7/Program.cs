Console.Write("Введiть N: "); var N = int.Parse(Console.ReadLine());
Random rand = new Random();
int[]array = new int[N];
var writer = new StreamWriter(File.OpenWrite("result.txt"));
Console.WriteLine($"Результат: ");
Console.ForegroundColor= ConsoleColor.Red;
for (int i = 0; i < N; i++)
{
    array[i] = rand.Next(100);
    Console.Write($"{array[i]} ");
    writer.Write($"{array[i]} ");
}
Console.ForegroundColor= ConsoleColor.White;
Console.Write($"{Environment.NewLine}Введiть число для перевiрки на входження: "); var num = int.Parse(Console.ReadLine());
int count = 0;
for (int i=0;i < N;i++)
{
    if (array[i] == num)
    {
        count++;
    }
}
Console.WriteLine($"{num} - {count}");
writer.WriteLine($"{Environment.NewLine}{num} - {count}");
writer.Close();