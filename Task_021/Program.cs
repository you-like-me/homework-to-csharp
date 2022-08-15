Console.WriteLine("Введите координаты точки А: ");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

Console.WriteLine("Длина катета 1 = " + (ax - bx));
Console.WriteLine("Длина катета 2 = " + (ay - by));
Console.WriteLine("Длина катета 3 = " + (az - bz));

double ABC = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

Console.WriteLine("Расстояние между точками = " + ABC);