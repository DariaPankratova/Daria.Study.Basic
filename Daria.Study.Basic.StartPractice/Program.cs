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
 * 8-вывод эл-тов массива/порядковый номер
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
            var array = new[] { 4, 8, 7 };
            var divArray = new int[3];
            var notExit = true;
            var output = "";
            var isDivArrayVisible = false;

            while (notExit)
            {
                Console.Clear();
                Console.WriteLine($"[{array[0]}, {array[1]}, {array[2]}], {array.Sum()}");
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Ввести первый элемент");
                Console.WriteLine("2 - Ввести второй элемент");
                Console.WriteLine("3 - Ввести третий элемент");
                Console.WriteLine("4 - Вывести среднее значение массива");
                Console.WriteLine("5 - Отсортировать по убыванию");
                Console.WriteLine("6 - Разделить второй элемент на первый");
                Console.WriteLine("7 - Выход");
                
                if (isDivArrayVisible)
                {
                    foreach (var divElement in divArray)
                    {
                        Console.WriteLine(divElement);
                    }
                    isDivArrayVisible = false;
                }
                else Console.WriteLine(output);
                var result = Console.ReadLine();


                switch (result)
                {
                    case "1":
                        {
                            //int value;
                            var first = Console.ReadLine();
                            if (int.TryParse(first, out int value))
                            {
                                array[0] = value;
                            }
                            break;
                        }
                    case "2":
                        {
                            var first = Console.ReadLine();
                            if (int.TryParse(first, out int value))
                            {
                                array[1] = value;
                            }
                            break;
                        }
                    case "3":
                        {
                            var first = Console.ReadLine();
                            if (int.TryParse(first, out int value))
                            {
                                array[2] = value;
                            }
                            break;
                        }
                    case "4":
                        {
                            output = (array.Sum() / array.Length).ToString();
                            break;
                        }
                    case "5":
                        {
                            Array.Sort(array);
                            //array = array.Reverse().ToArray();
                            Array.Reverse(array);
                            break;
                        }
                    case "6":
                        {
                            if (array[0] != 0)
                            {
                                output = ((double)array[1] / array[0]).ToString("0.##");
                            }
                            else output = "Infinity";
                            break;
                        }
                    case "7":
                        {
                            notExit = false;
                            break;
                        }
                    case "8":
                        {
                            for (var i = 0; i < array.Length; i++)
                            {
                                divArray[i] = array[i] / (i+1);
                            }
                            isDivArrayVisible = true;
                            break;
                        }
                }

            }
        }
    }
}
