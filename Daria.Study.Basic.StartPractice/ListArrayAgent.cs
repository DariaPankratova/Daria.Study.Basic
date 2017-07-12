using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.StartPractice
{
    class ListArrayAgent : IArrayAgent
    {
        private List<int> List { get; set; } = new List<int>(3);
        public int Sum
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
        public double Average
        {
            get
            {
                return List.Average();
            }
        }

        public int GetElement(int index)
        {
            return List[index];
        }
        public bool TryGetElement(int index, out int value)
        {
            if (index >= List.Count)
            {
                value = 0;
                return false;
            }
            value = GetElement(index);
            return true;
        }
        public void SetElement(int index, int value)
        {
            List[index] = value;
        }
        public bool TrySetElement(int index, int value)
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
