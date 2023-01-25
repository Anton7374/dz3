Console.Write($"Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= n)
{

   Console.Write($"{Math. Pow(count, 3)}");
   if (count < n) Console.Write(",");
   count++;
}
