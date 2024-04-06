using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float a, b, c;
            char sign;
            Console.Write("Введите первое число: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите знак действия : ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите Второе число: ");
            b = Convert.ToSingle(Console.ReadLine());
            if (sign == '+')
            {
                c = a + b;
                Console.WriteLine("Сумма ваших чисел равна " + c);
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                c = a - b;
                Console.WriteLine("Разность ваших чисел равна " + c);
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                c = a * b;
                Console.WriteLine("Произведение ваших чисел равно " + c);
                Console.ReadKey();
            }
            else if (sign == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    Console.ReadKey();
                }
                else
                {
                    c = a / b;
                    Console.WriteLine("Частное ваших чисел равно " + c);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Вы ввели неверный знак.");
                Console.ReadKey();


            }
        }

    }
}
