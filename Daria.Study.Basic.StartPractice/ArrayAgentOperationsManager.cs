using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.StartPractice
{
    abstract class ArrayAgentOperationsManager
    {
        IArrayAgent _arrayAgent;
        protected ArrayAgentOperationsManager(IArrayAgent arrayAgent)
        {
            _arrayAgent = arrayAgent;
        }

        protected abstract decimal PerformDivision(decimal firstElement, decimal secondElement);

        public string DivideElementsByIndex(int firstIndex, int secondIndex)
        {
            if (_arrayAgent.GetElement(secondIndex) == 0) return "Infinity";
            return PerformDivision(_arrayAgent.GetElement(firstIndex),
                _arrayAgent.GetElement(secondIndex))
                .ToString("0.##");
        }
        public IArrayAgent GetDividedByIndexArray()
        {
            var outArrayAgent = new ArrayAgent();
            for (var index = 0; index < outArrayAgent.Length; index++)
            {
                outArrayAgent.SetElement(index, PerformDivision(_arrayAgent.GetElement(index),(index + 1)));
            }
            return outArrayAgent;
        }
    }
}
