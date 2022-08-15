Console.WriteLine("Введите целое число a ");
int a = Convert.ToInt32(Console.ReadLine());
 
if(a >= 100)
    {
        if(a > 999)
            {
            int i = 10;
            while (a / i > 1000)
                {i = i * 10;}
            Console.WriteLine("Третья цифра = " + (a / i) % 10);
            }
            else
            {
            Console.WriteLine("Третья цифра = " + a % 10);
            }
    }
else
    {   
    Console.WriteLine("Третьей цифры нет");
    }