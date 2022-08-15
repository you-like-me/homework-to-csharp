Console.WriteLine("Введите целое число N ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую будет возводиться число N ");
int a = int.Parse(Console.ReadLine());
int index = 1;
while (index <= Math.Abs(N))
{
    Console.Write(Math.Pow(index, a) + ", ");
    index ++;
}