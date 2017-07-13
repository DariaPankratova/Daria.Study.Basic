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
    public interface IArrayAgent
    {
        decimal Sum { get; }
        int Length { get; }
        decimal Average { get; }
        void SetElement(int index, decimal value);
        bool TrySetElement(int index, decimal value);
        decimal GetElement(int index);
        bool TryGetElement(int index, out decimal value);
        void Sort(bool isAscending);       
    }
}
