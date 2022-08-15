Console.WriteLine("Введите целое число n от 1 до 7 ");
int n = Convert.ToInt32(Console.ReadLine());
if((n ==0) ^ (n <= 7))
{
    if((n == 6) ^ (n == 7))
    {
        Console.WriteLine("Выходной");
    
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
    
}
else
{
    Console.WriteLine("Ошибка: число не соответствует необходимым параметрам ");
}    