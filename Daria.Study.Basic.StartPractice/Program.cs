using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Открывать консоль
 * Вывести на экран:
 * 1-я - массив из 3х эл-тов
 * 
 * меню программы:
 * 1 - ввести первый элемент
 * 2-ввести второй
 * 3-ввести 3й
 *  4-я строка - среднее по массиву
 * 5-я - отсортировать по убыванию
 * 6-я - разделить 2й эл-т на 1-й с использованием дробного деления
 * 7- Выход
 * Все результаты -после меню, старый результат удалять
 */
namespace Daria.Study.Basic.StartPractice
{
    class Program
    {
        static void Main(string[] args)
        {           
            /*
void Console.WriteLine(string value);
void Console.Write(string value);
string Console.ReadLine();
bool int.TryParse(string value, out int result);
*/
            var arr = new [] {4,7,8};
            var notExit = true;
            
            while (notExit)
            {
                Console.Clear();
                Console.WriteLine($"[{arr[0]}, {arr[1]}, {arr[2]}]");
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Ввести первый элемент");
                Console.WriteLine("2 - Ввести второй элемент");
                Console.WriteLine("3 - Ввести третий элемент");
                Console.WriteLine("4 - Вывести среднее значение массива");
                Console.WriteLine("5 - Отсортировать по убыванию");
                Console.WriteLine("6 - Разделить второй элемент на первый");
                Console.WriteLine("7 - Выход");
                
                var result = Console.ReadLine();


                switch (result)
                {
                    case "1":
                        {
                            int value;
                            var first = Console.ReadLine();
                            if (int.TryParse(first,out value))
                            {
                                arr[0] = value;
                            }                                       
                            break;
                        }
                    case "2":
                        {
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    case "5":
                        {
                            break;
                        }
                    case "6":
                        {
                            break;
                        }
                    case "7":
                        {
                            notExit = false;
                            break;
                        }

                }

                Console.WriteLine();
            }
        }
    }
}
