using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.StartPractice
{
    class ArrayAgent:IArrayAgent
    {
        private int[] Array { get; set; } = new int[3];
        public ArrayAgent(int first = 6, int second = 3, int third = 9)
        {
            Array[0] = first;
            Array[1] = second;
            Array[2] = third;
        }
        public int Length
        {
            get
            {
                return Array.Length;
            }
        }
        public int Sum
        {
            get
            {
                return Array.Sum();
            }
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
    }
}
