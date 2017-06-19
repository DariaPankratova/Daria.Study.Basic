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
/*
*Создать класс по работе с массивом:
* организовать хранение массива через автосвойство
* конструктор, заполняющий массив 3-мя элементами (по умолчанию - 6,3,9)
* методы:
* запись/чтение элемента массива(2 метода), возвращающие булево значение, выполнена ли операция успешно. Если чтение - возврат жлемента через out пар-р
* запись элемента массива по индексу
* чтение элемента массива по индексу
* среднее значение для массива - свойство
* сортировка массива в зависимости от параметра - по возрастанию или убыванию
* деление 2х элементов по их индексам
* возвращающий новый массив, элементы которого = элемент/порядковый номер
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
            var array = new ArrayAgent();

            var notExit = true;
            var output = "";
            var isDivArrayVisible = false;
            while (notExit)
            {
                Console.Clear();
                Console.WriteLine(
                    $"[{array.GetElement(0)}, " +
                    $"{array.GetElement(1)}, " +
                    $"{array.GetElement(2)}], " +
                    $"{array.Array.Sum()}");
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
                    foreach (var divElement in array.GetDividedByIndexArray())
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
                            var first = Console.ReadLine();
                            if (int.TryParse(first, out int value))
                            {
                                array.SetElement(0, value);
                            }
                            break;
                        }
                    case "2":
                        {
                            var first = Console.ReadLine();
                            if (int.TryParse(first, out int value))
                            {
                                array.SetElement(1, value);
                            }
                            break;
                        }
                    case "3":
                        {
                            var first = Console.ReadLine();
                            if (int.TryParse(first, out int value))
                            {
                                array.SetElement(2, value);
                            }
                            break;
                        }
                    case "4":
                        {
                            output = array.Average.ToString();
                            break;
                        }
                    case "5":
                        {
                            array.Sort(false);
                            break;
                        }
                    case "6":
                        {
                            output = array.DivideElementsByIndex(1, 0);
                            break;
                        }
                    case "7":
                        {
                            notExit = false;
                            break;
                        }
                    case "8":
                        {
                            isDivArrayVisible = true;
                            break;
                        }
                }

            }
        }
    }
}
