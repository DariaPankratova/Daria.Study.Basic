using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.StartPractice
{
    class ListArrayAgent : IArrayAgent
    {
        private List<decimal> List { get; set; } = new List<decimal>(3);
        public decimal Sum
        {
            get
            {
                return List.Sum();
            } 
        }
        public int Length
        {
            get
            {
                return List.Count;
            }
        }
        public decimal Average
        {
            get
            {
                return List.Average();
            }
        }

        public decimal GetElement(int index)
        {
            return List[index];
        }
        public bool TryGetElement(int index, out decimal value)
        {
            if (index >= List.Count)
            {
                value = 0;
                return false;
            }
            value = GetElement(index);
            return true;
        }
        public void SetElement(int index, decimal value)
        {
            List[index] = value;
        }
        public bool TrySetElement(int index, decimal value)
        {
            if (index >= List.Count) return false;
            SetElement(index, value);
            return true;
        }
        public void Sort(bool isAscending)
        {
            List.Sort();
            if (!isAscending) List.Reverse();
        }
              
    }
}
