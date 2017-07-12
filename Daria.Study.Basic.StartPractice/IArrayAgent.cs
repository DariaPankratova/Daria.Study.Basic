using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.StartPractice
{
    public interface IArrayAgent
    {
        int Sum { get; }
        int Length { get; }
        double Average { get; }
        void SetElement(int index, int value);
        bool TrySetElement(int index, int value);
        int GetElement(int index);
        bool TryGetElement(int index, out int value);
        void Sort(bool isAscending);       
    }
}
