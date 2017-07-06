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

        public double Average
        {
            get
            {
                return List.Average();
            }
        }

        public int GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public void SetElement(int index, int value)
        {
            throw new NotImplementedException();
        }

        public void Sort(bool isAscending)
        {
            throw new NotImplementedException();
        }

        public bool TryGetElement(int index, out int value)
        {
            throw new NotImplementedException();
        }

        public bool TrySetElement(int index, int value)
        {
            throw new NotImplementedException();
        }
    }
}
