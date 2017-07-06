using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Создать класс по работе с массивом:
 * организовать хранение массива через автосвойство+
 * конструктор, заполняющий массив 3-мя элементами (по умолчанию - 6,3,9)+
 * методы:
 *+ запись/чтение элемента массива(2 метода), возвращающие булево значение, выполнена ли операция успешно. Если чтение - возврат жлемента через out пар-р
 * запись элемента массива по индексу+
 * чтение элемента массива по индексу+
 * среднее значение для массива - свойство+
 * сортировка массива в зависимости от параметра - по возрастанию или убыванию+
 * деление 2х элементов по их индексам+
 * возвращающий новый массив, элементы которого = элемент/порядковый номер
 
  * ArrayAgent разбить на группу классов:
  * 1-Хранение массива и доступ к операциям типа чтение/запись, сортировка - все операции через интерфейс
  * Интерфейс реализуют 2 класса:
  * 1.1 -использует массив для хранения данных
  * 1.2 - исп. список
  * 2-классы для реализации сложных операций над массивом-3 класса:
  * 2.1 базовый класс, реализ шаблонный метод (DivideElementsByIndex) и GetDividedByIndexArray
  * 2.2 реализует делегируемый метод PerformDivisionByIndex с целочисленным делением
  * 2.3 то же, что и 2.2 - с дробным
  * точка входа - в 2.1, 2 связана с 1 композицией (2->1)
  * 
  * 
  * 
  */


namespace Daria.Study.Basic.StartPractice
{
    class ArrayAgent_old
    {
        public int[] Array { get; private set; } = new int[3];
        public ArrayAgent_old(int first = 6, int second = 3, int third = 9)
        {
            Array[0] = first;
            Array[1] = second;
            Array[2] = third;
        }
        public double Average
        {
            get
            {
                return Array.Average();
            }
        }
        public void SetElement(int index, int value)
        {
            Array[index] = value;
        }
        /// <summary>
        /// Устанавливает элемент по индексу (безопасно)
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        /// <param name="value">Новое значение</param>
        /// <returns>Успешна ли операция</returns>
        public bool TrySetElement(int index, int value)
        {
            if (index >= Array.Length) return false;
            SetElement(index, value);
            return true;
        }
        public int GetElement(int index)
        {
            return Array[index];
        }
        public bool TryGetElement(int index, out int value)
        {
            if (index >= Array.Length)
            {
                value = 0;
                return false;
            }
            value = GetElement(index);
            return true;
        }

        public void Sort(bool isAscending)
        {
            System.Array.Sort(Array);
            if (!isAscending) System.Array.Reverse(Array);
        }
        ////////////////////////////
        private double PerformDivisionByIndex(int firstIndex, int secondIndex)
        {
            return (double)Array[firstIndex] / Array[secondIndex];
        }
        public string DivideElementsByIndex(int firstIndex, int secondIndex)
        {
            if (Array[secondIndex] == 0) return "Infinity";
            return PerformDivisionByIndex(firstIndex, secondIndex).ToString("0.##");
        }
        public int[] GetDividedByIndexArray()
        {
            var outArray = new int[Array.Length];
            for (var index = 0; index < Array.Length; index++)
            {
                outArray[index] = Array[index] / (index + 1);
            }
            return outArray;
        }
    }
}
