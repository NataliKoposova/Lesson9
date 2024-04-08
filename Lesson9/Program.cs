using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.WriteLine("Введите первое целое число");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе целое число");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(@"Выберите код операции:
            1 - Сложение
            2 - Вычитание 
            3 - Произведение 
            4 - Частное");
            string q = Convert.ToString(Console.ReadLine());
                if (q == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат сложения = {0}", num1 + num2);
                }
                if (q == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат вычитания = {0}", num1 - num2);
                }
                if (q == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат произведения = {0}", num1 * num2);
                }
                if (q == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат частного = {0}", num1 / num2);
                }
            } 
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
                       
            Console.WriteLine();//Предпологаю, что код можно написать через функцию switch/case(пока не догадалась как это сделать)
            Console.ReadKey();
        }
    }
}
