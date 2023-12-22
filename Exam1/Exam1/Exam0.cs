using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam1
{
    internal class Exam0
    { 
        public static void Main(string[] args)
        {
           
            Random rand = new Random();
            int i = rand.Next(0, 11);
            int count = 1;
            Console.WriteLine("Компьютер загадал число от 0 до 10.Угадайте его");
            Console.WriteLine("Введите первое число");
            int k = Convert.ToInt32(Console.ReadLine());
            while (count <= 3)
              {
                if (i == k)
                {
                    Console.WriteLine("Компьютер загадал число " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Вы не угадали!. Загаданное число было"  + i + "!" );
                        break;
                    }
                    Console.WriteLine("Нет,это не число " + k + "! Попытка № " + count +":");
                    k = Convert.ToInt32(Console.ReadLine());
                }

              }
            Console.ReadLine();

        }
    
    }
}
