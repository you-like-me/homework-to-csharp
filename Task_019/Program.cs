Console.WriteLine("Введите целое пятизначное число a ");
int a = Convert.ToInt32(Console.ReadLine());
int SecondDigit = a / 1000;
int FourhtDigit = a % 100;
if((a > 9999) & (a < 100000))
{
    if((a % 10 == a / 10000) & (SecondDigit % 10 == FourhtDigit / 10))
    {
    Console.WriteLine("Число а является палиндромом");
    }
    else
   {
       Console.WriteLine("Число а не является палиндромом");
   }
}
else
{
   Console.WriteLine("Число не пятизначное. Введите пятизначное число ");
}
